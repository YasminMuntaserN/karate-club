namespace KarateClub__Project_3_.Users
{
    partial class frmChangePassword
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ctrlUserCard1 = new KarateClub__Project_3_.Users.ctrlUserCard();
            this.btnSave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnClose = new Guna.UI.WinForms.GunaGradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnCloseForm = new Guna.UI.WinForms.GunaImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-4, 567);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtConfirmPassword);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.txtNewPassword);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox6);
            this.splitContainer1.Size = new System.Drawing.Size(893, 149);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 292;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BaseColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.Maroon;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConfirmPassword.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(326, 57);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.Radius = 10;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(178, 34);
            this.txtConfirmPassword.TabIndex = 292;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.lbl_TextChanged);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConformPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 290;
            this.label2.Text = "Confirm Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(255, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 291;
            this.pictureBox1.TabStop = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BaseColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderColor = System.Drawing.Color.Maroon;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNewPassword.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtNewPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.Location = new System.Drawing.Point(326, 13);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.Radius = 10;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(178, 34);
            this.txtNewPassword.TabIndex = 289;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(49, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 27);
            this.label4.TabIndex = 287;
            this.label4.Text = "New Password :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::KarateClub__Project_3_.Properties.Resources.permission;
            this.pictureBox6.Location = new System.Drawing.Point(255, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(43, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 288;
            this.pictureBox6.TabStop = false;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(1, 112);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(888, 449);
            this.ctrlUserCard1.TabIndex = 290;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor1 = System.Drawing.Color.Maroon;
            this.btnSave.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::KarateClub__Project_3_.Properties.Resources.bookmark;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(435, 736);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.Maroon;
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(183, 42);
            this.btnSave.TabIndex = 294;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor1 = System.Drawing.Color.Maroon;
            this.btnClose.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::KarateClub__Project_3_.Properties.Resources.close__2_;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(223, 736);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor1 = System.Drawing.Color.Maroon;
            this.btnClose.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 15;
            this.btnClose.Size = new System.Drawing.Size(183, 42);
            this.btnClose.TabIndex = 293;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 5;
            this.guna2Separator1.Location = new System.Drawing.Point(9, 74);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(880, 10);
            this.guna2Separator1.TabIndex = 311;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseForm.Image = global::KarateClub__Project_3_.Properties.Resources.delete;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCloseForm.Location = new System.Drawing.Point(812, 26);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.OnHoverImage = null;
            this.btnCloseForm.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.Size = new System.Drawing.Size(49, 42);
            this.btnCloseForm.TabIndex = 310;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.login;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(52, 13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(119, 67);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 309;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(163, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 45);
            this.lblTitle.TabIndex = 308;
            this.lblTitle.Text = "Change Password";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 790);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ctrlUserCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton btnSave;
        private Guna.UI.WinForms.GunaGradientButton btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ctrlUserCard ctrlUserCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI.WinForms.GunaImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
    }
}