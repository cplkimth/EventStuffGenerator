﻿#region
using System;
using System.Windows.Forms;
using EventStuffGenerator.Win;
using EventStuffGenerator.Win.Forms;
#endregion

namespace EventStuffGenerator
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}