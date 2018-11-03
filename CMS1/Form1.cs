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

        /* Setting up a bool that can be accesed all around the software so we can use the Name the user set for the project for other features as in
         * exporting. Just to make stuff easier for the user.*/
        public static string NewProjectName;

        //Seeting up a bool that will be set as soon as the user finished choosing file path so that (program.cs) can launch the main editor.
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

                //Checking to see if the path user has provided contains the exact same FILE or NAME that has bin used before.
                if (NewProjectPath.Contains(DefaultName + DefaultNameNumber + FileFormat))
                {
                    int NewNumber = DefaultNameNumber + 1;
                    DefaultName += NewNumber;
                    Console.Out.WriteLine(DefaultName);
                }

                NewProjectName = Interaction.InputBox("What do you want the file name to be?", "Name your project", DefaultName);

                if(NewProjectName.Length > 0)
                {
                    Console.Out.WriteLine("File Created. Transfering to MainWindow");
                    FileStream NewProject = new FileStream(NewProjectPath + NewProjectName + ".lol", FileMode.OpenOrCreate, FileAccess.Write);
                    NewProject.Close();
                    this.Close();
                    //Launching the main editor by sending a request to (program.cs)****.
                    MainWindow = true;
                }
                else
                {
                    Console.Out.WriteLine("User Clicked Cancel. Redirecting.");
                    return;
                }
            }

        }
    }
}
