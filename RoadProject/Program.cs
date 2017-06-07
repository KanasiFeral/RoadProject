using System;
using System.Windows.Forms;

namespace RoadProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MSSQLConnector conSQL = new MSSQLConnector();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScrean(conSQL));
        }
    }
}