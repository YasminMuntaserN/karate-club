namespace KarateClub__Project_3_.Subscription_Period
{
    partial class frmAddEditSubscriptionPeriod
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
            this.tcMember = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlMemberCardWithFilter1 = new KarateClub__Project_3_.Member.User_Control.ctrlMemberCardWithFilter();
            this.btnNext = new Guna.UI.WinForms.GunaGradientButton();
            this.tpSubscriptionPeriodInfo = new System.Windows.Forms.TabPage();
            this.txtFees = new Guna.UI.WinForms.GunaTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtpEndDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpStartDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsPaid = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblPaymentID = new Guna.UI.WinForms.GunaLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblMemberID = new Guna.UI.WinForms.GunaLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblPeriodID = new Guna.UI.WinForms.GunaLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSave = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnCloseForm = new Guna.UI.WinForms.GunaImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcMember.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpSubscriptionPeriodInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMember
            // 
            this.tcMember.Controls.Add(this.tpPersonalInfo);
            this.tcMember.Controls.Add(this.tpSubscriptionPeriodInfo);
            this.tcMember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMember.Location = new System.Drawing.Point(27, 114);
            this.tcMember.Multiline = true;
            this.tcMember.Name = "tcMember";
            this.tcMember.SelectedIndex = 0;
            this.tcMember.Size = new System.Drawing.Size(890, 638);
            this.tcMember.TabIndex = 4;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.ctrlMemberCardWithFilter1);
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 37);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(882, 597);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlMemberCardWithFilter1
            // 
            this.ctrlMemberCardWithFilter1.FilterEnabled = true;
            this.ctrlMemberCardWithFilter1.Location = new System.Drawing.Point(0, 6);
            this.ctrlMemberCardWithFilter1.Name = "ctrlMemberCardWithFilter1";
            this.ctrlMemberCardWithFilter1.Size = new System.Drawing.Size(876, 542);
            this.ctrlMemberCardWithFilter1.TabIndex = 233;
            this.ctrlMemberCardWithFilter1.OnMemberSelectedEvent += new System.EventHandler<KarateClub__Project_3_.Member.User_Control.ctrlMemberCardWithFilter.SelectMemberEventArgs>(this.ctrlMemberCardWithFilter1_OnMemberSelectedEvent);
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnNext.BaseColor2 = System.Drawing.Color.Maroon;
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::KarateClub__Project_3_.Properties.Resources.logout__1_1;
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(667, 549);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor1 = System.Drawing.Color.Maroon;
            this.btnNext.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 15;
            this.btnNext.Size = new System.Drawing.Size(183, 42);
            this.btnNext.TabIndex = 232;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpSubscriptionPeriodInfo
            // 
            this.tpSubscriptionPeriodInfo.Controls.Add(this.txtFees);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox8);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox7);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox3);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.dtpEndDate);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.dtpStartDate);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.label5);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.label4);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.label1);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.cbIsPaid);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.gunaLabel4);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.lblPaymentID);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.label3);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.gunaLabel2);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.lblMemberID);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.label2);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.gunaLabel1);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.lblPeriodID);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.label7);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox4);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox6);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox5);
            this.tpSubscriptionPeriodInfo.Controls.Add(this.pictureBox2);
            this.tpSubscriptionPeriodInfo.Location = new System.Drawing.Point(4, 37);
            this.tpSubscriptionPeriodInfo.Name = "tpSubscriptionPeriodInfo";
            this.tpSubscriptionPeriodInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubscriptionPeriodInfo.Size = new System.Drawing.Size(882, 597);
            this.tpSubscriptionPeriodInfo.TabIndex = 1;
            this.tpSubscriptionPeriodInfo.Text = "SubscriptionPeriod Info";
            this.tpSubscriptionPeriodInfo.UseVisualStyleBackColor = true;
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.Transparent;
            this.txtFees.BaseColor = System.Drawing.Color.White;
            this.txtFees.BorderColor = System.Drawing.Color.Maroon;
            this.txtFees.BorderSize = 3;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFees.FocusedBorderColor = System.Drawing.Color.Gray;
            this.txtFees.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFees.Location = new System.Drawing.Point(639, 177);
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.Radius = 10;
            this.txtFees.SelectedText = "";
            this.txtFees.Size = new System.Drawing.Size(180, 34);
            this.txtFees.TabIndex = 260;
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::KarateClub__Project_3_.Properties.Resources.appointment;
            this.pictureBox8.Location = new System.Drawing.Point(588, 37);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 259;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::KarateClub__Project_3_.Properties.Resources.appointment;
            this.pictureBox7.Location = new System.Drawing.Point(588, 113);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 258;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KarateClub__Project_3_.Properties.Resources.money__1_;
            this.pictureBox3.Location = new System.Drawing.Point(594, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 257;
            this.pictureBox3.TabStop = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpEndDate.BaseColor = System.Drawing.Color.DarkGray;
            this.dtpEndDate.BorderColor = System.Drawing.Color.Maroon;
            this.dtpEndDate.BorderSize = 3;
            this.dtpEndDate.CustomFormat = null;
            this.dtpEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEndDate.FocusedColor = System.Drawing.Color.Maroon;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpEndDate.Location = new System.Drawing.Point(633, 101);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpEndDate.OnHoverBorderColor = System.Drawing.Color.Maroon;
            this.dtpEndDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpEndDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpEndDate.Radius = 10;
            this.dtpEndDate.Size = new System.Drawing.Size(186, 38);
            this.dtpEndDate.TabIndex = 255;
            this.dtpEndDate.Text = "17 May 2024";
            this.dtpEndDate.Value = new System.DateTime(2024, 5, 17, 9, 26, 58, 198);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpStartDate.BaseColor = System.Drawing.Color.DarkGray;
            this.dtpStartDate.BorderColor = System.Drawing.Color.Maroon;
            this.dtpStartDate.BorderSize = 3;
            this.dtpStartDate.CustomFormat = null;
            this.dtpStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpStartDate.FocusedColor = System.Drawing.Color.Maroon;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Location = new System.Drawing.Point(633, 35);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpStartDate.OnHoverBorderColor = System.Drawing.Color.Maroon;
            this.dtpStartDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpStartDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpStartDate.Radius = 10;
            this.dtpStartDate.Size = new System.Drawing.Size(186, 38);
            this.dtpStartDate.TabIndex = 254;
            this.dtpStartDate.Text = "17 May 2024";
            this.dtpStartDate.Value = new System.DateTime(2024, 5, 17, 9, 26, 58, 198);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(501, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 30);
            this.label5.TabIndex = 253;
            this.label5.Text = "Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(450, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 252;
            this.label4.Text = "End Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(450, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 251;
            this.label1.Text = "Start Date :";
            // 
            // cbIsPaid
            // 
            this.cbIsPaid.BaseColor = System.Drawing.Color.White;
            this.cbIsPaid.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbIsPaid.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIsPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbIsPaid.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsPaid.Location = new System.Drawing.Point(134, 241);
            this.cbIsPaid.Name = "cbIsPaid";
            this.cbIsPaid.Size = new System.Drawing.Size(117, 31);
            this.cbIsPaid.TabIndex = 249;
            this.cbIsPaid.Text = "Is Paid";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel4.Location = new System.Drawing.Point(293, 181);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel4.TabIndex = 248;
            this.gunaLabel4.Text = "N/A";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaymentID.Location = new System.Drawing.Point(236, 181);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(51, 28);
            this.lblPaymentID.TabIndex = 247;
            this.lblPaymentID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(30, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 245;
            this.label3.Text = "Payment ID :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel2.Location = new System.Drawing.Point(293, 111);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel2.TabIndex = 244;
            this.gunaLabel2.Text = "N/A";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemberID.Location = new System.Drawing.Point(236, 111);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(51, 28);
            this.lblMemberID.TabIndex = 243;
            this.lblMemberID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 30);
            this.label2.TabIndex = 241;
            this.label2.Text = "Member ID :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Brown;
            this.gunaLabel1.Location = new System.Drawing.Point(293, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(51, 28);
            this.gunaLabel1.TabIndex = 234;
            this.gunaLabel1.Text = "N/A";
            // 
            // lblPeriodID
            // 
            this.lblPeriodID.AutoSize = true;
            this.lblPeriodID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPeriodID.Location = new System.Drawing.Point(236, 35);
            this.lblPeriodID.Name = "lblPeriodID";
            this.lblPeriodID.Size = new System.Drawing.Size(51, 28);
            this.lblPeriodID.TabIndex = 233;
            this.lblPeriodID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.Location = new System.Drawing.Point(30, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 227;
            this.label7.Text = "Period ID :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::KarateClub__Project_3_.Properties.Resources.money;
            this.pictureBox4.Location = new System.Drawing.Point(69, 241);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 250;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::KarateClub__Project_3_.Properties.Resources.id;
            this.pictureBox6.Location = new System.Drawing.Point(183, 181);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 246;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::KarateClub__Project_3_.Properties.Resources.id;
            this.pictureBox5.Location = new System.Drawing.Point(183, 111);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 242;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KarateClub__Project_3_.Properties.Resources.id;
            this.pictureBox2.Location = new System.Drawing.Point(183, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 228;
            this.pictureBox2.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(236, 768);
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
            this.btnSave.Location = new System.Drawing.Point(437, 768);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.Maroon;
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(183, 42);
            this.btnSave.TabIndex = 231;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.guna2Separator1);
            this.gunaShadowPanel1.Controls.Add(this.btnCloseForm);
            this.gunaShadowPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.gunaShadowPanel1.Controls.Add(this.lblTitle);
            this.gunaShadowPanel1.Controls.Add(this.btnSave);
            this.gunaShadowPanel1.Controls.Add(this.btnClose);
            this.gunaShadowPanel1.Controls.Add(this.tcMember);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaShadowPanel1.ShadowDepth = 240;
            this.gunaShadowPanel1.ShadowShift = 7;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(935, 822);
            this.gunaShadowPanel1.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 5;
            this.guna2Separator1.Location = new System.Drawing.Point(29, 85);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(880, 10);
            this.guna2Separator1.TabIndex = 307;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseForm.Image = global::KarateClub__Project_3_.Properties.Resources.delete;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCloseForm.Location = new System.Drawing.Point(832, 25);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.OnHoverImage = null;
            this.btnCloseForm.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.Size = new System.Drawing.Size(49, 42);
            this.btnCloseForm.TabIndex = 306;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.schedule;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(72, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(119, 67);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 305;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(183, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(402, 45);
            this.lblTitle.TabIndex = 304;
            this.lblTitle.Text = "Add Subscription Period";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditSubscriptionPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(935, 822);
            this.Controls.Add(this.gunaShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditSubscriptionPeriod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditSubscriptionPeriod";
            this.Load += new System.EventHandler(this.frmAddEditSubscriptionPeriod_Load);
            this.tcMember.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpSubscriptionPeriodInfo.ResumeLayout(false);
            this.tpSubscriptionPeriodInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMember;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private Member.User_Control.ctrlMemberCardWithFilter ctrlMemberCardWithFilter1;
        private Guna.UI.WinForms.GunaGradientButton btnNext;
        private System.Windows.Forms.TabPage tpSubscriptionPeriodInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaDateTimePicker dtpEndDate;
        private Guna.UI.WinForms.GunaDateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCheckBox cbIsPaid;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblPaymentID;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblMemberID;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblPeriodID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGradientButton btnClose;
        private Guna.UI.WinForms.GunaGradientButton btnSave;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI.WinForms.GunaImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaTextBox txtFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}