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
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsUsers _User;

        private int? _UserID = null;
        public frmAddEditUser(int UserID)
        {
            _UserID = UserID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private frmShowPermissions _frmShowPermissions = new frmShowPermissions();
        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUsers();
            }
            else
            {
                this.Text = "Update User";
                lblTitle.Text = "Update User";
            }
        }

        public void LoadData()
        {
            _User = clsUsers.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            lblUserID.Text = _User.UserID.ToString();

            ctrlPersonCardWithFilter1.FilterEnabled = false;

            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

            txtUserName.Text = _User.UserName;

            txtPassword.Text = _User.Password;

            _frmShowPermissions.FillCheckBoxPermissions(_User.Permissions);

            btnNext.Enabled = true;
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void _FillData()
        {
            _User.PersonID = ctrlPersonCardWithFilter1.PersonInfo.PersonID;

            _User.UserName = txtUserName.Text;

            _User.Password = txtPassword.Text;

            _User.Permissions = _frmShowPermissions.SelectedPermissions;
        }

        private void _SaveData()
        {
            if (_User.Save())
            {
                MessageBox.Show("User Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text = _User.UserID.ToString();
                lblTitle.Text = "Update User Info";
                this._Mode = enMode.Update;

                _User.Mode = clsUsers.enMode.Update;
            }

            else
            {
                MessageBox.Show("User Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _CheckForCorrectData()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckForCorrectData())
            {
                return;
            }
            _FillData();
            _SaveData();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
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
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }


            if (txtUserName.Text.Trim().ToLower() != _User.UserName.ToLower() &&
                clsUsers.isUserExist(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "username is used by another user");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcUser.SelectedTab = tcUser.TabPages["tpUserInfo"];

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            tpUserInfo.Enabled = false;
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent(object sender, Person.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {

            if (ctrlPersonCardWithFilter1.PersonInfo.User && _Mode != enMode.Update)
            {
                MessageBox.Show("This person has already been registered as a Member in this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                tpUserInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            btnNext.Enabled = true;
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowPermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmShowPermissions.ShowDialog();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
