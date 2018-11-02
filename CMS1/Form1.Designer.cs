namespace CMS1
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackgroundImage = global::CMS1.Properties.Resources.OpenProjectButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.button1.Location = new System.Drawing.Point(474, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 81);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewProjectButton.BackgroundImage = global::CMS1.Properties.Resources.NewProjectButton;
            this.NewProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProjectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.NewProjectButton.Location = new System.Drawing.Point(112, 188);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(209, 81);
            this.NewProjectButton.TabIndex = 0;
            this.NewProjectButton.UseVisualStyleBackColor = true;
            this.NewProjectButton.Click += new System.EventHandler(this.NewProjectButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMS1.Properties.Resources.Logo_text;
            this.pictureBox1.Location = new System.Drawing.Point(313, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 86);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewProjectButton);
            this.Name = "Form1";
            this.Text = "Cms Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewProjectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

