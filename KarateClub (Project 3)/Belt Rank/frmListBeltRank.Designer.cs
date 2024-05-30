namespace KarateClub__Project_3_.Belt_Rank
{
    partial class frmListBeltRank
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
            this.editMembersInstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new Guna.UI.WinForms.GunaComboBox();
            this.dgvBeltRanks = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.cnsShowMembersDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltRanks)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cnsShowMembersDetails
            // 
            this.cnsShowMembersDetails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnsShowMembersDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMembersInstructorsToolStripMenuItem});
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
            this.cnsShowMembersDetails.Size = new System.Drawing.Size(177, 30);
            // 
            // editMembersInstructorsToolStripMenuItem
            // 
            this.editMembersInstructorsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.editMembersInstructorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMembersInstructorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.editMembersInstructorsToolStripMenuItem.Image = global::KarateClub__Project_3_.Properties.Resources.user__3_;
            this.editMembersInstructorsToolStripMenuItem.Name = "editMembersInstructorsToolStripMenuItem";
            this.editMembersInstructorsToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.editMembersInstructorsToolStripMenuItem.Text = "Edit Belt Rank";
            this.editMembersInstructorsToolStripMenuItem.Click += new System.EventHandler(this.editMembersInstructorsToolStripMenuItem_Click);
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
            "Rank ID",
            " Rank Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(271, 172);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.OnHoverItemBaseColor = System.Drawing.Color.DimGray;
            this.cbFilterBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.Size = new System.Drawing.Size(192, 31);
            this.cbFilterBy.TabIndex = 331;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged_1);
            // 
            // dgvBeltRanks
            // 
            this.dgvBeltRanks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeltRanks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeltRanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeltRanks.ContextMenuStrip = this.cnsShowMembersDetails;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBeltRanks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeltRanks.EnableHeadersVisualStyles = false;
            this.dgvBeltRanks.Location = new System.Drawing.Point(201, 255);
            this.dgvBeltRanks.Name = "dgvBeltRanks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeltRanks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBeltRanks.RowHeadersWidth = 51;
            this.dgvBeltRanks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvBeltRanks.RowTemplate.Height = 26;
            this.dgvBeltRanks.Size = new System.Drawing.Size(614, 404);
            this.dgvBeltRanks.TabIndex = 330;
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
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(201, 665);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(614, 44);
            this.guna2CustomGradientPanel1.TabIndex = 329;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(326, 8);
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
            this.label2.Location = new System.Drawing.Point(193, 0);
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
            this.lblRecordsCount.Location = new System.Drawing.Point(279, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(41, 38);
            this.lblRecordsCount.TabIndex = 321;
            this.lblRecordsCount.Text = "??";
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbSearch.Image = global::KarateClub__Project_3_.Properties.Resources.searching_magnifying_glass;
            this.pbSearch.Location = new System.Drawing.Point(714, 172);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(35, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 327;
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
            this.txtFilterValue.Location = new System.Drawing.Point(480, 166);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 15;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(325, 42);
            this.txtFilterValue.TabIndex = 326;
            this.txtFilterValue.Text = "Enter to Search :";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged_1);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(115, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 325;
            this.label1.Text = "Filter By :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(48, 96);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(944, 31);
            this.guna2Separator1.TabIndex = 324;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::KarateClub__Project_3_.Properties.Resources.black_belt;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(75, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(131, 91);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 323;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(203, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 55);
            this.lblTitle.TabIndex = 322;
            this.lblTitle.Text = "List Belt Rank";
            // 
            // frmListBeltRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 723);
            this.ContextMenuStrip = this.cnsShowMembersDetails;
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.dgvBeltRanks);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListBeltRank";
            this.Text = "frmBeltRank";
            this.Load += new System.EventHandler(this.frmBeltRank_Load);
            this.cnsShowMembersDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltRanks)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaContextMenuStrip cnsShowMembersDetails;
        private System.Windows.Forms.ToolStripMenuItem editMembersInstructorsToolStripMenuItem;
        private Guna.UI.WinForms.GunaComboBox cbFilterBy;
        private System.Windows.Forms.DataGridView dgvBeltRanks;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel lblTitle;
    }
}