using System;
using System.Windows.Forms;
using FacebookDesktopInterface.UI;

namespace FacebookDesktopInterface
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLoginScreen());
        }
    }
}
