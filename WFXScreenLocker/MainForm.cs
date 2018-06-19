using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace LockScreen
{
    public partial class MainForm : Form
    {
        Hook hook;

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
         //   this.ControlBox = false;
            this.MaximizeBox = false;
            //  this.MinimizeBox = false;

            //设置两个按钮的背景颜色为半透明
            Btn_lock.BackColor = ColorTranslator.FromHtml("#33ee0000");
            Btn_set.BackColor = ColorTranslator.FromHtml("#3300ee00");

            //设置Ctrl + Alt + L锁屏快捷键.
            hook = new GlobalHook(new Hook.HOOKPROC(myKeyboardHookProc));
            try
            {
                hook.hHook = hook.SetWindowsHookEx();
            }
            catch (Exception exc) { Console.WriteLine(exc.Message); }
        }

        private int myKeyboardHookProc(int nCode, int wParam, IntPtr lParam)
        {

            KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
            if (kbh.vkCode == (int)(Keys.L) && Control.ModifierKeys == (Keys.Control | Keys.Alt))
            {
                lockScreen();
                return 1;
            }
            //return 0;
            return Win32API.CallNextHookEx(hook.hHook, nCode, wParam, lParam);
        }

        private void lockScreen()
        {
            hook.UnhookWindowsHookEx();
            new ScreenLocker().Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lockScreen();
        }

        //打开设置界面
        private void button2_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
        }

        //双击托盘图标时显示主窗体
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //窗体最小化后隐藏窗体
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        //判断窗口关闭事件是否由用户点击右上角关闭按钮引发的.
        //如果是,则整个程序退出.否则就只是关闭该窗体.
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
                //卸载快捷键键盘钩子
                hook.UnhookWindowsHookEx();
                notifyIcon.Dispose();
                Application.Exit();
                //return;//阻止了窗体关闭
            }
            base.WndProc(ref msg);
        }

        /*
        //Ctrl + Alt + L 快捷键锁屏
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == (Keys.Control | Keys.Alt) && e.KeyCode == Keys.L )
            {
                lockScreen();
            }
        }

        //获取全局键盘事件, 如果是Ctrl+Alt+L锁屏快捷键，则进行锁屏
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.Alt | Keys.L) )
            {
                lockScreen();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        */
    }
}
