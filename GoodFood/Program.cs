using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GoodFood.Classes;
using GoodFood.Classes.Repositories;
using System.Diagnostics;
using GoodFood.Forms;

namespace GoodFood
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseUtils.loadMenu();
            
            Application.Run(new Start());
        }
    }
}
