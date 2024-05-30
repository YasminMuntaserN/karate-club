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

namespace KarateClub__Project_3_.MemberInstructors
{
    public partial class frmMemberInstructorsList : Form
    {
        private DataTable _dtList;
        public frmMemberInstructorsList()
        {
            InitializeComponent();
        }

        private void frmMemberInstructorsList_Load(object sender, EventArgs e)
        {
            _dtList = clsMemberInstructor.GetAllMemberInstructors();
            dgvMemberInstractors.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if(_dtList.Rows.Count > 0)
            {
                dgvMemberInstractors.Columns[0].Width = 150;

                dgvMemberInstractors.Columns[1].Width = 170;

                dgvMemberInstractors.Columns[2].Width = 170;

                dgvMemberInstractors.Columns[3].Width = 170;

            }
            cbFilterBy.SelectedIndex = 0;   
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void editMembersInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditMemberInstructors frm = new frmAddEditMemberInstructors((int)dgvMemberInstractors.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //Refresh
            frmMemberInstructorsList_Load(null, null);
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Member Instructors [" + dgvMemberInstractors.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delete and refresh
                if (clsMemberInstructor.DeleteMemberInstructor((int)dgvMemberInstractors.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Member Instructors Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMemberInstructorsList_Load(null, null);
                }

                else
                    MessageBox.Show("Member Instructors was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmsshowMembersInstructorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsInstructor instructor = clsInstructor.FindByInstructorName((string)dgvMemberInstractors.CurrentRow.Cells[2].Value);
            if (instructor != null)
            {
                frmTrainedMembersByInstructorList frm = new frmTrainedMembersByInstructorList(instructor.InstructorID);
                frm.ShowDialog();
                // Refresh
                frmMemberInstructorsList_Load(null, null);
            }
        }

        private string _SearchBy()
        {
            switch (cbFilterBy.Text)
            {
                case "Members-Instructors ID":
                    return "MemberInstructorID";

                case "Member Name":
                    return "MemberName";

                case "Instructor Name":
                    return "InstructorName";

                default:
                    return "None";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditMemberInstructors frm = new frmAddEditMemberInstructors();
            frm.ShowDialog();
            //
            frmMemberInstructorsList_Load(null, null);
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            pbSearch.Visible = (cbFilterBy.Text != "None");

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

            string ColumnName = _SearchBy();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilterBy.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvMemberInstractors.Rows.Count.ToString();

                return;
            }

            if (cbFilterBy.Text == "Members-Instructors ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter =
                    string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter =
                    string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvMemberInstractors.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Members-Instructors ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
