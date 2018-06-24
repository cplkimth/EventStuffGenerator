using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventStuffGenerator.AsExternalTool
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

            OnRunTime = true;

            var arg = args.Length == 0 ? "void AgeChagned(int oldAge, int newAge);" : args[0];
            Application.Run(new MainForm(arg));
        }

        public static bool OnRunTime { get; private set; }
    }
}
