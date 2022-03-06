using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace StoreMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isAlreadyRunning = hasInstances();

            if (isAlreadyRunning)
            {
                MessageBoxer.showErrorMsg("StoreMan is already running!");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }
        private static bool hasInstances()
        {
            string procName = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(procName);

            if (processes.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
