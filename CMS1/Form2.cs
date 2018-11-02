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

        private void ExportButton_Click(object sender, EventArgs e)
        {

            HTMLExportBrowser.SelectedPath = Form1.NewProjectPath;
            DialogResult HtmlExportResult = HTMLExportBrowser.ShowDialog();

            if(HtmlExportResult == DialogResult.OK)
            {
                HtmlExportPath = HTMLExportBrowser.SelectedPath;
                HtmlExportPath = HtmlExportPath + @"\";

                string ExportHtmlName = Interaction.InputBox("What do you want your folders name to be?", "Name your folder", Form1.NewProjectName);

                Directory.CreateDirectory(HtmlExportPath + ExportHtmlName);
                Console.Out.WriteLine(HtmlExportPath);

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
    }
}
