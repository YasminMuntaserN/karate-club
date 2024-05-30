using Karate_Bussiness;
using KarateClub__Project_3_.Member;
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

namespace KarateClub__Project_3_.Subscription_Period
{
    public partial class frmListSubscriptionPeriod : Form
    {
        private DataTable _dtList;
        private int? SubscriptionPeriodID => (int)dgvSubscriptionPeriod.CurrentRow.Cells[0].Value;
        public frmListSubscriptionPeriod()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditSubscriptionPeriod frmAddEditSubscriptionPeriod = new frmAddEditSubscriptionPeriod();
            frmAddEditSubscriptionPeriod.ShowDialog();
            //
            frmListSubscriptionPeriod_Load(null ,null);
        }

        private void frmListSubscriptionPeriod_Load(object sender, EventArgs e)
        {
            _dtList = clsSubscriptionPeriod.AllSubscriptionPeriods();
            dgvSubscriptionPeriod.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (_dtList.Rows.Count > 0)
            {
                dgvSubscriptionPeriod.Columns[0].Width = 110;

                dgvSubscriptionPeriod.Columns[1].Width = 130;

                dgvSubscriptionPeriod.Columns[2].Width = 130;

                dgvSubscriptionPeriod.Columns[3].Width = 130;

                dgvSubscriptionPeriod.Columns[4].Width = 130;

                dgvSubscriptionPeriod.Columns[5].Width = 130;

                dgvSubscriptionPeriod.Columns[6].Width = 130;

                dgvSubscriptionPeriod.Columns[7].Width = 130;

                dgvSubscriptionPeriod.Columns[8].Width = 130;

            }
            cbFilterBy.SelectedIndex = 0;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void editMembersInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditSubscriptionPeriod frmAddEditSubscriptionPeriod = new frmAddEditSubscriptionPeriod(SubscriptionPeriodID);
            frmAddEditSubscriptionPeriod.ShowDialog();
            //
            frmListSubscriptionPeriod_Load(null, null);
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Subscription Period [" + SubscriptionPeriodID + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Perform Delete and refresh
                if (clsSubscriptionPeriod.Delete(SubscriptionPeriodID))
                {
                    MessageBox.Show("Subscription Period Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListSubscriptionPeriod_Load(null, null);
                }

                else
                    MessageBox.Show("Subscription Period was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trainedMembersByInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsSubscriptionPeriod SubscriptionPeriod = clsSubscriptionPeriod.FindByPeriodID(SubscriptionPeriodID);
            if (SubscriptionPeriod.IsPaid)
            {
                MessageBox.Show("Payment has been made in advance");
                return;
            }
            if (clsPayments.Pay(SubscriptionPeriod.MemberInfo) != -1)
            {
                SubscriptionPeriod.IsPaid = true;
                if (!SubscriptionPeriod.Save())
                {
                    MessageBox.Show("Error in Payment !!");
                    return;
                }
            }
            if (!clsPayments.SetActiveMemberAfterPayment(SubscriptionPeriod))
            {
                MessageBox.Show("Error in Payment !!");
            }
            frmListSubscriptionPeriod_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHistory history = new frmHistory((string)dgvSubscriptionPeriod.CurrentRow.Cells[1].Value);
            history.ShowDialog();   
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None") ;
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
                case "Period ID":
                    return "PeriodID";

                case "Member Name":
                    return "MemberName";

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
                lblRecordsCount.Text = dgvSubscriptionPeriod.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Period ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text = dgvSubscriptionPeriod.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Period ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
