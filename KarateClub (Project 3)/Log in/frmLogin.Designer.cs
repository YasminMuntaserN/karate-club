namespace KarateClub__Project_3_.Log_in
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(874, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 33);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.txtUserName.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.txtUserName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUserName.Location = new System.Drawing.Point(512, 254);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.txtUserName.PlaceholderText = "Username";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(342, 55);
            this.txtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUserName.TabIndex = 5;
            this.txtUserName.TextOffset = new System.Drawing.Point(10, 0);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.txtPassword.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.txtPassword.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtPassword.Location = new System.Drawing.Point(512, 343);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(342, 55);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "WELCOME";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(211)))), ((int)(((byte)(159)))));
            this.btnLogin.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(192)))), ((int)(((byte)(145)))));
            this.btnLogin.FillColor = System.Drawing.Color.Brown;
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.HoverState.FillColor2 = System.Drawing.Color.RosyBrown;
            this.btnLogin.Location = new System.Drawing.Point(512, 432);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(342, 52);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkRememberMe.CheckedState.BorderRadius = 0;
            this.chkRememberMe.CheckedState.BorderThickness = 0;
            this.chkRememberMe.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.chkRememberMe.CheckMarkColor = System.Drawing.Color.Maroon;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkRememberMe.Location = new System.Drawing.Point(483, 546);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(165, 32);
            this.chkRememberMe.TabIndex = 11;
            this.chkRememberMe.Text = "Remeber Me ?";
            this.chkRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRememberMe.UncheckedState.BorderRadius = 0;
            this.chkRememberMe.UncheckedState.BorderThickness = 0;
            this.chkRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.judo__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(621, 49);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(126, 111);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLabel2.Location = new System.Drawing.Point(32, 454);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(374, 50);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = " learn how to fight alone";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(13, 395);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(411, 50);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "  If you want to be strong, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(94, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.pictureBox1);
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel2);
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Silver;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.Maroon;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.DimGray;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(-1, -4);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(449, 607);
            this.gunaGradientPanel1.TabIndex = 14;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 603);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberMe;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}