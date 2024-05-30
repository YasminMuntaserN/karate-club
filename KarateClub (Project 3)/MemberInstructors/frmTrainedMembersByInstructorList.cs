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

namespace KarateClub__Project_3_.MemberInstructors
{
    public partial class frmTrainedMembersByInstructorList : Form
    {
        private int? _InstructorID;
        public frmTrainedMembersByInstructorList(int? InstructorID)
        {
            _InstructorID = InstructorID;
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowMemderInstractorDetails_Load(object sender, EventArgs e)
        {
            ctrlInstructorCard1.LoadInstructorInfo(_InstructorID);
            dgvAllMembers.DataSource = clsMemberInstructor.GetTrainedMembersByInstructor(_InstructorID);
            lblRecordsCount.Text= dgvAllMembers.RowCount.ToString();    
        }
    }
}
