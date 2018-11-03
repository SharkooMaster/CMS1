using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading;

namespace CMS1
{
    public partial class CmsMain : Form
    {
        public CmsMain()
        {
            InitializeComponent();
            this.Text = @"Cms\" + Form1.NewProjectName;
        }

        public static string HtmlExportPath;
        public static OpenFileDialog FirstUserChosenPath = new OpenFileDialog();
        public static string ExportHtmlName;

        public static bool canPreview = false;

        public static string MachineName = Environment.MachineName;

        private void ExportButton_Click(object sender, EventArgs e)
        {

            HTMLExportBrowser.SelectedPath = Form1.NewProjectPath;
            DialogResult HtmlExportResult = HTMLExportBrowser.ShowDialog();

            if(HtmlExportResult == DialogResult.OK)
            {
                HtmlExportPath = HTMLExportBrowser.SelectedPath;
                HtmlExportPath = HtmlExportPath + @"\";

                ExportHtmlName = Interaction.InputBox("What do you want your folders name to be?", "Name your folder", Form1.NewProjectName);

                Directory.CreateDirectory(HtmlExportPath + ExportHtmlName);
                Directory.CreateDirectory(HtmlExportPath + ExportHtmlName + @"\" + "Css");
                Console.Out.WriteLine(HtmlExportPath);
                Console.Out.WriteLine(HtmlExportPath + ExportHtmlName + @"\" + "Css");

                FileStream TestHtml = new FileStream(HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html",FileMode.OpenOrCreate, FileAccess.Write);
                string TestHtmlPath = HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html";
                Console.Out.WriteLine(TestHtmlPath);

                canPreview = true;

            }

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if(FileList.Visible == true)
            {
                FileList.Visible = false;
            }
            else
            {
                FileList.Visible = true;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (EditList.Visible == true)
            {
                EditList.Visible = false;
            }
            else
            {
                EditList.Visible = true;
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (ImageList.Visible == true)
            {
                ImageList.Visible = false;
            }
            else
            {
                ImageList.Visible = true;
            }
        }

        private void LayerButton_Click(object sender, EventArgs e)
        {
            if (LayerList.Visible == true)
            {
                LayerList.Visible = false;
            }
            else
            {
                LayerList.Visible = true;
            }
        }

        private void TypeButton_Click(object sender, EventArgs e)
        {
            if (TypeList.Visible == true)
            {
                TypeList.Visible = false;
            }
            else
            {
                TypeList.Visible = true;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (SelectList.Visible == true)
            {
                SelectList.Visible = false;
            }
            else
            {
                SelectList.Visible = true;
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            if (FilterList.Visible == true)
            {
                FilterList.Visible = false;
            }
            else
            {
                FilterList.Visible = true;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (ViewList.Visible == true)
            {
                ViewList.Visible = false;
            }
            else
            {
                ViewList.Visible = true;
            }
        }

        private void WindowButton_Click(object sender, EventArgs e)
        {
            if (WindowList.Visible == true)
            {
                WindowList.Visible = false;
            }
            else
            {
                WindowList.Visible = true;
            }
        }

        private void HelpButtonMain_Click(object sender, EventArgs e)
        {
            if (HelpList.Visible == true)
            {
                HelpList.Visible = false;
            }
            else
            {
                HelpList.Visible = true;
            }
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            if (canPreview)
            {
                //Grabing preset pathes from when the user exported the html files and launching the site. ((Currently we onyl have a one site system. once we add the multi page system. we will need to check for which page is open before previewing)).
                Process.Start(HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html");
                Console.Out.WriteLine("WebSite (" + ExportHtmlName + ") Has bin lanched on pc: " + MachineName);
            }
            else
            {
                //Adding a error to guide the user into fixing a issue that WE count as a common issue that many will encounter.
                MessageBox.Show("You can not view the site before exporting a HTML. click the export button to the right of the preveiw button and export the files and then try again. thank you.", "Error",MessageBoxButtons.OK);
                Console.Out.WriteLine("User has tried to launch the website before exporting. Error box shown."); ; ;
                return;
            }
            
        }

        public static Form3 TestWebOpen = new Form3();

        private void InCmsTestWebSite_Click(object sender, EventArgs e)
        {
            TestWebOpen.ShowDialog();
        }



    }
}