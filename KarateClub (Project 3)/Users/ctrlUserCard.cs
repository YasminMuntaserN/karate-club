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

namespace KarateClub__Project_3_.Users
{
    public partial class ctrlUserCard : UserControl
    {
        private clsUsers _User;

        private int? _UserID = null;

        public int? UserID => _UserID;

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int? UserID)
        {
            _User = clsUsers.FindByUserID(UserID);
            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _UserID = _User.UserID;
            _FillUserInfo();
        }

        public void LoadUserInfoByPersonID(int? PersonID)
        {
            _User = clsUsers.FindByPersonID(PersonID);
            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("No User with UserID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _UserID = _User.UserID;
            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();
            lblPassword.Text = _User.Password.ToString();
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            frmShowPermissions frmShowPermissions = new frmShowPermissions();
            frmShowPermissions.FillCheckBoxPermissions(_User.Permissions);
        }

        public void ResetUserInfo()
        {
            lblPassword.Text = "[????]";
            lblUserName.Text = "[????]";
            lblUserID.Text = "[????]";
            frmShowPermissions frmShowPermissions = new frmShowPermissions();
            frmShowPermissions.Clear();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPermissions _frmShowPermissions = new frmShowPermissions();
            _frmShowPermissions.voidChangeItem();
            _frmShowPermissions.FillCheckBoxPermissions(_User.Permissions);
            _frmShowPermissions.ShowDialog();    
        }
    }
}
