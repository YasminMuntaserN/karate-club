using Karate_Bussiness;
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

namespace KarateClub__Project_3_.Person
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPeople _Person;

        private int? _PersonID = null;

        public int? PersonID => _PersonID;
        public clsPeople SelectedPersonInfo => _Person;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int? PersonID)
        {
            _Person = clsPeople.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = _Person.PersonID;
            _FillPersonInfo();
        }

        public void LoadPersonInfo(string Name)
        {
            _Person = clsPeople.Find(Name);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with Name = " + Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = _Person.PersonID;
            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            lblPersonD.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.Name;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblAddress.Text = _Person.Address;
            if (_Person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }
            else
            {
                pbPersonImage.Image = (_Person.Gender == 0) ? Resources.man : Resources.woman;
            }

        }

        public void ResetPersonInfo()
        {
            _PersonID = null;
            _Person = null;
            lblPersonD.Text = "[????]";
            lblName.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.user;
            llEditPersonInfo.Enabled = false;

        }

        public void RefreshEditScreen(object sender, int? PersonID) => LoadPersonInfo(PersonID);

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.DataBack += RefreshEditScreen;
            frm.ShowDialog();
            if (_Person == null)
            {
                MessageBox.Show("You Must select Person before");
                return;
            }
            _FillPersonInfo();
        }

    }
}
