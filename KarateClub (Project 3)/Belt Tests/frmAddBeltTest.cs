using Karate_Bussiness;
using KarateClub__Project_3_.Instructors;
using KarateClub__Project_3_.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Belt_Tests
{
    public partial class frmAddBeltTest : Form
    {
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsBeltTest _BeltTest;

        private int? _TestID = null;
        public frmAddBeltTest()
        {
            InitializeComponent();
        }

        public frmAddBeltTest(int? TestID)
        {
            _TestID = TestID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Belt Test";
                this.Text = "Add New Belt Test";
                _BeltTest = new clsBeltTest();
            }
            else
            {
                this.Text = "Update Belt Test";
                lblTitle.Text = "Update Belt Test";
            }
        }

        public void LoadData()
        {
            _BeltTest = clsBeltTest.Find(_TestID);

            if (_BeltTest == null)
            {
                MessageBox.Show("No Member with ID = " + _TestID, "Member Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }
            ctrlInstructorCardWithFilter1.LoadInstructorInfo(_BeltTest.TestedByInstructorID);
            ctrlMemberCardWithFilter1.LoadMemberInfo(_BeltTest.MemberID);


        }

        public void _FillData()
        {
            _BeltTest.RankID = int.Parse(lblBeltRankID.Text);
            _BeltTest.MemberID = ctrlMemberCardWithFilter1.MemberInfo.MemberID;
            _BeltTest.TestedByInstructorID = ctrlInstructorCardWithFilter1.InstructorInfo.InstructorID;
            _BeltTest.Result = rbPassed.Checked ? true : false;
            _BeltTest.Date = dtTestDate.Value;
        }

        private void _SaveData()
        {
            if (_BeltTest.Save())
            {
                MessageBox.Show("Belt Test Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblTestID.Text = _BeltTest.TestID.ToString();
                _BeltTest.PaymentID = clsPayments.Pay(ctrlMemberCardWithFilter1.MemberInfo);
                lblPaymentID.Text = _BeltTest.PaymentID.ToString();
                lblTitle.Text = "Update Instructor Info";
                this._Mode = enMode.Update;
                _BeltTest.Mode = clsBeltTest.enMode.Update;
            }

            else
            {
                MessageBox.Show("Instructor Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckForCorrectData()
        {
            if (!ctrlMemberCardWithFilter1.MemberID.HasValue ||
             !ctrlInstructorCardWithFilter1.InstructorID.HasValue)
            {
                MessageBox.Show("You have to select member and instructor first!", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (!rbPassed.Checked && !rbFalied.Checked)
            {
                errorProvider1.SetError(rbFalied, "You have to put the test result");
                return false;
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckForCorrectData()) return;
            _FillData();
            _SaveData();

        }

        private void ctrlMemberCardWithFilter1_OnMemberSelectedEvent_1(object sender, Member.User_Control.ctrlMemberCardWithFilter.SelectMemberEventArgs e)
        {
            //If the test is passed, the data for the next test is filled out
            if (ctrlMemberCardWithFilter1.MemberInfo.DidPassPreviousTest)
            {
                lblBeltRankID.Text = ctrlMemberCardWithFilter1.MemberInfo.NextBeltRank.RankID.ToString();
                lblFees.Text = ctrlMemberCardWithFilter1.MemberInfo.NextBeltRank.TestFees.ToString();
                lblRankName.Text = ctrlMemberCardWithFilter1.MemberInfo.NextBeltRank.RankName.ToString();
                if (!clsMember.AfterPassTestSaveLastRankID(ctrlMemberCardWithFilter1.MemberInfo.MemberID,
                    ctrlMemberCardWithFilter1.MemberInfo.NextBeltRank.RankID))
                {
                    return;
                }
            }
            // If the test is not passed, the test data itself will be filled out
            else
            {
                lblBeltRankID.Text = ctrlMemberCardWithFilter1.MemberInfo.LastBeltRankInfo.RankID.ToString();
                lblFees.Text = ctrlMemberCardWithFilter1.MemberInfo.LastBeltRankInfo.TestFees.ToString();
                lblRankName.Text = ctrlMemberCardWithFilter1.MemberInfo.LastBeltRankInfo.RankName.ToString();
            }
        }

        private void frmAddBeltTest_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMode.Update) LoadData();
        }
    }
}
