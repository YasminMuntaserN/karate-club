using KarateClub__Project_3_.Belt_Tests;
using KarateClub__Project_3_.Instructors;
using KarateClub__Project_3_.Log_in;
using KarateClub__Project_3_.Member;
using KarateClub__Project_3_.MemberInstructors;
using KarateClub__Project_3_.Person;
using KarateClub__Project_3_.Subscription_Period;
using KarateClub__Project_3_.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
