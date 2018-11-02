using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace CMS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string NewProjectPath;

        //Adding strings for naming the project.

        public static string DefaultName = "MyNewProject";
        static int DefaultNameNumber = 0;
        static string FileFormat = ".lol";

        public static string NewProjectName;

        public static bool MainWindow = false;

        private void NewProjectButton_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.Reset();

            DialogResult NewProjectResult = folderBrowserDialog1.ShowDialog();

            if(NewProjectResult == DialogResult.OK)
            {
                DefaultName = DefaultName + DefaultNameNumber;

                NewProjectPath = folderBrowserDialog1.SelectedPath;
                NewProjectPath = NewProjectPath + @"\";

                if (NewProjectPath.Contains(DefaultName + DefaultNameNumber + FileFormat))
                {
                    int NewNumber = DefaultNameNumber + 1;
                    DefaultName += NewNumber;
                    Console.Out.WriteLine(DefaultName);
                }

                NewProjectName = Interaction.InputBox("What do you want the file name to be?", "Name you'r project", DefaultName);

                if(NewProjectName.Length > 0)
                {
                    Console.Out.WriteLine("File Created. Transfering to MainWindow");
                    FileStream NewProject = new FileStream(NewProjectPath + NewProjectName + ".lol", FileMode.OpenOrCreate, FileAccess.Write);
                    NewProject.Close();

                    this.Close();
                    MainWindow = true;
                }
                else
                {
                    Console.Out.WriteLine("User Clicked Cancle. Redirecting.");
                    return;
                }

            }

        }
    }
}
