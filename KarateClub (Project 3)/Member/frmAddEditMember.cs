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

namespace KarateClub__Project_3_.Member
{
    public partial class frmAddEditMember : Form
    {
        public delegate void DataBackEventHandler(object sender, int? PersonID);

        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsMember _Member;

        private int? _MemberID = null;
        public frmAddEditMember()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditMember(int? MemberID)
        {
            InitializeComponent();
            _MemberID = MemberID;
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Member";
                this.Text = "Add New Member";
                _Member = new clsMember();
            }
            else
            {
                this.Text = "Update Member";
                lblTitle.Text = "Update Member";
            }
        }

        public void  LoadData()
        {
            _Member = clsMember.Find(_MemberID);

            if (_MemberID == null)
            {
                MessageBox.Show("No Member with ID = " + _MemberID, "Member Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            lblMemberD.Text = _Member.MemberID.ToString();

            ctrlPersonCardWithFilter1.FilterEnabled = false;

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Member.PersonID);

            txtEmergencyContactInfo.Text = _Member.EmergencyContactInfo;

            cbBeltRank.SelectedIndex = cbBeltRank.FindString(clsBeltRank.Find(_Member.LastBeltRankID).RankName);

            if (_Member.HasMemberSubscriptionPeriod)
            {
                cbIsActive.Checked = clsSubscriptionPeriod.FindByMemberID(_Member.MemberID).IsPaid;
            }
            else
            {
                cbIsActive.Checked=false;
            }

            btnNext.Enabled = true;
            tpMemberInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void _FillData()
        {
            _Member.PersonID = ctrlPersonCardWithFilter1.PersonInfo.PersonID;

            _Member.LastBeltRankID = clsBeltRank.Find(cbBeltRank.Text).RankID;

            _Member.EmergencyContactInfo = txtEmergencyContactInfo.Text;

            _Member.IsActive = cbIsActive.Checked ? true : false;
        }

        private void _SaveData()
        {
            if (_Member.Save())
            {
                MessageBox.Show("Member Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMemberD.Text = _Member.MemberID.ToString();
                cbIsActive.Checked = _Member.IsActive;  
                lblTitle.Text = "Update Member Info";
                this._Mode = enMode.Update;

                _Member.Mode = clsMember.enMode.Update;
            }

            else
            {
                MessageBox.Show("Member Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _CheckForCorrectData()
        {
            if (cbBeltRank.Text == "None")
            {
                MessageBox.Show("Select the Belt Rank first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
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
            DataBack?.Invoke(this, _Member?.MemberID);
        }

        private void frmAddEditMember_Load(object sender, EventArgs e)
        {
            tpMemberInfo.Enabled = false;
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            tcMember.SelectedTab = tcMember.TabPages["tpMemberInfo"];
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelectedEvent_1(object sender, Person.ctrlPersonCardWithFilter.SelectPersonEventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonInfo.Member && _Mode !=enMode.Update)
            {
                MessageBox.Show("This person has already been registered as a Member in this system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
                tpMemberInfo.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            btnNext.Enabled = true;
            tpMemberInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void txtEmergencyContactInfo_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmergencyContactInfo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmergencyContactInfo, "this field cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmergencyContactInfo, null);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
