namespace KarateClub__Project_3_.Home
{
    partial class frmMemberList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cnsShowMembersDetails = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editMembersInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new Guna.UI.WinForms.GunaComboBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.cbBeltRank = new Guna.UI.WinForms.GunaComboBox();
            this.cnsShowMembersDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cnsShowMembersDetails
            // 
            this.cnsShowMembersDetails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnsShowMembersDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator1,
            this.editMembersInstructorsToolStripMenuItem,
            this.toolStripSeparator2,
            this.cmsDelete,
            this.toolStripSeparator3,
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem1,
            this.toolStripSeparator6,
            this.toolStripMenuItem2,
            this.toolStripSeparator7,
            this.toolStripMenuItem3});
            this.cnsShowMembersDetails.Name = "gunaContextMenuStrip1";
            this.cnsShowMembersDetails.RenderStyle.ArrowColor = System.Drawing.Color.White;
            this.cnsShowMembersDetails.RenderStyle.BorderColor = System.Drawing.Color.RosyBrown;
            this.cnsShowMembersDetails.RenderStyle.ColorTable = null;
            this.cnsShowMembersDetails.RenderStyle.RoundedEdges = true;
            this.cnsShowMembersDetails.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cnsShowMembersDetails.RenderStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.cnsShowMembersDetails.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cnsShowMembersDetails.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cnsShowMembersDetails.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cnsShowMembersDetails.Size = new System.Drawing.Size(238, 250);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.add_user1;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.addToolStripMenuItem.Text = "Add Members";
            this.addToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // editMembersInstructorsToolStripMenuItem
            // 
            this.editMembersInstructorsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.editMembersInstructorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMembersInstructorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.editMembersInstructorsToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.user__3_;
            this.editMembersInstructorsToolStripMenuItem.Name = "editMembersInstructorsToolStripMenuItem";
            this.editMembersInstructorsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.editMembersInstructorsToolStripMenuItem.Text = "Edit Members";
            this.editMembersInstructorsToolStripMenuItem.Click += new System.EventHandler(this.editMembersInstructorsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(234, 6);
            // 
            // cmsDelete
            // 
            this.cmsDelete.BackColor = System.Drawing.Color.DarkGray;
            this.cmsDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDelete.Image = global::KarateClub__Project_3_.Properties.Resources.bin;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(237, 26);
            this.cmsDelete.Text = "Delete Members";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(234, 6);
            // 
            // cmsshowMembersInstructorsDetailsToolStripMenuItem
            // 
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.presentation;
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Name = "cmsshowMembersInstructorsDetailsToolStripMenuItem";
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Text = "Show Members Details";
            this.cmsshowMembersInstructorsDetailsToolStripMenuItem.Click += new System.EventHandler(this.cmsshowMembersInstructorsDetailsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::KarateClub__Project_3_.Properties.Resources.schedule;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItem1.Text = "Period History";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Maroon;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Image = global::KarateClub__Project_3_.Properties.Resources.clock;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItem2.Text = "Tests History";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(234, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem3.Image = global::KarateClub__Project_3_.Properties.Resources.mobile_payment;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItem3.Text = "Payments History";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BaseColor = System.Drawing.Color.White;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Maroon;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Member ID",
            "Member Name",
            "Rank Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(203, 172);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.OnHoverItemBaseColor = System.Drawing.Color.DimGray;
            this.cbFilterBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.Size = new System.Drawing.Size(192, 31);
            this.cbFilterBy.TabIndex = 341;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged_1);
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.ContextMenuStrip = this.cnsShowMembersDetails;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.Location = new System.Drawing.Point(12, 257);
            this.dgvMembers.Name = "dgvMembers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvMembers.RowTemplate.Height = 26;
            this.dgvMembers.Size = new System.Drawing.Size(999, 404);
            this.dgvMembers.TabIndex = 340;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblRecordsCount);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.RosyBrown;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Maroon;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 656);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(999, 44);
            this.guna2CustomGradientPanel1.TabIndex = 339;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(560, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 322;
            this.label3.Text = "Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(406, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 38);
            this.label2.TabIndex = 320;
            this.label2.Text = "Total :";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(513, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(41, 38);
            this.lblRecordsCount.TabIndex = 321;
            this.lblRecordsCount.Text = "??";
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Image = global::KarateClub__Project_3_.Properties.Resources.add;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.Location = new System.Drawing.Point(820, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Size = new System.Drawing.Size(82, 71);
            this.btnAdd.TabIndex = 338;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbSearch.Image = global::KarateClub__Project_3_.Properties.Resources.searching_magnifying_glass;
            this.pbSearch.Location = new System.Drawing.Point(704, 172);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(35, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 337;
            this.pbSearch.TabStop = false;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterValue.Location = new System.Drawing.Point(424, 167);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 15;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(325, 42);
            this.txtFilterValue.TabIndex = 336;
            this.txtFilterValue.Text = "Enter to Search :";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 335;
            this.label1.Text = "Filter By :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(38, 96);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(944, 31);
            this.guna2Separator1.TabIndex = 334;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.judo__3_1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(65, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(131, 91);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 333;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(193, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 55);
            this.lblTitle.TabIndex = 332;
            this.lblTitle.Text = "List Members";
            // 
            // cbBeltRank
            // 
            this.cbBeltRank.BackColor = System.Drawing.Color.Transparent;
            this.cbBeltRank.BaseColor = System.Drawing.Color.White;
            this.cbBeltRank.BorderColor = System.Drawing.Color.Black;
            this.cbBeltRank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBeltRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeltRank.FocusedColor = System.Drawing.Color.Empty;
            this.cbBeltRank.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBeltRank.ForeColor = System.Drawing.Color.Black;
            this.cbBeltRank.FormattingEnabled = true;
            this.cbBeltRank.Items.AddRange(new object[] {
            "White Belt",
            "Yellow Belt",
            "Orange Belt",
            "Green Belt",
            "Blue Belt",
            "Purple Belt",
            "Brown Belt",
            "Black Belt(1st Dan)",
            "Black Belt(2nd Dan)",
            "Black Belt(3rd Dan)",
            "Black Belt(4th Dan)",
            "Black Belt(5th Dan)",
            "Black Belt(6th Dan)",
            "Black Belt(7th Dan)",
            "Black Belt(8th Dan)",
            "Black Belt(9th Dan)",
            "Black Belt(10th Dan)"});
            this.cbBeltRank.Location = new System.Drawing.Point(434, 172);
            this.cbBeltRank.Name = "cbBeltRank";
            this.cbBeltRank.OnHoverItemBaseColor = System.Drawing.Color.DimGray;
            this.cbBeltRank.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBeltRank.Radius = 10;
            this.cbBeltRank.Size = new System.Drawing.Size(192, 31);
            this.cbBeltRank.TabIndex = 342;
            this.cbBeltRank.SelectedIndexChanged += new System.EventHandler(this.cbBeltRank_SelectedIndexChanged_1);
            // 
            // frmMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 712);
            this.Controls.Add(this.cbBeltRank);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberList";
            this.Text = "frmList";
            this.Load += new System.EventHandler(this.frmList_Load);
            this.cnsShowMembersDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaContextMenuStrip cnsShowMembersDetails;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editMembersInstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmsshowMembersInstructorsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private Guna.UI.WinForms.GunaComboBox cbFilterBy;
        private System.Windows.Forms.DataGridView dgvMembers;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaComboBox cbBeltRank;
    }
}