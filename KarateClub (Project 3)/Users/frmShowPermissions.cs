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
using static Karate_Bussiness.clsUsers;

namespace KarateClub__Project_3_.Users
{
    public partial class frmShowPermissions : Form
    {
        public frmShowPermissions()
        {
            InitializeComponent();
        }
        public int SelectedPermissions
        {
            get
            {
                if(_NotSelectAnyPermission()) return 0;
                return _SetPermissions();
            }
        }

        private bool _AllItemChecked()
        {
            foreach (GunaCheckBox  item in gbPermissions.Controls)
            {
                if (item.Tag.ToString() != "-1")
                {
                    if (!item.Checked)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool _NotSelectAnyPermission()
        {
            // return true if there is no permissions selected, otherwise false

            foreach (GunaCheckBox item in gbPermissions.Controls)
            {
                if (item.Checked)
                    return false;
            }

            return true;
        }

        public void voidChangeItem()
        {
            foreach (GunaCheckBox item in gbPermissions.Controls)
            {
                item.Enabled = false;
            }
        }

        private int _SetPermissions()
        {
            int Permissions = 0;

            if (chkAllPermissions.Checked)
                return -1;


            if (chkManageMembers.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageMembers;

            if (chkManageInstructors.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageInstructors;

            if (chkManageUsers.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageUsers;

            if (chkManageMembersInstructors.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageMembersInstructors;

            if (chkManageBeltRanks.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageBeltRanks;

            if (chkManageSubscriptionPeriods.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageSubscriptionPeriods;

            if (chkManageBeltTests.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManageBeltTests;

            if (chkManagePayments.Checked)
                Permissions += (byte)clsUsers.enPermissions.ManagePayments;

            return Permissions;
        }


        //private void chkAllPermissions_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkAllPermissions.Checked)
        //    {
        //        foreach (GunaCheckBox item in gbPermissions.Controls)
        //        {
        //            item.Checked = true;
        //        }
        //    }
        //}

        private void frmShowPermissions_Load(object sender, EventArgs e)
        {
            if (!_AllItemChecked())
            {
                chkAllPermissions.Checked = false;
            }
            else
            {
                chkAllPermissions.Checked = true;
            }
        }

        public  void FillCheckBoxPermissions(int Permissions)
        {
            if (Permissions == -1)
            {
                chkAllPermissions.Checked = true;
                return;
            }

            foreach (GunaCheckBox item in gbPermissions.Controls)
            {
                if (item.Tag.ToString() != "-1")
                {
                    if (((Convert.ToInt32(item.Tag)) & Permissions) == (Convert.ToInt32(item.Tag)))
                    {
                        item.Checked = true;
                    }
                }
            }

        }

        public  void Clear()
        {
            foreach (CheckBox item in gbPermissions.Controls)
            {
                item.Checked= false;
            }

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
