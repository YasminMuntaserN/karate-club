using Guna.UI.WinForms;
using Karate_Bussiness;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Users
{
    public partial class frmChangePassword : Form
    {
        private clsUsers _User;
        private int? _UserID = null;
        public frmChangePassword(int? UserID)
        {
            _UserID = UserID;
            InitializeComponent();
        }
        private bool _ChangePassword()
        {
            if (_User.ChangePassword(_User.UserID, txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("An Error Occurred, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_ChangePassword()) return;
        }

        private void lbl_TextChanged(object sender, EventArgs e)
        {
            ((GunaTextBox)sender).UseSystemPasswordChar = true;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            ((GunaTextBox)sender).UseSystemPasswordChar = true;
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "The password field cannot be empty. Please enter a new password.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }

            if (txtNewPassword.Text.Trim() == _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "This password is the same as your current one. Please choose a different password.");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConformPassword_Validating(object sender, CancelEventArgs e)
        {
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (confirmPassword != newPassword)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match. Please confirm your new password again.");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = clsUsers.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
