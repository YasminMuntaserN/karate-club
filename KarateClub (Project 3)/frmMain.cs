using Guna.UI.WinForms;
using Karate_Bussiness;
using KarateClub__Project_3_.Belt_Rank;
using KarateClub__Project_3_.Belt_Tests;
using KarateClub__Project_3_.Dashboard;
using KarateClub__Project_3_.Global_Classes;
using KarateClub__Project_3_.Home;
using KarateClub__Project_3_.Instructors;
using KarateClub__Project_3_.Log_in;
using KarateClub__Project_3_.MemberInstructors;
using KarateClub__Project_3_.Payments;
using KarateClub__Project_3_.Properties;
using KarateClub__Project_3_.Subscription_Period;
using KarateClub__Project_3_.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_
{
    public partial class frmMain : Form
    {
        private GunaAdvenceButton _currentButton;
        private Form _activeForm;
        private frmLogin _frmLogin; 

        public frmMain(frmLogin frmLogin)
        {
            _frmLogin = frmLogin;
            InitializeComponent();
        }
        private void _ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (GunaAdvenceButton)btnSender)
                {
                    _DisableMenuButton();
                    _currentButton = (GunaAdvenceButton)btnSender;
                }
            }
        }

        private void _DisableMenuButton()
        {
            GunaAdvenceButton GunaAdvenceButton = new GunaAdvenceButton();

            foreach (Control previousBtn in Disaplypanel.Controls)
            {
                if (previousBtn.GetType() == typeof(GunaAdvenceButton))
                {
                    GunaAdvenceButton = (GunaAdvenceButton)previousBtn;
                }
            }
        }

        public async void OpenChildFormAsync(Form childForm, object btnSender)
        {
            await Task.Delay(100);

            _activeForm?.Close();

            _ActivateButton(btnSender);
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Disaplypanel.Controls.Add(childForm);
            Disaplypanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public  void LoadSubClass(Form childForm)
        {
            childForm.TopLevel = false;
            Disaplypanel.Controls.Add(childForm);
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void btnSubscriptionPeriods_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageSubscriptionPeriods))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmListSubscriptionPeriod(), sender);
        }

        private void btnMembers_Instructors_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageMembersInstructors))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmMemberInstructorsList(), sender);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageMembers))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmMemberList(), sender);
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageInstructors))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmInstructorList(), sender);    
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageUsers))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmListUsers(), sender);
        }

        private void btnBeltRanks_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageBeltRanks))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmListBeltRank(), sender);
        }

        private void btnBeltTests_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManageBeltTests))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmListBeltTests(), sender);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckAccessDenied(clsUsers.enPermissions.ManagePayments))
            {
                MessageBox.Show("Access Denied:" +
                    " You do not have permission to use this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenChildFormAsync(new frmPaymentsList(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
            if (clsGlobal.CurrentUser.ImagePath != "")
            {
                pbUser.ImageLocation = clsGlobal.CurrentUser.ImagePath;
            }
            else
            {
                pbUser.Image =Resources.judo__2_;
            }
  
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();
            frmAddEditUser.Show();  
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            btnLogOut.PerformClick();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();   
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildFormAsync(new frmDashboard(), sender);
        }
    }
}
