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

namespace KarateClub__Project_3_.Instructors
{
    public partial class frmAddEditInstructor : Form
    {
        public delegate void DataBackEventHandler(object sender, int? PersonID);

        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;

        private clsInstructor _Instructor;

        private int? _InstructorID = null;

        public frmAddEditInstructor()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditInstructor(int InstructorID)
        {
            InitializeComponent();
            _InstructorID = InstructorID;
            _Mode = enMode.Update;
        }

        private void _ResetTitles()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Instructor";
                this.Text = "Add New Instructor";
                _Instructor = new clsInstructor();
            }
            else
            {
                this.Text = "Update Instructor";
                lblTitle.Text = "Update Instructor";
            }
        }

        public void LoadData()
        {
            _Instructor = clsInstructor.FindByInstructorID(_InstructorID);

            if (_Instructor == null)
            {
                MessageBox.Show("No Instructor with ID = " + _InstructorID, "Member Not Found",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();

                return;
            }

            lblInstructorID.Text = _Instructor.InstructorID.ToString();

            ctrlPersonCardWithFilter1.FilterEnabled = false;

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Instructor.PersonID);

            txtQualification.Text = _Instructor.Qualification;

        }

        private void _SaveData()
        {
            if (_Instructor.Save())
            {
                MessageBox.Show("Instructor Data Saved Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInstructorID.Text = _Instructor.InstructorID.ToString();
                lblTitle.Text = "Update Instructor Info";
                this._Mode = enMode.Update;

                _Instructor.Mode = clsInstructor.enMode.Update;
            }

            else
            {
                MessageBox.Show("Instructor Saved Failed.", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Instructor.PersonID = ctrlPersonCardWithFilter1.PersonInfo.PersonID;
            _Instructor.Qualification = txtQualification.Text;
            _SaveData();
            DataBack?.Invoke(this, _Instructor?.InstructorID);
        }

        private void frmAddEditInstructor_Load(object sender, EventArgs e)
        {
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
    }
}
