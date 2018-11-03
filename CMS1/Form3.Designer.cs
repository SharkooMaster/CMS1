namespace CMS1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InCmsWebPreview = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // InCmsWebPreview
            // 
            this.InCmsWebPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InCmsWebPreview.Location = new System.Drawing.Point(0, 0);
            this.InCmsWebPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.InCmsWebPreview.Name = "InCmsWebPreview";
            this.InCmsWebPreview.Size = new System.Drawing.Size(1904, 1041);
            this.InCmsWebPreview.TabIndex = 0;
            this.InCmsWebPreview.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.InCmsWebPreview_DocumentCompleted);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.InCmsWebPreview);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CmsTestPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser InCmsWebPreview;
    }
}