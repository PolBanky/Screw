using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Screw
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
            Application.Run(new aForm1());
        }   // end of - static void Main()
    }       // end of - static class Program
}           // end of - namespace Screw
