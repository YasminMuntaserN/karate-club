using Karate_Bussiness;
using KarateClub__Project_3_.Global_Classes;
using KarateClub__Project_3_.Person;
using KarateClub__Project_3_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace KarateClub__Project_3_.MemberInstructors
{
    public partial class frmAddEditMemberInstructors : Form
    {
        public frmAddEditMemberInstructors()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditMemberInstructors(int MemberInstructorID)
        {
            _MemberInstructorID = MemberInstructorID;
            InitializeComponent();
            _Mode = enMode.Update;
        }

        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsMemberInstructor _MemberInstructor;

        private int? _MemberInstructorID = null;

        private void _ResetTitles()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    lblTitle.Text = "Add New Member_Instructor";
                    this.Text = "Add New Member_Instructor";
                    _MemberInstructor = new clsMemberInstructor();
                    break;

                case enMode.Update:
                    this.Text = "Update Member_Instructor";
                    lblTitle.Text = "Update Member_Instructor";
                    break;
            }
        }

        public void LoadData()
        {
            _MemberInstructor = clsMemberInstructor.Find(_MemberInstructorID);

            if (_MemberInstructorID == null)
            {
                MessageBox.Show("No Member_Instructors with ID = " + _MemberInstructorID, "Member_Instructor Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            ctrlInstructorCardWithFilter1.LoadInstructorInfo(_MemberInstructor.InstructorID);
            ctrlMemberCardWithFilter1.LoadMemberInfo(_MemberInstructor.MemberID);

            lblMemberInstructorsID.Text = _MemberInstructor.MemberInstructorID.ToString();

            dtpDate.Value = _MemberInstructor.AssignDate;

        }

        private void _FillData()
        {
            _MemberInstructor.MemberID = ctrlMemberCardWithFilter1.MemberID;

            _MemberInstructor.InstructorID = ctrlInstructorCardWithFilter1.InstructorID;

            _MemberInstructor.AssignDate = dtpDate.Value;

        }

        private void _SaveData()
        {
            if (_MemberInstructor.Save())
            {
                MessageBox.Show("Member_Instructor Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblMemberInstructorsID.Text = _MemberInstructor.MemberInstructorID.ToString();
                lblTitle.Text = "Update Member_Instructor Info";
                this._Mode = enMode.Update;

                _MemberInstructor.Mode = clsMemberInstructor.enMode.Update;
            }

            else
            {
                MessageBox.Show("Member_Instructor Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _CheckForCorrectData()
        {
            if (!ctrlMemberCardWithFilter1.MemberID.HasValue ||
             !ctrlInstructorCardWithFilter1.InstructorID.HasValue)
            {
                MessageBox.Show("You have to select member and instructor first!", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (clsMemberInstructor.DoesMemberTrainByInstructor(
                ctrlMemberCardWithFilter1.MemberID, ctrlInstructorCardWithFilter1.InstructorID) && _Mode != enMode.Update)
            {
                MessageBox.Show("This Instructor has trained this member before!", "Error",
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

        private void frmAddEditMemberInstructors_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_Mode == enMode.Update) LoadData();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_CheckForCorrectData()) return;
            _FillData();
            _SaveData();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlInstructorCardWithFilter1.InstructorID == null)
            {
                MessageBox.Show("You must select Instructor Before !");
                return;
            }
            frmTrainedMembersByInstructorList frm = new frmTrainedMembersByInstructorList(ctrlInstructorCardWithFilter1.InstructorID);
            frm.ShowDialog();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
