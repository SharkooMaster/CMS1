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

            if(Form1.MainWindow == true)
            {
                Console.Out.WriteLine("Main window has bin launched. First Window has bin closed.");
                Console.Out.WriteLine("File has bin saved to: " + Form1.NewProjectPath);
                Application.Run(new CmsMain());
            }

        }

        public static void ConsoleOutput()
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
