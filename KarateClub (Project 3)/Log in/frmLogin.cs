using Karate_Bussiness;
using KarateClub__Project_3_.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Log_in
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            if (clsUsers.isUserExist(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }
                clsUsers user = clsUsers.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                if (user != null)
                {
                    clsGlobal.CurrentUser = user;
                    this.Hide();
                    frmMain frm = new frmMain(this);
                    frm.ShowDialog();
                }
                else
                {
                    txtUserName.Focus();
                    errorProvider1.SetError(txtUserName, "Invalid Username/Password.");
                }
            }
            else
            {
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "Invalid Username/Password.");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsGlobal.DeleteValueFromRegistry();
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidation.ValidateNumbers(txtPassword.Text.Trim()) == -1)
            {
                e.Cancel = true;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "UserName cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

    }
}
