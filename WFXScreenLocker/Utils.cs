using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LockScreen
{
    class Utils
    {
        public static string iniFilePath = Application.StartupPath + @"\ScreenLocker.ini";
        
        public static void checkIniFile()
        {
            if (!File.Exists(iniFilePath))
            {
                //设置配置文件的初始值
                string[] lines = { "[config]",
                               "password=" +Win32API.MD5_Str("author_wfx"),
                               "color=#9157C5",
                               "maxOpacity=90",
                               "minOpacity=30"
                };
                File.AppendAllLines(iniFilePath, lines);
                MessageBox.Show("您是第一次运行该程序!\n初始解锁秘密为 : author_wfx \n请牢记!");
            }
        }

        public static Color getLookScreenColor()
        {
            //读取锁屏窗体的颜色
            StringBuilder sb = new StringBuilder();
            Win32API.GetPrivateProfileString("config", "color", "#00ff00", sb, 255, iniFilePath);
            return ColorTranslator.FromHtml(sb.ToString());
        }

        public static void setLockScreenColor(string color)
        {
            Win32API.WritePrivateProfileString("config", "color", color, iniFilePath);
        }

        public static string getPassword()
        {
            StringBuilder sb = new StringBuilder();
            Win32API.GetPrivateProfileString("config", "password", "", sb, 255, iniFilePath);
            return sb.ToString();
        }
        public static void setPassword(string pwd)
        {
            string newPwd = Win32API.MD5_Str(pwd);
            Win32API.WritePrivateProfileString("config", "password", newPwd, iniFilePath);
        }

        public static int getMaxOpacity()
        {
            StringBuilder sb = new StringBuilder();
            Win32API.GetPrivateProfileString("config", "maxOpacity", "", sb, 255, iniFilePath);
            return int.Parse(sb.ToString());
        }
        public static void setMaxOpacity(int maxOpacity)
        {
            Win32API.WritePrivateProfileString("config", "maxOpacity", maxOpacity.ToString(), iniFilePath);
        }

        public static int getMinOpacity()
        {
            StringBuilder sb = new StringBuilder();
            Win32API.GetPrivateProfileString("config", "minOpacity", "", sb, 255, iniFilePath);
            return int.Parse(sb.ToString());
        }
        public static void setMinOpacity(int minOpacity)
        {
            Win32API.WritePrivateProfileString("config", "minOpacity", minOpacity.ToString(), iniFilePath);
        }
    }
}
