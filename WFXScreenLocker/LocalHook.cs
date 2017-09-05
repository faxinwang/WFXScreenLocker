using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockScreen
{
    class LocalHook:Hook
    {
        public LocalHook(HOOKPROC proc)
            : base(proc, HookType.WH_KEYBOARD)
        { }

        public override int SetWindowsHookEx()
        {
            if (hHook == 0)
                hHook = SetWindowsHookEx(this.type, this.proc, IntPtr.Zero, GetCurrentThreadId());
            return hHook;
        }
    }
}
