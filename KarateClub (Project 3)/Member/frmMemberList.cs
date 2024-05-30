using Karate_Bussiness;
using KarateClub__Project_3_.Member;
using KarateClub__Project_3_.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KarateClub__Project_3_.Home
{
    public partial class frmMemberList : Form
    {
        private DataTable _dtList;
        public frmMemberList()
        {
            InitializeComponent();
        }
        private int MemberID => (int)dgvMembers.CurrentRow.Cells[0].Value;

        private void frmList_Load(object sender, EventArgs e)
        {
            _dtList = clsMember.AllMembers();
            dgvMembers.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (_dtList.Rows.Count > 0)
            {
                dgvMembers.Columns[0].Width = 110;

                dgvMembers.Columns[1].Width = 130;

                dgvMembers.Columns[2].Width = 130;

                dgvMembers.Columns[3].Width = 130;

                dgvMembers.Columns[4].Width = 130;

                dgvMembers.Columns[5].Width = 130;

                dgvMembers.Columns[6].Width = 130;

                dgvMembers.Columns[7].Width = 130;


            }
            cbFilterBy.SelectedIndex = 0;
        }

        private string _SearchBy()
        {
            switch (cbFilterBy.Text.Trim())
            {
                case "Member ID":
                    return "MemberID";

                case "Member Name":
                    return "Name";

                case "Rank Name":
                    return "RankName";

                default:
                    return "None";
            }
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void editMembersInstructorsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddEditMember frmAddEditMember = new frmAddEditMember(MemberID);
            frmAddEditMember.ShowDialog();
            //
            frmList_Load(null, null);
        }

        private void cmsshowMembersInstructorsDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmShowMemberInfo frmShowMemberInfo = new frmShowMemberInfo(MemberID);
            frmShowMemberInfo.ShowDialog();
            //
            frmList_Load(null, null);
        }

        private void cmsDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Member [" + MemberID + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Perform Delete and refresh
                if (clsMember.Delete(MemberID))
                {
                    MessageBox.Show("Member Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmList_Load(null, null);
                }

                else
                    MessageBox.Show("Member was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            clsMember member = clsMember.Find(MemberID);
            if (!member.HasMemberSubscriptionPeriod)
            {
                MessageBox.Show("This member does not have a subscription period");
                toolStripMenuItem1.Enabled=false;
                return;
            }
            frmHistory frmHistory = new frmHistory(MemberID, "Periods");
            frmHistory.ShowDialog();
            //Refresh
            frmList_Load(null, null);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddEditMember frmAddEditMember = new frmAddEditMember();
            frmAddEditMember.ShowDialog();
            //Refresh
            frmList_Load(null, null);
        }

        private void cbBeltRank_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "RankName", cbBeltRank.Text);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Member ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtList.Rows.Count == 0)
            {
                return;
            }

            string ColumnName = _SearchBy();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilterBy.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvMembers.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Member ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text = dgvMembers.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None") && (cbFilterBy.Text != "Rank Name");
            pbSearch.Visible = false;
            cbBeltRank.Visible = (cbFilterBy.Text == "Rank Name");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            if (cbBeltRank.Visible)
            {
                cbBeltRank.SelectedIndex = 0;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory(MemberID,"Tests");
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory((string)dgvMembers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
