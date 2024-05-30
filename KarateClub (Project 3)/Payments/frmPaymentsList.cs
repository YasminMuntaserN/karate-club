using Karate_Bussiness;
using KarateClub__Project_3_.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Payments
{
    public partial class frmPaymentsList : Form
    {
        private DataTable _dtList;

        public frmPaymentsList()
        {
            InitializeComponent();
        }

        private string _SearchBy()
        {
            switch (cbFilterBy.Text.Trim())
            {
                case "Payment ID":
                    return "PaymentID";

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
                lblRecordsCount.Text = dgvPayments.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Payment ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text = dgvPayments.Rows.Count.ToString();
        }

        private void frmPaymentsList_Load(object sender, EventArgs e)
        {
            _dtList = clsPayments.All();
            dgvPayments.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (_dtList.Rows.Count > 0)
            {
                dgvPayments.Columns[0].Width = 150;

                dgvPayments.Columns[1].Width = 150;

                dgvPayments.Columns[2].Width = 150;

                dgvPayments.Columns[3].Width = 150;

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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory((string)dgvPayments.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Payment ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
