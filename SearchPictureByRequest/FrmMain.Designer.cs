namespace SearchPictureByRequest
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.labelCopyTo = new System.Windows.Forms.Label();
            this.textBoxCopyTo = new System.Windows.Forms.TextBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.textBoxTrackId = new System.Windows.Forms.TextBox();
            this.labelTrackId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Developed by A. Patricio";
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(283, 169);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(32, 23);
            this.buttonOpenFolder.TabIndex = 14;
            this.buttonOpenFolder.Text = "...";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // labelCopyTo
            // 
            this.labelCopyTo.AutoSize = true;
            this.labelCopyTo.Location = new System.Drawing.Point(16, 178);
            this.labelCopyTo.Name = "labelCopyTo";
            this.labelCopyTo.Size = new System.Drawing.Size(50, 13);
            this.labelCopyTo.TabIndex = 13;
            this.labelCopyTo.Text = "Copy To:";
            // 
            // textBoxCopyTo
            // 
            this.textBoxCopyTo.Location = new System.Drawing.Point(77, 171);
            this.textBoxCopyTo.Name = "textBoxCopyTo";
            this.textBoxCopyTo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCopyTo.TabIndex = 12;
            this.textBoxCopyTo.Text = "A:\\";
            // 
            // buttonRequest
            // 
            this.buttonRequest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRequest.Location = new System.Drawing.Point(77, 207);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(200, 40);
            this.buttonRequest.TabIndex = 11;
            this.buttonRequest.Text = "Send Picture Request";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // textBoxTrackId
            // 
            this.textBoxTrackId.Location = new System.Drawing.Point(77, 130);
            this.textBoxTrackId.Name = "textBoxTrackId";
            this.textBoxTrackId.Size = new System.Drawing.Size(200, 20);
            this.textBoxTrackId.TabIndex = 10;
            // 
            // labelTrackId
            // 
            this.labelTrackId.AutoSize = true;
            this.labelTrackId.Location = new System.Drawing.Point(16, 137);
            this.labelTrackId.Name = "labelTrackId";
            this.labelTrackId.Size = new System.Drawing.Size(49, 13);
            this.labelTrackId.TabIndex = 9;
            this.labelTrackId.Text = "TrackID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SearchPictureByRequest.Properties.Resources.FLEX_logo;
            this.pictureBox1.Location = new System.Drawing.Point(77, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.labelCopyTo);
            this.Controls.Add(this.textBoxCopyTo);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.textBoxTrackId);
            this.Controls.Add(this.labelTrackId);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchPictureByRequest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label labelCopyTo;
        private System.Windows.Forms.TextBox textBoxCopyTo;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.TextBox textBoxTrackId;
        private System.Windows.Forms.Label labelTrackId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

