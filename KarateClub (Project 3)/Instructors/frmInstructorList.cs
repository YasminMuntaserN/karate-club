using Karate_Bussiness;
using KarateClub__Project_3_.MemberInstructors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Instructors
{
    public partial class frmInstructorList : Form
    {
        private DataTable _dtList;
        private int InstructorID => (int)dgvInstructors.CurrentRow.Cells[0].Value;
        public frmInstructorList()
        {
            InitializeComponent();
        }

        private void frmInstructorList_Load(object sender, EventArgs e)
        {
            _dtList = clsInstructor.AllInstructors();
            dgvInstructors.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (_dtList.Rows.Count > 0)
            {
                dgvInstructors.Columns[0].Width = 110;

                dgvInstructors.Columns[1].Width = 130;

                dgvInstructors.Columns[2].Width = 130;

                dgvInstructors.Columns[3].Width = 130;

                dgvInstructors.Columns[4].Width = 130;

                dgvInstructors.Columns[5].Width = 130;

            }
            cbFilterBy.SelectedIndex = 0;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void editMembersInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditInstructor frmAddEditInstructor = new frmAddEditInstructor(InstructorID);
            frmAddEditInstructor.ShowDialog();
            //Refresh
            frmInstructorList_Load(null, null);
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Instructor [" + InstructorID + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Perform Delete and refresh
                if (clsInstructor.DeleteInstructor(InstructorID))
                {
                    MessageBox.Show("Instructor Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInstructorList_Load(null, null);
                }

                else
                    MessageBox.Show("Member was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsshowMembersInstructorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInstructorInfo frmShowInstructorInfo = new frmShowInstructorInfo(InstructorID);
            frmShowInstructorInfo.ShowDialog();
            //Refresh
            frmInstructorList_Load(null, null);

        }

        private void trainedMembersByInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrainedMembersByInstructorList frm = new frmTrainedMembersByInstructorList(InstructorID);
            frm.ShowDialog();
            // Refresh
            frmInstructorList_Load(null, null);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddEditInstructor frmAddEditInstructor = new frmAddEditInstructor();
            frmAddEditInstructor.ShowDialog();
            //Refresh
            frmInstructorList_Load(null, null);
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

        private void txtFilterValue_TextChanged_1(object sender, EventArgs e)
        {

            if (_dtList.Rows.Count == 0)
            {
                return;
            }


            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilterBy.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvInstructors.Rows.Count.ToString();
                return;
            }


            if (cbFilterBy.Text == "Instructor ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", "InstructorID", txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Name", txtFilterValue.Text.Trim());

            }
        }

        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Instructor ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }


    }
}
