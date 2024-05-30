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
    public partial class frmShowInstructorInfo : Form
    {
        public frmShowInstructorInfo(int? InstructorID)
        {
            InitializeComponent();
            ctrlInstructorCard1.LoadInstructorInfo(InstructorID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
