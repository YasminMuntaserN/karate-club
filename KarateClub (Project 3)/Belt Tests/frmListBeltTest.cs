using Karate_Bussiness;
using KarateClub__Project_3_.Member;
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

namespace KarateClub__Project_3_.Belt_Tests
{
    public partial class frmListBeltTests : Form
    {
        private DataTable _dtList;

        private int TestID => (int)dgvListBeltTests.CurrentRow.Cells[0].Value;

        public frmListBeltTests()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmAddBeltTest frmAddBeltTest = new frmAddBeltTest();
            frmAddBeltTest.ShowDialog();
            //
            frmListPaymentsTest_Load(null, null);
        }

        private void frmListPaymentsTest_Load(object sender, EventArgs e)
        {
            _dtList = clsBeltTest.All();
            dgvListBeltTests.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (dgvListBeltTests.Rows.Count > 0)
            {
                dgvListBeltTests.Columns[0].Width = 110;

                dgvListBeltTests.Columns[1].Width = 130;

                dgvListBeltTests.Columns[2].Width = 130;

                dgvListBeltTests.Columns[3].Width = 130;

                dgvListBeltTests.Columns[4].Width = 130;

                dgvListBeltTests.Columns[5].Width = 130;

                dgvListBeltTests.Columns[6].Width = 130;


            }
            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            pbSearch.Visible = false;

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private string _SearchBy()
        {
            switch (cbFilterBy.Text.Trim())
            {
                case "Test ID":
                    return "TestID";

                case "Member Name":
                    return "MemberName";

                case "Instructor Name":
                    return "InstructorName";

                case "Rank Name":
                    return "RankName";
                default:
                    return "None";
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
                lblRecordsCount.Text = dgvListBeltTests.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Test ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text = dgvListBeltTests.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Test ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBeltTest frmAddBeltTest = new frmAddBeltTest(TestID);
            frmAddBeltTest.ShowDialog();
            //
            frmListPaymentsTest_Load(null, null);
        }

        private void cmsshowMembersInstructorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsBeltTest test= clsBeltTest.Find(TestID);
            frmHistory history = new frmHistory(test.MemberID, "Tests");
            history.ShowDialog();
            //
            frmListPaymentsTest_Load(null, null);
        }
    }
}
