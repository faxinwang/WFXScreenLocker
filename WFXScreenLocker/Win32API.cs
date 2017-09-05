using System;
using System.Text;

using System.Runtime.InteropServices;
using System.Drawing;
using System.Security.Cryptography;


namespace LockScreen
{
    class Win32API
    {
        //代理
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);

        //设置钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc proc, IntPtr instance, int threadID);

        //卸载钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnHookWindowsHookEx(int idHook);

        //调用下一个钩子
        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        /// <summary>
        /// 将光标限制在矩形区域内
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern long ClipCursor(out Rectangle rect);

        /// <summary>
        /// 读取INI文件的API函数 GetPrivateProfileString
        /// </summary>
        /// <param name="section">欲在其中查找条目的小节名称</param>
        /// <param name="key">欲获取的项目或条目名</param>
        /// <param name="def">指定的条目没有找到是返回的默认值，可设为空""</param>
        /// <param name="retVal">指定字符串缓冲区,长度至少为size</param>
        /// <param name="size">缓冲区大小</param>
        /// <param name="filepath">INI文件的完整路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def,
            StringBuilder retVal, int size, string filepath);

        /// <summary>
        /// 写INI文件的API函数 WritePrivateProfileString
        /// 向INI文件中写入信息
        /// </summary>
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        public static extern int GetCurrentThreadID();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto,CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// MD5加密函数
        /// </summary>
        /// <param name="pwd">待加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string MD5_Str(string pwd)
        {
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            string password = "";
            for(int i = 0; i < s.Length; ++i)
            {
                password += s[i].ToString();
            }
            return password;
        }


    }
}
