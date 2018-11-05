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
using System.Windows;
using System.Windows.Input;
using System.Drawing.Imaging;
using System.Resources;

namespace CMS1
{
    public partial class CmsMain : Form
    {

        public static string TemplateHtmlText = @"
<!DOCTYPE html>

< html >

< head >

</ head >

< body >

</ body >

</ html > 
";

        public CmsMain()
        {
            InitializeComponent();
            this.Text = @"Cms\" + Form1.NewProjectName;
            MainTab.Text = Form1.NewProjectName;
            TabTextEditor.Text = TemplateHtmlText;
        }

        public static string HtmlExportPath;
        public static OpenFileDialog FirstUserChosenPath = new OpenFileDialog();

        public static string ExportHtmlName;

        public static bool canPreview = false;
        public static string MachineName = Environment.MachineName;

        static StreamWriter WriteToTestHtml;

        public static bool CanWriteToHtml = false;

        private void ExportButton_Click(object sender, EventArgs e)
        {

            HTMLExportBrowser.SelectedPath = Form1.NewProjectPath;
            DialogResult HtmlExportResult = HTMLExportBrowser.ShowDialog();

            if(HtmlExportResult == DialogResult.OK)
            {
                CanWriteToHtml = true;

                HtmlExportPath = HTMLExportBrowser.SelectedPath;
                HtmlExportPath = HtmlExportPath + @"\";

                ExportHtmlName = Interaction.InputBox("What do you want your folders name to be?", "Name your folder", Form1.NewProjectName);

                Directory.CreateDirectory(HtmlExportPath + ExportHtmlName);
                Directory.CreateDirectory(HtmlExportPath + ExportHtmlName + @"\" + "Css");

                Console.Out.WriteLine(HtmlExportPath);
                Console.Out.WriteLine(HtmlExportPath + ExportHtmlName + @"\" + "Css");

                if(NewProjectPath.Contains(ExportHtmlName))
                {
                    DialogResult ExportErrorResult = MessageBox.Show("You can not export files again since they alread exist. would you like to replace them?", "Error", MessageBoxButtons.YesNo);
                    
                    if (ExportErrorResult == DialogResult.Yes)
                    {

                        Console.Out.WriteLine("Can write to html is true");

                        File.Delete(HtmlExportPath + ExportHtmlName);
                        Console.Out.WriteLine("Exsisting ExportedFiles have bin deleted and new one's are being printed right now.");
                        FileStream TestHtml = new FileStream(HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html", FileMode.OpenOrCreate, FileAccess.Write);

                        string TestHtmlPath = HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html";

                        FileStream TestCSS = new FileStream(HtmlExportPath + ExportHtmlName + @"\" + "Css" + @"\" + Form1.NewProjectName + ".css", FileMode.OpenOrCreate, FileAccess.Write);
                        Console.Out.WriteLine(TestHtmlPath);

                        //Closign and flushing the files created so the files can be used in another proceses like (preview)**.
                        TestHtml.Flush();
                        TestCSS.Flush();
                        TestHtml.Close();
                        TestCSS.Close();
                        
                        WriteToTestHtml = new StreamWriter(HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html");
                        WriteToTestHtml.WriteLine(TemplateHtmlText);

                        WriteToTestHtml.Flush();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    FileStream TestHtml = new FileStream(HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html", FileMode.OpenOrCreate, FileAccess.Write);
                    string TestHtmlPath = HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html";
                    FileStream TestCSS = new FileStream(HtmlExportPath + ExportHtmlName + @"\" + "Css" + @"\" + Form1.NewProjectName + ".css", FileMode.OpenOrCreate, FileAccess.Write);
                    Console.Out.WriteLine(TestHtmlPath);
                    TestHtml.Close();
                    TestCSS.Close();

                    WriteToTestHtml = new StreamWriter(HtmlExportPath + ExportHtmlName + @"\" + Form1.NewProjectName + ".html");
                    WriteToTestHtml.WriteLine(TemplateHtmlText);

                    WriteToTestHtml.Flush();
                }

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

        public static string ImportImagePath;
        public static int ImgName = 0;
        public static PictureBox Img;
        public static string ImageName;

        public static string TextBoxText;

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0 indicated the first word in the list. so in this case its (new).
            if (FileList.SelectedIndex == 0)
            {
                 DialogResult NewProjectWarning = MessageBox.Show("Are you sure you want to leave this project?", "Warning", MessageBoxButtons.YesNo);
                if(NewProjectWarning == DialogResult.Yes)
                {
                    CmsMain.ActiveForm.Close();
                    Application.Restart();
                    Console.Out.WriteLine("CmsMain has bin shutdown. Opening Form1");
                }
                else
                {
                    return;
                }

            }
            if (FileList.SelectedIndex == 4)
            {
                DialogResult ImportImage = ImportImageBrowser.ShowDialog();

                if(ImportImage == DialogResult.OK)
                {
                    Img = new PictureBox
                    {
                        Name = ImageName
                    };

                    ImportImagePath = ImportImageBrowser.FileName;
                    string ImportedImagePath = ImportImagePath;
                    Console.Out.WriteLine(ImportImagePath);

                    ImportImagePath = Path.GetFileName(ImageName);
                    Console.WriteLine("FileName imported from path and made into string.");

                    Console.Out.WriteLine("Img.Name has bin modified to hold the name of ImageName");

                    Img = new PictureBox
                    {
                        Name = ImageName,
                        Location = new Point(0, 0),
                        BackgroundImage = Image.FromFile(ImportedImagePath),
                        Size = Canvas.Size,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    Canvas.Controls.Add(Img);
                    Img.Show();

                    Console.Out.WriteLine("Image created");
                }
            }

            if (FileList.SelectedIndex == 2)
            {
                if (CanWriteToHtml == true)
                {
                    TextBoxText = TabTextEditor.Text;
                    Console.Out.WriteLine("Saving proces launched");
                    WriteToTestHtml.WriteLine(TabTextEditor.Text);
                    WriteToTestHtml.Flush();
                }else
                {
                    MessageBox.Show("You must export all the files by clicking the Export button on the top right of the editor or you can not save.", "Error");
                    return;
                }
                
            }

        }

        private void MainTab_Click(object sender, EventArgs e)
        {
            Canvas.Show();
            TabTextEditor.Hide();
            Console.Out.WriteLine("Main Tab has bin choosen. Canvas being transfered.");
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            Canvas.Hide();
            TabTextEditor.Show();
            Console.Out.WriteLine("TextEditor in tab has bin launched. hiding canvas until futher comand");
        }

        private void TabTextEditor_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
