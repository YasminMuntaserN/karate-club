using Karate_Bussiness;
using KarateClub__Project_3_.Member;
using KarateClub__Project_3_.Person;
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
    public partial class ctrlInstructorCardWithFilter : UserControl
    {
        public ctrlInstructorCardWithFilter()
        {
            InitializeComponent();
        }
        public class SelectInstructorEventArgs : EventArgs
        {
            public int? InstructorID { get; }

            public SelectInstructorEventArgs(int? InstructorID)
            {
                this.InstructorID = InstructorID;
            }
        }

        public event EventHandler<SelectInstructorEventArgs> OnInstructorSelectedEvent;

        public void OnInstructorSelected(int? MemberID)
        {
            if (OnInstructorSelectedEvent != null)
            {
                OnInstructorSelectedEvent(this, new SelectInstructorEventArgs(MemberID));
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get => _FilterEnabled;

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        private clsInstructor _Instructor;

        private int? _InstructorID;

        public clsInstructor InstructorInfo => _Instructor;

        public int? InstructorID => _InstructorID;

        public void LoadInstructorInfo(int? InstructorID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = InstructorID.ToString();
            ctrlInstructorCard1.LoadInstructorInfo(InstructorID);
            _Instructor = ctrlInstructorCard1.SelectedInstructorInfo;
            _InstructorID = _Instructor.InstructorID;
            if (OnInstructorSelectedEvent != null)
                OnInstructorSelected(ctrlInstructorCard1?.InstructorID);
        }

        public void LoadPersonInfo(int? PersonID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlInstructorCard1.LoadInstructorInfoByPersonID(PersonID);
            _Instructor = ctrlInstructorCard1.SelectedInstructorInfo;
            if (_Instructor != null)
            {
                _InstructorID = _Instructor.InstructorID;
            }
            if (OnInstructorSelectedEvent != null)
                OnInstructorSelected(ctrlInstructorCard1?.InstructorID);
        }

        private void FindNow()
        {
            if (!(cbFindBy.SelectedIndex > -1))
            {
                errorProvider1.SetError(cbFindBy, "You must choose how you want to search");
                return;
            }
            switch (cbFindBy.Text.Trim())
            {
                case "Person ID":
                    if (!clsInstructor.ExistByPersonID(int.Parse(txtFilterValue.Text)))
                    {
                        MessageBox.Show("This Instructor is not present in the system. To add a new person, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "Instructor ID":
                    if (!clsInstructor.Exist(int.Parse(txtFilterValue.Text)))
                    {
                        MessageBox.Show("This Instructor is not present in the system. To add a new person, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LoadInstructorInfo(int.Parse(txtFilterValue.Text));
                    break;

                default:
                    break;
            }

            _Instructor = ctrlInstructorCard1.SelectedInstructorInfo;
            if (_Instructor != null)
            {
                _InstructorID = _Instructor.InstructorID;
            }

        }

        private void btnFind_Click(object sender, EventArgs e) => FindNow();

        private void DataBackEvent(object sender, int? InstructorID)
        {
            cbFindBy.SelectedIndex = 2;
            txtFilterValue.Text = InstructorID.ToString();
            LoadInstructorInfo(InstructorID);
        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFindBy.Text == "None")
            {
                txtFilterValue.Visible = false;
            }
            else
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
            //this will allow only digits if person id is selected
            if (cbFindBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditInstructor frmAddEditInstructor = new frmAddEditInstructor();
            frmAddEditInstructor.DataBack += DataBackEvent;
            frmAddEditInstructor.ShowDialog();
            _Instructor = ctrlInstructorCard1.SelectedInstructorInfo;
        }
    }
}
