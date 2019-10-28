namespace HalloweenChallenge
{
    partial class MainSakila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSakila));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBoxMWW = new System.Windows.Forms.CheckBox();
            this.labelFounds = new System.Windows.Forms.Label();
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.pictureBoxNoLogin = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitulo.Location = new System.Drawing.Point(-1, -1);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(801, 63);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "SAKILA FILMS";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMain.Controls.Add(this.tabPageLogin);
            this.tabControlMain.Controls.Add(this.tabPageFilms);
            this.tabControlMain.Controls.Add(this.tabPageStaff);
            this.tabControlMain.Location = new System.Drawing.Point(7, 65);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(781, 373);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.buttonLogOut);
            this.tabPageLogin.Controls.Add(this.buttonLogIn);
            this.tabPageLogin.Controls.Add(this.textBoxPassword);
            this.tabPageLogin.Controls.Add(this.textBoxUser);
            this.tabPageLogin.Controls.Add(this.labelPassword);
            this.tabPageLogin.Controls.Add(this.labelUser);
            this.tabPageLogin.Location = new System.Drawing.Point(23, 4);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(754, 365);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.Controls.Add(this.listBoxFilms);
            this.tabPageFilms.Controls.Add(this.labelFounds);
            this.tabPageFilms.Controls.Add(this.checkBoxMWW);
            this.tabPageFilms.Controls.Add(this.buttonFind);
            this.tabPageFilms.Controls.Add(this.textBoxSearch);
            this.tabPageFilms.Controls.Add(this.labelSearch);
            this.tabPageFilms.Location = new System.Drawing.Point(23, 4);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilms.Size = new System.Drawing.Size(754, 365);
            this.tabPageFilms.TabIndex = 1;
            this.tabPageFilms.Text = "Films";
            this.tabPageFilms.UseVisualStyleBackColor = true;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.Controls.Add(this.pictureBoxNoLogin);
            this.tabPageStaff.Controls.Add(this.buttonUpdate);
            this.tabPageStaff.Controls.Add(this.textBoxEmail);
            this.tabPageStaff.Controls.Add(this.labelEmail);
            this.tabPageStaff.Location = new System.Drawing.Point(23, 4);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Size = new System.Drawing.Size(754, 365);
            this.tabPageStaff.TabIndex = 2;
            this.tabPageStaff.Text = "Staff";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(329, 192);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(169, 34);
            this.buttonLogIn.TabIndex = 9;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(329, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(169, 20);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(329, 70);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(169, 20);
            this.textBoxUser.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(198, 140);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(198, 70);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "User";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(188, 43);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(238, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(307, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(552, 40);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 20);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxMWW
            // 
            this.checkBoxMWW.AutoSize = true;
            this.checkBoxMWW.Location = new System.Drawing.Point(552, 78);
            this.checkBoxMWW.Name = "checkBoxMWW";
            this.checkBoxMWW.Size = new System.Drawing.Size(115, 17);
            this.checkBoxMWW.TabIndex = 3;
            this.checkBoxMWW.Text = "Match whole world";
            this.checkBoxMWW.UseVisualStyleBackColor = true;
            // 
            // labelFounds
            // 
            this.labelFounds.AutoSize = true;
            this.labelFounds.Location = new System.Drawing.Point(191, 78);
            this.labelFounds.Name = "labelFounds";
            this.labelFounds.Size = new System.Drawing.Size(81, 13);
            this.labelFounds.TabIndex = 4;
            this.labelFounds.Text = "0 records found";
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.Location = new System.Drawing.Point(191, 113);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(476, 238);
            this.listBoxFilms.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(161, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(199, 93);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(288, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(412, 134);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // pictureBoxNoLogin
            // 
            this.pictureBoxNoLogin.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBoxNoLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNoLogin.Image")));
            this.pictureBoxNoLogin.InitialImage = null;
            this.pictureBoxNoLogin.Location = new System.Drawing.Point(149, 35);
            this.pictureBoxNoLogin.Name = "pictureBoxNoLogin";
            this.pictureBoxNoLogin.Size = new System.Drawing.Size(414, 307);
            this.pictureBoxNoLogin.TabIndex = 3;
            this.pictureBoxNoLogin.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(329, 192);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(169, 34);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Visible = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // MainSakila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelTitulo);
            this.Name = "MainSakila";
            this.Text = "Sakila";
            this.Load += new System.EventHandler(this.MainSakila_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageFilms.ResumeLayout(false);
            this.tabPageFilms.PerformLayout();
            this.tabPageStaff.ResumeLayout(false);
            this.tabPageStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageFilms;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ListBox listBoxFilms;
        private System.Windows.Forms.Label labelFounds;
        private System.Windows.Forms.CheckBox checkBoxMWW;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.PictureBox pictureBoxNoLogin;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonLogOut;
    }
}

