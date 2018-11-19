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

namespace CMS1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        static string SiteTitle;

        private void TitleText_SiteProp_TextChanged(object sender, EventArgs e)
        {
            SiteTitle = TitleText_SiteProp.Text;
        }

        private void ApplyButton_SiteProp_Click(object sender, EventArgs e)
        {
            SiteTitle = TitleText_SiteProp.Text;

            if(SiteTitle == TitleText_SiteProp.Text)
            {
                CmsMain.BootStrapTemplateText.Replace("<!--Title-->", "<title>" + SiteTitle + "</title>");
            }
            if (ExportIconToSite)
            {
                CmsMain.BootStrapTemplateText.Replace("<!--Icon-->", "<link rel=\"Icon\" type=\"image/png\" href=\"" + ImportedIconPath + "\">");
            }
        }

        static string IconImgPath;
        static string ImportedIconPath;

        static bool ExportIconToSite = false;

        private void ImportIcon_Click(object sender, EventArgs e)
        {
            DialogResult WebSiteIconDialoge = WebSiteIconFileDialogue.ShowDialog();
            if(WebSiteIconDialoge == DialogResult.OK)
            {
                string NameOfIcon = "";

                IconImgPath = WebSiteIconFileDialogue.FileName;
                ImportedIconPath = IconImgPath;
                Console.Out.WriteLine(ImportedIconPath);
                Image IconImg = Image.FromFile(ImportedIconPath);

                ImportedIconPath = Path.GetFileName(NameOfIcon);
                Console.WriteLine("Icon has bin imported from path and is saved as a string" + "........" + ImportedIconPath);

                //Checking if its 32x32 or 16x16 and not more.

                if (IconImg.Width == 32 && IconImg.Height == 32 || IconImg.Width == 16 && IconImg.Height == 16)
                {
                    Console.Out.WriteLine("This image is alegable.");
                    //<link rel="icon" type="image/png" href="IconPath">
                    //CmsMain.BootStrapTemplateText.Replace("<!--Icon-->", "<link rel=\"Icon\" type=\"image/png\" href=\"" + ImportedIconPath + "\">");
                    ExportIconToSite = true;
                }
                else
                {
                    Console.Out.WriteLine("Can not import image. Error: Icon image size is more than allowed.");
                    MessageBox.Show("You can not have a icon with a size larger than: 32x32 or 16x16.","Error");
                    return;
                }

                IconPicBox.Image = IconImg;

            }
        }
    }
}
