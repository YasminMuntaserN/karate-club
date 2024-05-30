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

namespace KarateClub__Project_3_.Belt_Rank
{
    public partial class frmListBeltRank : Form
    {
        private DataTable _dtList;

        private int RankID => (int)dgvBeltRanks.CurrentRow.Cells[0].Value;
        public frmListBeltRank()
        {
            InitializeComponent();
        }

        private void frmBeltRank_Load(object sender, EventArgs e)
        {
            _dtList = clsBeltRank.All();
            dgvBeltRanks.DataSource = _dtList;
            lblRecordsCount.Text = _dtList.Rows.Count.ToString();
            if (_dtList.Rows.Count > 0)
            {
                dgvBeltRanks.Columns[0].Width = 110;

                dgvBeltRanks.Columns[1].Width = 130;

                dgvBeltRanks.Columns[2].Width = 130;

            }
            cbFilterBy.SelectedIndex = 0;
        }

        private string _SearchBy()
        {
            switch (cbFilterBy.Text.Trim())
            {
                case "Rank ID":
                    return "RankID";

                case "Rank Name":
                    return "RankName";

                default:
                    return "None";
            }
        }

        private void editMembersInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditBeltRank frmEditBeltRank = new frmEditBeltRank(RankID);
            frmEditBeltRank.ShowDialog();
            frmBeltRank_Load(null, null);
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

            string ColumnName = _SearchBy();

            if (string.IsNullOrWhiteSpace(txtFilterValue.Text.Trim()) || cbFilterBy.Text == "None")
            {
                _dtList.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvBeltRanks.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Rank ID")
            {
                // search with numbers
                _dtList.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtFilterValue.Text.Trim());
            }
            else
            {
                // search with string
                _dtList.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtFilterValue.Text.Trim());

            }

            lblRecordsCount.Text = dgvBeltRanks.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Rank ID")
            {
                // make sure that the user can only enter the numbers
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
