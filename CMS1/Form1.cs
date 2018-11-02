using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string NewProjectPath;

        private void NewProjectButton_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.Reset();

            DialogResult NewProjectResult = folderBrowserDialog1.ShowDialog();

            if(NewProjectResult == DialogResult.OK)
            {

                NewProjectPath = folderBrowserDialog1.SelectedPath;
                NewProjectPath = NewProjectPath + @"\";

                Console.Out.WriteLine(NewProjectPath);

            }

        }
    }
}
