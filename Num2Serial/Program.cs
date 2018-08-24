﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warranty
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Count() == 0)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new MainForm(args[0]));
            }
        }
    }
}
