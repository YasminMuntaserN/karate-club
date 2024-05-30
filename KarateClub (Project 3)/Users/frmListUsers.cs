using Karate_Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Users
{
    public partial class frmListUsers : Form
    {
        private DataTable _dtList;

        private int UserID => (int)dgvUsers.CurrentRow.Cells[0].Value;
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtList = clsUsers.GetAllUsers();
            dgvUsers.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (_dtList.Rows.Count > 0)
            {
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].Width = 130;

                dgvUsers.Columns[2].Width = 130;

                dgvUsers.Columns[3].Width = 130;

                dgvUsers.Columns[4].Width = 130;

                dgvUsers.Columns[5].Width = 130;

                dgvUsers.Columns[6].Width = 130;

            }
            cbFilterBy.SelectedIndex = 0;
        }

        private string _SearchBy()
        {
            switch (cbFilterBy.Text.Trim())
            {
                case "User ID":
                    return "UserID";

                case "Name":
                    return "Name";

                case "User Name":
                    return "UserName";

                default:
                    return "None";
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void editMembersInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser(UserID);
            frmAddEditUser.ShowDialog();
            //
            frmListUsers_Load(null, null);
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + UserID + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Perform Delete and refresh
                if (clsUsers.DeleteUser(UserID))
                {
                    MessageBox.Show("User Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUsers_Load(null, null);
                }

                else
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsshowMembersInstructorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmShowUserInfo = new frmShowUserInfo(UserID);
            frmShowUserInfo.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(UserID);
            frmChangePassword.ShowDialog();
            frmListUsers_Load(null, null);
        }

         private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            // 
            frmListUsers_Load(null, null);
        }

        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            if (_dtList.Rows.Count == 0)
            {
                return;
            }

            string ColumnName = _SearchBy();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilterBy.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "User ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            pbSearch.Visible = false;

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }
    }
}
