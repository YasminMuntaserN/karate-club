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
    public partial class ctrlInstructorCard : UserControl
    {
        private clsInstructor _Instructor;

        private int? _InstructorID = null;

        public int? InstructorID => _InstructorID;

        public clsInstructor SelectedInstructorInfo => _Instructor; 

        public ctrlInstructorCard()
        {
            InitializeComponent();
        }

        public void LoadInstructorInfo(int? InstructorID)
        {
            _Instructor = clsInstructor.FindByInstructorID(InstructorID);
            if (_Instructor == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Instructor with InstructorID = " + InstructorID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _InstructorID = _Instructor.InstructorID;
            _FillPersonInfo();
        }

        public void LoadInstructorInfoByPersonID(int? PersonID)
        {
            _Instructor = clsInstructor.FindByPersonId(PersonID);
            if (_Instructor == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Instructor with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _InstructorID = _Instructor.InstructorID;
            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            lblInstructorID.Text = _Instructor.InstructorID.ToString();
            lblqul.Text = _Instructor.Qualification;
            ctrlPersonCard1.LoadPersonInfo(_Instructor.PersonID);
        }

        public void ResetPersonInfo()
        {
            lblInstructorID.Text = "[????]";
            lblqul.Text = "[????]";
        }
    }
}
