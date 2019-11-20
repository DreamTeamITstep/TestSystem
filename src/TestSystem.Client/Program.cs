using System;
using System.Windows.Forms;

namespace TestClient
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogIn logIn = new LogIn();
            Application.Run(logIn);
            if (logIn.isAuthentificated == true)
            {
                Application.Run(new Tests(logIn.Token));
            }
        }
    }
}
