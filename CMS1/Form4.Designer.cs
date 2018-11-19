namespace CMS1
{
    partial class Form4
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
            this.Title = new System.Windows.Forms.Label();
            this.IconPicBox = new System.Windows.Forms.PictureBox();
            this.WebSiteIconFileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.ImportIcon = new System.Windows.Forms.Button();
            this.ApplyButton_SiteProp = new System.Windows.Forms.Button();
            this.TitleText_SiteProp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(28, 51);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // IconPicBox
            // 
            this.IconPicBox.BackColor = System.Drawing.Color.White;
            this.IconPicBox.Location = new System.Drawing.Point(35, 119);
            this.IconPicBox.Name = "IconPicBox";
            this.IconPicBox.Size = new System.Drawing.Size(150, 150);
            this.IconPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPicBox.TabIndex = 2;
            this.IconPicBox.TabStop = false;
            // 
            // WebSiteIconFileDialogue
            // 
            this.WebSiteIconFileDialogue.FileName = "WebSiteIconFileDialogue";
            // 
            // ImportIcon
            // 
            this.ImportIcon.Location = new System.Drawing.Point(289, 180);
            this.ImportIcon.Name = "ImportIcon";
            this.ImportIcon.Size = new System.Drawing.Size(96, 23);
            this.ImportIcon.TabIndex = 3;
            this.ImportIcon.Text = "Import Icon";
            this.ImportIcon.UseVisualStyleBackColor = true;
            this.ImportIcon.Click += new System.EventHandler(this.ImportIcon_Click);
            // 
            // ApplyButton_SiteProp
            // 
            this.ApplyButton_SiteProp.Location = new System.Drawing.Point(400, 251);
            this.ApplyButton_SiteProp.Name = "ApplyButton_SiteProp";
            this.ApplyButton_SiteProp.Size = new System.Drawing.Size(100, 30);
            this.ApplyButton_SiteProp.TabIndex = 4;
            this.ApplyButton_SiteProp.Text = "Apply";
            this.ApplyButton_SiteProp.UseVisualStyleBackColor = true;
            this.ApplyButton_SiteProp.Click += new System.EventHandler(this.ApplyButton_SiteProp_Click);
            // 
            // TitleText_SiteProp
            // 
            this.TitleText_SiteProp.Location = new System.Drawing.Point(30, 67);
            this.TitleText_SiteProp.Name = "TitleText_SiteProp";
            this.TitleText_SiteProp.Size = new System.Drawing.Size(470, 20);
            this.TitleText_SiteProp.TabIndex = 5;
            this.TitleText_SiteProp.TextChanged += new System.EventHandler(this.TitleText_SiteProp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Warning: Icon can only be 16x16 or 32x32";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(534, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleText_SiteProp);
            this.Controls.Add(this.ApplyButton_SiteProp);
            this.Controls.Add(this.ImportIcon);
            this.Controls.Add(this.IconPicBox);
            this.Controls.Add(this.Title);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebSiteProperties";
            ((System.ComponentModel.ISupportInitialize)(this.IconPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox IconPicBox;
        private System.Windows.Forms.OpenFileDialog WebSiteIconFileDialogue;
        private System.Windows.Forms.Button ImportIcon;
        private System.Windows.Forms.Button ApplyButton_SiteProp;
        private System.Windows.Forms.TextBox TitleText_SiteProp;
        private System.Windows.Forms.Label label1;
    }
}