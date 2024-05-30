using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsBeltTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? TestID { get; set; }
        public int? MemberID { get; set; }
        public int? RankID { get; set; }
        public bool Result { get; set; }
        public DateTime Date { get; set; }
        public int? TestedByInstructorID { get; set; }
        public int? PaymentID { get; set; }

        public clsMember MemberInfo => clsMember.Find(MemberID);
        public clsInstructor InstructorInfo => clsInstructor.FindByInstructorID(TestedByInstructorID);
        public clsBeltRank BeltRankInfo { get; set; }
        public clsPayments PaymentInfo { get; set; }

        public clsBeltTest()
        {
            this.TestID = null;
            this.MemberID = null;
            this.RankID = null;
            this.Result = true;
            this.Date = DateTime.Now;
            this.TestedByInstructorID = null;
            this.PaymentID = null;

            Mode = enMode.AddNew;
        }

        private clsBeltTest(int? TestID, int? MemberID, int? RankID, bool Result,
            DateTime Date, int? TestedByInstructorID, int? PaymentID)
        {
            this.TestID = TestID;
            this.MemberID = MemberID;
            this.RankID = RankID;
            this.Result = Result;
            this.Date = Date;
            this.TestedByInstructorID = TestedByInstructorID;
            this.PaymentID = PaymentID;

            this.BeltRankInfo = clsBeltRank.Find(RankID);
            this.PaymentInfo = clsPayments.Find(PaymentID);

            Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsBeltTestsData.Add(this.MemberID, this.RankID, this.Result,
                this.Date, this.TestedByInstructorID, this.PaymentID);

            return (this.TestID.HasValue);
        }

        private bool _UpdateTest()
        {
            return clsBeltTestsData.Update(this.TestID, this.MemberID, this.RankID,
                this.Result, this.Date, this.TestedByInstructorID, this.PaymentID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTest();
            }

            return false;
        }

        public static clsBeltTest Find(int? TestID)
        {
            int? MemberID = null;
            int? RankID = null;
            bool Result = true;
            DateTime Date = DateTime.Now;
            int? TestedByInstructorID = null;
            int? PaymentID = null;

            bool IsFound = clsBeltTestsData.GetBeltTestInfoByID(TestID, ref MemberID, ref RankID,
                ref Result, ref Date, ref TestedByInstructorID, ref PaymentID);

            if (IsFound)
            {
                return new clsBeltTest(TestID, MemberID, RankID, Result, Date,
                    TestedByInstructorID, PaymentID);
            }
            else
            {
                return null;
            }
        }

        public static clsBeltTest FindByMemberID(int? MemberID)
        {
            int? TestID = null;
            int? RankID = null;
            bool Result = true;
            DateTime Date = DateTime.Now;
            int? TestedByInstructorID = null;
            int? PaymentID = null;

            bool IsFound = clsBeltTestsData.GetBeltTestInfoByMemberID(MemberID, ref TestID, ref RankID,
                ref Result, ref Date, ref TestedByInstructorID, ref PaymentID);

            if (IsFound)
            {
                return new clsBeltTest(TestID, MemberID, RankID, Result, Date,
                    TestedByInstructorID, PaymentID);
            }
            else
            {
                return null;
            }
        }

        public static bool PassTest(int? RankID , int? MemberID)
        {
            return clsBeltTestsData.PassTest(RankID, MemberID);
        }

        public static DataTable All()
        {
            return clsBeltTestsData.All();
        }

        public static bool HasMemberTakenTest(int? MemberID)
        {
            return clsBeltTestsData.Exists(MemberID);
        }
    }
}
