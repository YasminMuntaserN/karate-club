using Karate_Bussiness;
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

namespace KarateClub__Project_3_.Member.User_Control
{
    public partial class ctrlMemberCardWithFilter : UserControl
    {
        public ctrlMemberCardWithFilter()
        {
            InitializeComponent();
        }
        public class SelectMemberEventArgs : EventArgs
        {
            public int? MemberID { get; }

            public SelectMemberEventArgs(int? MemberID)
            {
                this.MemberID = MemberID;
            }
        }

        public event EventHandler<SelectMemberEventArgs> OnMemberSelectedEvent;

        public void OnMemberSelected(int? MemberID)
        {
            if (OnMemberSelectedEvent != null)
            {
                OnMemberSelectedEvent(this, new SelectMemberEventArgs(MemberID));
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

        private clsMember _Member;

        private int? _MemberID;
        public clsMember MemberInfo => _Member;
        public int? MemberID => _MemberID;

        public void LoadPersonInfo(int? PersonID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlMemberCard1.LoadMemberInfoByPersonID(PersonID);
            _Member = ctrlMemberCard1.SelectedMemberInfo;
            _MemberID = _Member.MemberID;
            if (OnMemberSelectedEvent != null)
                OnMemberSelected(_Member.MemberID);
        }

        public void LoadMemberInfo(int? MemberID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = MemberID.ToString();
            ctrlMemberCard1.LoadMemberInfo(MemberID);
            _Member = ctrlMemberCard1.SelectedMemberInfo;
            _MemberID = _Member.MemberID;
            if (OnMemberSelectedEvent != null)
                OnMemberSelected(_Member.MemberID);
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
                    if (!clsMember.ExistByPersonID(int.Parse(txtFilterValue.Text)))
                    {
                        MessageBox.Show("This Member is not present in the system. To add a new person, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "Member ID":
                    if (!clsMember.Exist(int.Parse(txtFilterValue.Text)))
                    {
                        MessageBox.Show("This Member is not present in the system. To add a new person, click on the add icon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    LoadMemberInfo(int.Parse(txtFilterValue.Text));
                    break;

                default:
                    break;
            }

            _Member = ctrlMemberCard1.SelectedMemberInfo;
            _MemberID = _Member.MemberID;
        }

        private void DataBackEvent(object sender, int? MemberID)
        {
            cbFindBy.SelectedIndex = 1;
            txtFilterValue.Text = MemberID.ToString();
            LoadMemberInfo(MemberID);
        }

        private void btnFind_Click(object sender, EventArgs e) => FindNow();

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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditMember frmAddEditMember = new frmAddEditMember();
            frmAddEditMember.DataBack += DataBackEvent;
            frmAddEditMember.ShowDialog();
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
    }
}
