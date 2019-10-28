namespace HalloweenChallenge
{
    partial class FilmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmDetails));
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelTitleDetails = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelDescriptionTitle = new System.Windows.Forms.Label();
            this.labelDescriptionL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetails.Image")));
            this.pictureBoxDetails.Location = new System.Drawing.Point(626, 26);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(131, 240);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetails.TabIndex = 0;
            this.pictureBoxDetails.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(626, 303);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(27, 13);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "112\'";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAge.Location = new System.Drawing.Point(629, 341);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(15, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "G";
            // 
            // labelTitleDetails
            // 
            this.labelTitleDetails.Location = new System.Drawing.Point(137, 40);
            this.labelTitleDetails.Name = "labelTitleDetails";
            this.labelTitleDetails.Size = new System.Drawing.Size(309, 23);
            this.labelTitleDetails.TabIndex = 3;
            this.labelTitleDetails.Text = "Title";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Blue;
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(140, 110);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(53, 13);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Animation";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.BackColor = System.Drawing.Color.Blue;
            this.labelLanguage.ForeColor = System.Drawing.Color.White;
            this.labelLanguage.Location = new System.Drawing.Point(358, 109);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(41, 13);
            this.labelLanguage.TabIndex = 5;
            this.labelLanguage.Text = "English";
            // 
            // labelDescriptionTitle
            // 
            this.labelDescriptionTitle.AutoSize = true;
            this.labelDescriptionTitle.Location = new System.Drawing.Point(140, 223);
            this.labelDescriptionTitle.Name = "labelDescriptionTitle";
            this.labelDescriptionTitle.Size = new System.Drawing.Size(60, 13);
            this.labelDescriptionTitle.TabIndex = 6;
            this.labelDescriptionTitle.Text = "Description";
            // 
            // labelDescriptionL
            // 
            this.labelDescriptionL.Location = new System.Drawing.Point(140, 251);
            this.labelDescriptionL.Name = "labelDescriptionL";
            this.labelDescriptionL.Size = new System.Drawing.Size(408, 65);
            this.labelDescriptionL.TabIndex = 7;
            this.labelDescriptionL.Text = "Description Long";
            // 
            // FilmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDescriptionL);
            this.Controls.Add(this.labelDescriptionTitle);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTitleDetails);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxDetails);
            this.Name = "FilmDetails";
            this.Text = "FilmDetails";
            this.Load += new System.EventHandler(this.FilmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelTitleDetails;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelDescriptionTitle;
        private System.Windows.Forms.Label labelDescriptionL;
    }
}