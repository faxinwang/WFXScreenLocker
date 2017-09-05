using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LockScreen
{
    public abstract class Hook
    {

        public delegate int HOOKPROC(int nCode, int wParam, IntPtr lParam);
        public enum HookType
        {
            WH_KEYBOARD = 2,//私有钩子
            WH_KEYBOARD_LL = 13//全局钩子
        }

        //安装钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(HookType idHook, HOOKPROC lpfn, IntPtr hInstance, int threadId);
        //卸载钩子
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("kernel32")]
        public static extern int GetCurrentThreadId();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);


        /// <summary>
        /// 钩子处理委托
        /// </summary>
        public HOOKPROC proc;
        /// <summary>
        /// 钩子类型
        /// </summary>
        public HookType type;
        /// <summary>
        /// 钩子的句柄
        /// </summary>
        public int hHook = 0;

        public Hook(HOOKPROC proc, HookType type)
        {
            this.proc = proc;
            this.type = type;
        }

        public abstract int SetWindowsHookEx();
        public virtual void UnhookWindowsHookEx()
        {
            bool retKeyboard = true;
            if (hHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hHook);
                hHook = 0;
            }
            if (!retKeyboard)
            {
                throw new Exception("UnhookWindowsHookEx failed.");
            }
        }
    }
}
