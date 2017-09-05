using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LockScreen
{
    class GlobalHook:Hook
    {
        public GlobalHook(HOOKPROC proc)
            : base(proc, HookType.WH_KEYBOARD_LL)
        { }

        public override int SetWindowsHookEx()
        {
            /*
            if (hHook == 0)
                hHook = SetWindowsHookEx(this.type, this.proc,
                    Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
            return hHook;
        */
            Process curProcess = Process.GetCurrentProcess();
            ProcessModule curModule = curProcess.MainModule;
            hHook = SetWindowsHookEx(this.type, proc, GetModuleHandle(curModule.ModuleName), 0);
            return hHook;
        }
    }

}
