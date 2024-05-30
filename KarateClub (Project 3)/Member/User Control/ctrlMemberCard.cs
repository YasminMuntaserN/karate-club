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

namespace KarateClub__Project_3_.Member
{
    public partial class ctrlMemberCard : UserControl
    {
        private clsMember _Member;

        private int? _MemberID = null;

        public int? MemberID => _MemberID;

        public clsMember SelectedMemberInfo => _Member;

        public ctrlMemberCard()
        {
            InitializeComponent();
        }

        public void LoadMemberInfo(int? MemberID)
        {
            _Member = clsMember.Find(MemberID);
            if (_Member == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Member with MemberID = " + MemberID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _MemberID = _Member.MemberID;
            _FillPersonInfo();
        }

        public void LoadMemberInfoByPersonID(int? PersonID)
        {
            _Member = clsMember.FindByPersonID(PersonID);
            if (_Member == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Member with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _MemberID = _Member.MemberID;
            _FillPersonInfo();
        }

        private void _FillPersonInfo()
        {
            lblMemberD.Text =_Member.MemberID.ToString();
            lblContactInfo.Text =_Member.EmergencyContactInfo.ToString();
            lblBeltRank.Text = clsBeltRank.getBeltRanksName(_Member.LastBeltRankID);
            lblIsActive.Text = _Member.IsActive ? "Yes" : "No";
            ctrlPersonCard1.LoadPersonInfo(_Member.PersonID);
        }

        public void ResetPersonInfo()
        {
            lblBeltRank.Text = "[????]";
            lblContactInfo.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblMemberD.Text = "[????]";
        }


    }
}
