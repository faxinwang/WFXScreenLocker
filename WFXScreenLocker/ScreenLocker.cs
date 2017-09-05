﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LockScreen
{
    public partial class ScreenLocker : Form
    {
        //  Win32API.HookProc KeyBoardProcedure;
        Hook.HOOKPROC hookProc;
        Hook hook;
        static int hHook = 0;       //钩子函数的句柄
        public const int WH_KeyBoard = 13;
        private string PWD = null;
        Random rand = new Random();

        double minOpac = 0.3, maxOpac = 0.9, step;
        bool flag = true;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer KillTaskManager = new System.Windows.Forms.Timer();

        //钩子结构函数
        public struct KeyBoardHookStruct
        {
            public int vkCode;
            public int ScandCode;
            public int flags;
            public int time;
            public int ExtraInfo;
        }



        public int MyKeyboardProc(int nCode, int wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
                if (kbh.vkCode == (int)Keys.LWin )
                {
                //    MessageBox.Show("拦截了Win键");
                    return 1;
                }
                if(kbh.vkCode == (int)Keys.F4 && Control.ModifierKeys == Keys.Alt)
                {
                 //   MessageBox.Show("拦截了Alt+F4");
                    return 1;
                }

                if(kbh.vkCode == (int)Keys.Tab && Control.ModifierKeys == Keys.Alt)
                {
                //    MessageBox.Show("拦截了Alt+Tab");
                    return 1;
                }

                if (kbh.vkCode == (int)Keys.Escape && Control.ModifierKeys == Keys.Control)
                {
                  //  MessageBox.Show("拦截了Ctrl+Esc");
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
            
            if(hHook == 0)
            {
               try
               {
                    //实例化一个HookProc
                    //  KeyBoardProcedure = new Win32API.HookProc(KeyBoardHookProc);
                    hookProc = new Hook.HOOKPROC(MyKeyboardProc);
                    hook = new GlobalHook(hookProc);

                    if( hook.SetWindowsHookEx() ==0 )
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
                this.Close();
            }else
            {
                onWrongPassword();
            }
        }

        private void TBox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (PWD == Win32API.MD5_Str(TBox_pwd.Text.Trim()))
                {
                    //关闭当前窗体，打开程序主状体;
                    hook.UnhookWindowsHookEx();
                    new MainForm().Show();
                    this.Close();
                }
                else
                {
                    onWrongPassword();
                }
            }
        }
    }
}
