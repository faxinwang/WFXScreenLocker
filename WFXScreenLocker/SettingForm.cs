﻿using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LockScreen;

namespace LockScreen
{
    public partial class SettingForm : Form
    {

        public SettingForm()
        {
            InitializeComponent();

            Panel_oldColor.BackColor = Utils.getLookScreenColor();
            trackBar_maxOpac.Value = Utils.getMaxOpacity();
            trackBar_minOpac.Value = Utils.getMinOpacity();
            tab4_cbox_openRun.Checked = Utils.getOpenRun();
            lab_maxOpac.Text = "最大不透明度: " + trackBar_maxOpac.Value;
            lab_minOpac.Text = "最小不透明度: " + trackBar_minOpac.Value;
            Color color = Utils.getLookScreenColor();
            TrackBar_R.Value = color.R;
            TrackBar_G.Value = color.G;
            TrackBar_B.Value = color.B;

            TrackBar_R.Scroll += TrackBar_Scroll;
            TrackBar_G.Scroll += TrackBar_Scroll;
            TrackBar_B.Scroll += TrackBar_Scroll;
            tab1_btn_cancel.Click += new EventHandler(closeWindow);
            tab2_btn_cancel.Click += new EventHandler(closeWindow);
            tab3_btn_cancel.Click += new EventHandler(closeWindow);
            tab4_btn_cancel.Click += new EventHandler(closeWindow);
            trackBar_maxOpac.Scroll += TrackBar_maxOpac_Scroll;
            trackBar_minOpac.Scroll += TrackBar_minOpac_Scroll;
        }

        private int min(int a,int b)
        {
            return a < b ? a : b;
        }
        private int max(int a,int b)
        {
            return a > b ? a : b;
        }

        private void TrackBar_minOpac_Scroll(object sender, EventArgs e)
        {
            lab_minOpac.Text = "最小不透明度:" + trackBar_minOpac.Value;
            if(trackBar_minOpac.Value > trackBar_maxOpac.Value)
            {
                trackBar_maxOpac.Value = min(trackBar_minOpac.Value + 1, 100);
                lab_maxOpac.Text = "最大不透明度:" + trackBar_maxOpac.Value;
            }
        }

        private void TrackBar_maxOpac_Scroll(object sender, EventArgs e)
        {
            lab_maxOpac.Text = "最大不透明度:" + trackBar_maxOpac.Value;
            if( trackBar_maxOpac.Value < trackBar_minOpac.Value)
            {
                trackBar_minOpac.Value = max(trackBar_maxOpac.Value - 1, 10);
                lab_minOpac.Text = "最小不透明度:" + trackBar_minOpac.Value;
            }
        }

        private void Btn_modify_Click(object sender, EventArgs e)
        {
            string Pwd_src = Utils.getPassword();
            string Pwd_cur = Win32API.MD5_Str(TBox_pwd1.Text.Trim());
            if (Pwd_src != Pwd_cur)
            {
                MessageBox.Show("输入密码不正确!");
            }
            else
            {
                string pwd2 = TBox_pwd2.Text.Trim();
                string pwd3 = TBox_pwd3.Text.Trim();
                if(pwd2.Length > 16)
                {
                    MessageBox.Show("密码长度不能超过16位");
                    return;
                }
                if (pwd2 == pwd3 && pwd2 != "")
                {
                    try
                    {
                        Utils.setPassword(pwd2);
                        MessageBox.Show("密码修改成功!");
                        this.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("修改密码失败:" + exc.Message);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致或密码为空,请重新输入!");
                }
            }
        }


        //设置锁屏颜色
        private void Btn_SetColor_Click(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(255,
                TrackBar_R.Value,
                TrackBar_G.Value,
                TrackBar_B.Value);
            String colStr = ColorTranslator.ToHtml(newColor);
            Utils.setLockScreenColor(colStr);
            this.Close();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            Panel_newColor.BackColor = Color.FromArgb(255,
                TrackBar_R.Value,
                TrackBar_G.Value,
                TrackBar_B.Value);
            TrackBar tb = sender as TrackBar;
            if(tb.Name == "TrackBar_R")
            {
                Lb_R.Text = "R:" + TrackBar_R.Value;
            }else if(tb.Name == "TrackBar_G")
            {
                Lb_G.Text = "G:" + TrackBar_G.Value;
            }
            else
            {
                Lb_B.Text = "B:" + TrackBar_B.Value;
            }
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tab3_btn_ok_Click(object sender, EventArgs e)
        {
            Utils.setMaxOpacity(trackBar_maxOpac.Value);
            Utils.setMinOpacity(trackBar_minOpac.Value);
            this.Close();
        }

        /// <summary>
        /// 根据设置状体开启或关闭开机自启动, 并更新配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab4_btn_ok_Click(object sender, EventArgs e)
        {
            bool autoRun = tab4_cbox_openRun.Checked;
            string exePath = Application.ExecutablePath.Replace('/', '\\');
            string appName = exePath.Substring(exePath.LastIndexOf("\\") + 1);
            //第二个参数true表示对该注册表项可读可写
            RegistryKey runKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",true);
            if (runKey == null)
                runKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (autoRun) runKey.SetValue(appName, exePath); //设置为开机自启动
            else runKey.SetValue(appName, false); //取消开机自启动设置
            Utils.setOpenRun(autoRun); //将设置写入配置文件
            this.Close();
        }
    }
}
