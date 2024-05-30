using Karate_Bussiness;
using KarateClub__Project_3_.Global_Classes;
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

namespace KarateClub__Project_3_.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblBeltNum.Text = clsBeltRank.Count().ToString();
            lblInstructorsNum.Text = clsInstructor.Count().ToString();
            lblMembersNum.Text = clsMember.Count().ToString();
            lblUsersNum.Text = clsUsers.Count().ToString();
            lblSuscribtionNum.Text = clsSubscriptionPeriod.Count().ToString();
            txtUserNmae.Text =clsGlobal.CurrentUser.UserName;
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditMember frmAddEditMember = new frmAddEditMember();
            frmAddEditMember.ShowDialog();
        }


    }
}
