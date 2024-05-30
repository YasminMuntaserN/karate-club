using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsMember : clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? MemberID { get; set; }
        public string EmergencyContactInfo { get; set; }
        public int? LastBeltRankID { get; set; }
        public bool IsActive { get; set; }
        public clsBeltRank LastBeltRankInfo { get; set; }

        public bool HasMemberSubscriptionPeriod => clsSubscriptionPeriod.ExistWithMemberIDAndPeriodNotEnd(MemberID);

        public bool IsPaid => clsPayments.Pay(this) !=-1;

        public clsBeltRank NextBeltRank => clsBeltRank.NextBeltRankInfo(LastBeltRankID);

        public bool DidPassPreviousTest => clsBeltTest.PassTest(LastBeltRankID, MemberID);

        public clsMember()
        {
            this.MemberID = null;
            this.EmergencyContactInfo = string.Empty;
            this.LastBeltRankID = null;
            this.IsActive = false;

            Mode = enMode.AddNew;
        }

        private clsMember(int? PersonID, string Name, string Address,
            string Phone, string Email, DateTime DateOfBirth, short Gender,
            string ImagePath, int? MemberID, string EmergencyContactInfo,
            int? LastBeltRankID, bool IsActive)
        {
            base.PersonID = PersonID;
            base.Name = Name;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.DateOfBirth = DateOfBirth;
            base.Gender = Gender;
            base.ImagePath = ImagePath;

            this.MemberID = MemberID;
            this.EmergencyContactInfo = EmergencyContactInfo;
            this.LastBeltRankID = LastBeltRankID;
            this.IsActive = IsActive;

            this.LastBeltRankInfo = clsBeltRank.Find(LastBeltRankID);

            Mode = enMode.Update;
        }

        public static clsMember Find(int? MemberID)
        {
            string EmergencyContactInfo = ""; int? LastBeltRankID = null;
            int? PersonID = null; bool IsActive = false;

            if (clsMembersData.GetMemberInfoByID(MemberID, ref PersonID, ref EmergencyContactInfo,
                ref LastBeltRankID, ref IsActive))
            {
                clsPeople Person = clsPeople.Find(PersonID);

                return new clsMember(PersonID, Person.Name, Person.Address, Person.Phone, Person.Email
                    , Person.DateOfBirth, Person.Gender, Person.ImagePath, MemberID, EmergencyContactInfo
                    , LastBeltRankID, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsMember FindByPersonID(int? PersonID)
        {
            string EmergencyContactInfo = ""; int? LastBeltRankID = null;
            int? MemberID = null; bool IsActive = false;

            if (clsMembersData.GetMemberInfoByPersonID(PersonID, ref MemberID, ref EmergencyContactInfo,
                ref LastBeltRankID, ref IsActive))
            {
                clsPeople Person = clsPeople.Find(PersonID);

                return new clsMember(PersonID, Person.Name, Person.Address, Person.Phone, Person.Email
                    , Person.DateOfBirth, Person.Gender, Person.ImagePath, MemberID, EmergencyContactInfo
                    , LastBeltRankID, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsMember FindByMemberName(string Name)
        {
            clsPeople Person = clsPeople.Find(Name);
            if(Person != null)
            {
                return FindByPersonID(Person.PersonID);
            }
            return null;

        }

        private bool _AddNewMember()
        {
            this.MemberID = clsMembersData.Add(PersonID, EmergencyContactInfo, LastBeltRankID, IsActive);

            return (MemberID.HasValue);

        }

        private bool _UpdateMember()
        {
            return clsMembersData.Update(MemberID, PersonID, EmergencyContactInfo, LastBeltRankID, IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMember())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateMember();
            }
            return false;
        }

        public static bool Exist(int? MemberID)
        {
            return clsMembersData.Exist(MemberID);
        }

        public static bool ExistByPersonID(int? PersonID)
        {
            return clsMembersData.ExistWithPersonID(PersonID);
        }

        public static bool Delete(int? MemberID)
        {
            return clsMembersData.Delete(MemberID);
        }

        public static DataTable AllMembers()
        {
            return clsMembersData.All();
        }

        public static bool AfterPassTestSaveLastRankID(int? MemberID, int? NewBeltRankID)
        {
            return clsMembersData.UpdateRankID(MemberID, NewBeltRankID);
        }

        public static DataTable AllTests(int? MemberID)
        {
            return clsBeltTestsData.All(clsMember.Find(MemberID).Name);
        }

        public static DataTable AllPayments(int? MemberID)
        {
            return clsPaymentsData.All(clsMember.Find(MemberID).Name);
        }

        public static int Count()
        {
            return clsMembersData.Count();
        }

    }
}
