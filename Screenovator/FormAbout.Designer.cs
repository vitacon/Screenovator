
namespace Screenovator
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.label_url = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(62, 12);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(260, 262);
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(108, 277);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(168, 25);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Screenovator";
            // 
            // label_version
            // 
            this.label_version.Location = new System.Drawing.Point(89, 325);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(207, 17);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "version 0.0";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Location = new System.Drawing.Point(148, 355);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(88, 13);
            this.label_copyright.TabIndex = 3;
            this.label_copyright.Text = "Vít Čondák 2021";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(118, 305);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(148, 13);
            this.label_text.TabIndex = 4;
            this.label_text.Text = "Simple free screenwriting app.";
            this.label_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(146, 375);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(92, 13);
            this.label_url.TabIndex = 5;
            this.label_url.Text = "eriador.condak.cz";
            this.label_url.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 450);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "FormAbout";
            this.Text = "About Screenovator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label_title;
        public System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label label_url;
    }
}