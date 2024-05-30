namespace KarateClub__Project_3_.Instructors
{
    partial class frmShowInstructorInfo
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new Guna.UI.WinForms.GunaGradientButton();
            this.ctrlInstructorCard1 = new KarateClub__Project_3_.Instructors.ctrlInstructorCard();
            this.btnCloseForm = new Guna.UI.WinForms.GunaImageButton();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.btnCloseForm);
            this.gunaShadowPanel1.Controls.Add(this.guna2Separator1);
            this.gunaShadowPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.gunaShadowPanel1.Controls.Add(this.lblTitle);
            this.gunaShadowPanel1.Controls.Add(this.ctrlInstructorCard1);
            this.gunaShadowPanel1.Controls.Add(this.btnClose);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaShadowPanel1.ShadowDepth = 240;
            this.gunaShadowPanel1.ShadowShift = 7;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(914, 637);
            this.gunaShadowPanel1.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(39, 91);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(851, 31);
            this.guna2Separator1.TabIndex = 327;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.instructor1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(39, 10);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(131, 91);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 326;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(167, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 55);
            this.lblTitle.TabIndex = 325;
            this.lblTitle.Text = "Instructor Details";
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
            this.btnClose.Location = new System.Drawing.Point(349, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor1 = System.Drawing.Color.Maroon;
            this.btnClose.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 15;
            this.btnClose.Size = new System.Drawing.Size(183, 42);
            this.btnClose.TabIndex = 230;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlInstructorCard1
            // 
            this.ctrlInstructorCard1.Location = new System.Drawing.Point(9, 166);
            this.ctrlInstructorCard1.Name = "ctrlInstructorCard1";
            this.ctrlInstructorCard1.Size = new System.Drawing.Size(893, 384);
            this.ctrlInstructorCard1.TabIndex = 231;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseForm.Image = global::KarateClub__Project_3_.Properties.Resources.delete;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCloseForm.Location = new System.Drawing.Point(824, 46);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.OnHoverImage = null;
            this.btnCloseForm.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.Size = new System.Drawing.Size(49, 42);
            this.btnCloseForm.TabIndex = 328;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmShowInstructorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 637);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowInstructorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowInstructorInfo";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaGradientButton btnClose;
        private ctrlInstructorCard ctrlInstructorCard1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaImageButton btnCloseForm;
    }
}