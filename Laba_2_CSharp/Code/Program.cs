using System;
using System.Windows.Forms;

namespace Laba_2_CSharp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// Final Version
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainWindow());
        }
    }
}
