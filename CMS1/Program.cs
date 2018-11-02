using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Windows;


namespace CMS1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Console.Out.WriteLine("Application has started.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.Out.WriteLine(Form1.NewProjectPath);

        }

        public static void console() //Console Commands
        {
            Console.OpenStandardInput();
            Console.OpenStandardOutput();
            string commands = Convert.ToString(Console.ReadLine());
            switch (commands)
            {
                case "exit":
                    Application.Exit();
                    break;
                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
        }

    }
}
