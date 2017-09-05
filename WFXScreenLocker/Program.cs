using System;
using System.Windows.Forms;

namespace LockScreen
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //这样写, 当启动窗体关闭后,则整个程序将退出,
            //Application.Run(new LockScreen()); 
            //这样写,所有窗体都关闭后程序依然不会退出, 需要手动调用Application.exit()
            new ScreenLocker().Show(); 
            Application.Run();
        }
    }
}
