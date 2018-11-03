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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.InCmsWebPreview.Navigate(CmsMain.HtmlExportPath + CmsMain.ExportHtmlName + @"\" + Form1.NewProjectName + ".html");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void InCmsWebPreview_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html"
            //this.InCmsWebPreview.Navigate(CmsMain.HtmlExportPath + CmsMain.ExportHtmlName + @"\" + Form1.NewProjectName + ".html");
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            InCmsWebPreview.Refresh();
        }
    }
}
