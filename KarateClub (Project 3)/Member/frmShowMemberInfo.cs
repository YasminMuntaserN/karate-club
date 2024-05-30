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
    public partial class frmShowMemberInfo : Form
    {
        public frmShowMemberInfo(int MemberID)
        {
            InitializeComponent();
            ctrlMemberCard1.LoadMemberInfo(MemberID);
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
