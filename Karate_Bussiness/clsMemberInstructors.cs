using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsMemberInstructor
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? MemberInstructorID { get; set; }
        public int? MemberID { get; set; }
        public int? InstructorID { get; set; }
        public DateTime AssignDate { get; set; }

        public clsMember MemberInfo { get; set; }
        public clsInstructor InstructorInfo { get; set; }

        public clsMemberInstructor()
        {
            this.MemberInstructorID = null;
            this.MemberID = null;
            this.InstructorID = null;
            this.AssignDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }

        private clsMemberInstructor(int? MemberInstructorID, int? MemberID,
            int? InstructorID, DateTime AssignDate)
        {
            this.MemberInstructorID = MemberInstructorID;
            this.MemberID = MemberID;
            this.InstructorID = InstructorID;
            this.AssignDate = AssignDate;

            this.MemberInfo = clsMember.Find(MemberID);
            this.InstructorInfo = clsInstructor.FindByInstructorID(InstructorID);

            this.Mode = enMode.Update;
        }

        private bool _AddNewMemberInstructor()
        {
            this.MemberInstructorID = clsMemberInstructorsData.AddNewMemberInstructor
                (this.MemberID, this.InstructorID, this.AssignDate);

            return (this.MemberInstructorID.HasValue);
        }

        private bool _UpdateMemberInstructor()
        {
            return clsMemberInstructorsData.UpdateMemberInstructor
                (this.MemberInstructorID, this.MemberID, this.InstructorID, this.AssignDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMemberInstructor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateMemberInstructor();
            }

            return false;
        }

        public static clsMemberInstructor Find(int? MemberInstructorID)
        {
            int? MemberID = null;
            int? InstructorID = null;
            DateTime AssignDate = DateTime.Now;

            bool IsFound = clsMemberInstructorsData.GetMemberInstructorInfoByID
                (MemberInstructorID, ref MemberID, ref InstructorID, ref AssignDate);

            if (IsFound)
            {
                return new clsMemberInstructor(MemberInstructorID, MemberID, InstructorID, AssignDate);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteMemberInstructor(int? MemberInstructorID)
        {
            return clsMemberInstructorsData.DeleteMemberInstructor(MemberInstructorID);
        }

        public static bool DoesMemberInstructorExist(int? MemberInstructorID)
        {
            return clsMemberInstructorsData.Exist(MemberInstructorID);
        }

        public static bool DoesMemberTrainByInstructor(int? MemberID, int? InstructorID)
        {
            return clsMemberInstructorsData.Exist(MemberID , InstructorID);
        }
        public static DataTable GetAllMemberInstructors()
        {
            return clsMemberInstructorsData.All();
        }

        public static DataTable GetTrainedMembersByInstructor(int? InstructorID)
        {
            return clsMemberInstructorsData.GetTrainedMembersByInstructor(InstructorID);
        }


    }
}
