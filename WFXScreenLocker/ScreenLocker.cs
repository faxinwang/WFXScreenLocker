using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LockScreen
{
    public partial class ScreenLocker : Form
    {
        Hook.HOOKPROC hookProc;
        Hook hook;

        private string PWD = null;
        Random rand = new Random();

        double minOpac = 0.3, maxOpac = 0.9, step;
        bool flag = true;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer KillTaskManager = new System.Windows.Forms.Timer();


        public int MyKeyboardProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
                if (kbh.vkCode == (int)Keys.LWin )
                {
                    //MessageBox.Show("拦截了Win键");
                    return 1;
                }
                if(kbh.vkCode == (int)Keys.F4 && Control.ModifierKeys == Keys.Alt)
                {
                    //MessageBox.Show("拦截了Alt+F4");
                    return 1;
                }

                if(kbh.vkCode == (int)Keys.Tab && Control.ModifierKeys == Keys.Alt)
                {
                    //MessageBox.Show("拦截了Alt+Tab");
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Escape && Control.ModifierKeys == Keys.Control)
                {
                  //  MessageBox.Show("拦截了Ctrl+Esc");
                    return 1;
                }

                if(kbh.vkCode == (int)Keys.Tab && Control.ModifierKeys ==(Keys.Alt | Keys.Control))
                {
                    //拦截 Ctrl + Alt + Tab
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Delete && (int)Control.ModifierKeys ==  ( (int)Keys.Alt | (int)Keys.Control))
                {
                 //   MessageBox.Show("捕捉到Ctrl+Alt+Delete");
                    return 1;
                }
                
            }
            return 0;
           // return Win32API.CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        //安装键盘钩子
        public void HookStart()
        {
           try
           {
                //实例化一个HookProc
                //  KeyBoardProcedure = new Win32API.HookProc(KeyBoardHookProc);
                hookProc = new Hook.HOOKPROC(MyKeyboardProc);
                hook = new GlobalHook(hookProc);
                hook.hHook = hook.SetWindowsHookEx();
                if( hook.hHook == 0 )
                {
                    //卸载钩子
                    hook.UnhookWindowsHookEx();
                    MessageBox.Show("安装钩子失败!" );
                    Application.Exit();
                }
           }catch(Exception exc)
           {
                MessageBox.Show("安装钩子失败:" + exc.Message);
                Application.Exit();
           }
        }
        

        public ScreenLocker()
        {
            InitializeComponent();
            Utils.checkIniFile();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None; //不显示边框
            this.BackColor = Utils.getLookScreenColor();
            this.TopMost = true; //设置该窗体为最顶层窗体
            //this.TopLevel = true;
            
            PWD = Utils.getPassword();

            //读取透明度设置并转化为百分值
            minOpac = Utils.getMinOpacity() / 100.0;
            maxOpac = Utils.getMaxOpacity() / 100.0;
            step = (maxOpac - minOpac) / 50;
            this.Opacity = minOpac;
            //将鼠标指针局限在panel1内
            Rectangle rect = new Rectangle(panel1.Left, panel1.Top, panel1.Width, panel1.Height);
            Win32API.ClipCursor(out rect);

            //控制不透明度
            if( step > 0)
            {
                timer.Tick += Timer_Tick;
                timer.Interval = 50; //每秒刷屏20次
                timer.Start();
            }

            //杀掉任务管理器
            KillTaskManager.Interval = 500;
            KillTaskManager.Tick += KillTaskManager_Tick;
            KillTaskManager.Start();

            //启动Hook,截获键盘事件
            HookStart(); 
        }

        private void KillTaskManager_Tick(object sender, EventArgs e)
        {
            //获取任务管理器进程
            Process[] remoteAll = Process.GetProcessesByName("taskmgr");
            foreach(Process pro in remoteAll)
            {
                pro.Kill();
            }
        }

        //每秒将窗体的透明度增加或减少20个step
        private void Timer_Tick(object sender, EventArgs e)
        {
            //减小密码框的透明度
            Color oldCol = panel1.BackColor;
            int a = oldCol.A - 5;
            if (a <= 0) a = 0;
            Color col = Color.FromArgb(a, oldCol.R, oldCol.G, oldCol.B);
            panel1.BackColor = col;

            //设置焦点到输入控件上.
            TBox_pwd.Focus();
            
            //循环改变锁屏窗体的透明度
            if(flag == true)
            {  
                //减小不透明度
                this.Opacity -= step;
                if(this.Opacity <= minOpac)
                {
                    flag = false;
                }
            }
            else
            {
                //增加不透明度
                this.Opacity += step;
                if(this.Opacity >= maxOpac )
                {
                    flag = true;
                }
            }
        }

        void onWrongPassword()
        {
            Color col = Color.FromArgb(255,rand.Next(256),
                        rand.Next(256), rand.Next(256));
            panel1.BackColor = col;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PWD == Win32API.MD5_Str(TBox_pwd.Text.Trim()))
            {
                //关闭当前窗体，打开程序主状体;
                hook.UnhookWindowsHookEx();
                new MainForm().Show();
                timer.Stop();
                timer.Dispose();
                KillTaskManager.Stop();
                KillTaskManager.Dispose();
                this.Close();
            }else
            {
                onWrongPassword();
            }
        }

        /// <summary>
        /// Enter键结束输入，否则检测并限制密码长度在16位以内。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            else
            {
                if (TBox_pwd.TextLength >= 16)
                    TBox_pwd.Text = TBox_pwd.Text.Substring(0, 15);
            }
        }

        //判断窗口关闭事件是否由用户点击右上角关闭按钮引发的.如果是,则整个程序退出.否则就只是关闭该窗体.
        protected override void WndProc(ref Message msg)
        {
            //Windows系统消息，winuser.h文件中有WM_...的定义
            //十六进制数字，0x是前导符后面是真正的数字
            const int WM_SYSCOMMAND = 0x0112;
            //winuser.h文件中有SC_...的定义
            const int SC_CLOSE = 0xF060;

            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                // 点击winform右上关闭按钮 
                // 加入想要的逻辑处理
                //Application.Exit();
                return;//阻止了窗体关闭
            }
            base.WndProc(ref msg);
        }
    }
}
