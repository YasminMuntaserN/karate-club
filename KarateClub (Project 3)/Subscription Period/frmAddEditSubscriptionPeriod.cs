using Karate_Bussiness;
using KarateClub__Project_3_.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KarateClub__Project_3_.Subscription_Period
{
    public partial class frmAddEditSubscriptionPeriod : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsSubscriptionPeriod _SubscriptionPeriod;

        private int? _SubscriptionPeriodID = null;

        public frmAddEditSubscriptionPeriod()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;  
        }

        public frmAddEditSubscriptionPeriod(int? SubscriptionPeriodID)
        {
            _SubscriptionPeriodID = SubscriptionPeriodID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Subscription Period";
                this.Text = "Add New Subscription Period";
                _SubscriptionPeriod = new clsSubscriptionPeriod();
            }
            else
            {
                this.Text = "Update Subscription Period";
                lblTitle.Text = "Update Subscription Period";
            }
        }

        public void LoadData()
        {
            _SubscriptionPeriod = clsSubscriptionPeriod.FindByPeriodID(_SubscriptionPeriodID);

            if (_SubscriptionPeriodID == null)
            {
                MessageBox.Show("No Subscription Period with ID = " + _SubscriptionPeriodID, "Subscription Period Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            lblMemberID.Text = _SubscriptionPeriod.MemberID.ToString();

            ctrlMemberCardWithFilter1.FilterEnabled = false;

            ctrlMemberCardWithFilter1.LoadMemberInfo(_SubscriptionPeriod.MemberInfo.MemberID);

            lblPaymentID.Text = _SubscriptionPeriod.PaymentID.ToString();

            txtFees.Text = _SubscriptionPeriod.Fees.ToString();

            cbIsPaid.Checked = _SubscriptionPeriod.IsPaid;

            dtpStartDate.Value = _SubscriptionPeriod.StartDate;

            dtpEndDate.Value = _SubscriptionPeriod.EndDate;

            btnNext.Enabled = true;
            tpSubscriptionPeriodInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void _FillData()
        {
            _SubscriptionPeriod.MemberID = ctrlMemberCardWithFilter1.MemberInfo.MemberID;
            _SubscriptionPeriod.IsPaid = cbIsPaid.Checked;
            if (!clsPayments.SetActiveMemberAfterPayment(_SubscriptionPeriod))
            {
                MessageBox.Show("Error in Payment !!");
            }
            _SubscriptionPeriod.StartDate = dtpStartDate.Value;
            _SubscriptionPeriod.EndDate = dtpEndDate.Value;
            _SubscriptionPeriod.Fees =decimal.Parse(txtFees.Text); 
            _SubscriptionPeriod.PaymentID = clsPayments.Pay(ctrlMemberCardWithFilter1.MemberInfo);
        }

        private void _SaveData()
        {
            if (_SubscriptionPeriod.Save())
            {
                MessageBox.Show("Subscription Period Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPeriodID.Text = _SubscriptionPeriod.PeriodID.ToString();
                lblPaymentID.Text = _SubscriptionPeriod.PaymentID.ToString();
                lblMemberID.Text = _SubscriptionPeriod.MemberID.ToString();
                lblTitle.Text = "Update Subscription Period Info";
                this._Mode = enMode.Update;
                _SubscriptionPeriod.Mode = clsSubscriptionPeriod.enMode.Update;
            }

            else
            {
                MessageBox.Show("Subscription Period Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                MessageBox.Show("The end date should be after the start date!", "Date Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillData();
            _SaveData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcMember.SelectedTab = tcMember.TabPages["tpSubscriptionPeriodInfo"];
        }

        private void ctrlMemberCardWithFilter1_OnMemberSelectedEvent(object sender, Member.User_Control.ctrlMemberCardWithFilter.SelectMemberEventArgs e)
        {
            //بدنا نحط شرط نتاكد من خلالو انو هل هاد الشخص عندو فترة اشتراك من قبل اذا كان عندو لازم يخلص وقت الاشتراك قبل اضافة اشترالك جديد
            if (ctrlMemberCardWithFilter1.MemberInfo.HasMemberSubscriptionPeriod && _Mode!=enMode.Update)
            {
                    MessageBox.Show("This Member has already been registered with Subscription Period in this system and the last Period Not End", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNext.Enabled = false;
                    tpSubscriptionPeriodInfo.Enabled = false;
                    btnSave.Enabled = false;
                    return;
            }
            btnNext.Enabled = true;
            tpSubscriptionPeriodInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void frmAddEditSubscriptionPeriod_Load(object sender, EventArgs e)
        {
            tpSubscriptionPeriodInfo.Enabled = false;
            _ResetTitles();
            if (_Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, null);
            }
        }
    }
}
