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
    public partial class frmEditBeltRank : Form
    {
        private int? _RankID = null;
        private clsBeltRank _Rank ;  
        public frmEditBeltRank(int RankID)
        {
            InitializeComponent();
            _RankID = RankID;   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _Rank = clsBeltRank.Find(_RankID);

            if (_Rank == null)
            {
                MessageBox.Show("No Rank with ID = " + _RankID, "Rank Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }
            lblRankID.Text = _Rank.RankID.ToString();
            txtRankName.Text = _Rank.RankName;
            txtFees.Text = _Rank.TestFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Rank.TestFees =decimal.Parse(txtFees.Text);
            _Rank.RankName= txtRankName.Text;

            if (_Rank.Update())
            {
                MessageBox.Show("Rank Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Rank Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmEditBeltRank_Load(object sender, EventArgs e)
        {
            _LoadData();    
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
