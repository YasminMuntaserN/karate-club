using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsInstructor :clsPeople
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? InstructorID { get; set; }
        public string Qualification { get; set; }

        public clsInstructor()
        {
            this.InstructorID = null;
            this.PersonID = null;
            this.Qualification = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsInstructor(int? PersonID, string Name, string Address,
            string Phone, string Email, DateTime DateOfBirth,
            short Gender, string ImagePath, int? InstructorID,
            string Qualification)
        {
            base.PersonID = PersonID;
            base.Name = Name;
            base.Address = Address;
            base.Phone = Phone;
            base.Email = Email;
            base.DateOfBirth = DateOfBirth;
            base.Gender = Gender;
            base.ImagePath = ImagePath;

            this.InstructorID = InstructorID;
            this.Qualification = Qualification;

            Mode = enMode.Update;
        }

        public static clsInstructor FindByInstructorID(int? InstructorID)
        {
            int? PersonID = null;
            string Qualification = null;

            bool IsFound = clsInstructorsData.GetInstructorInfoByID(InstructorID,
                ref PersonID, ref Qualification);

            if (IsFound)
            {
                clsPeople Person = clsPeople.Find(PersonID);

                if (Person == null)
                {
                    return null;
                }

                return new clsInstructor(Person.PersonID, Person.Name, Person.Address,
                    Person.Phone, Person.Email, Person.DateOfBirth, Person.Gender,
                     Person.ImagePath, InstructorID, Qualification);

            }
            else
            {
                return null;
            }
        }

        public static clsInstructor FindByPersonId(int? PersonID)
        {
            int? InstructorID = null;
            string Qualification = null;

            bool IsFound = clsInstructorsData.GetMemberInfoByPersonID(PersonID,
                ref InstructorID, ref Qualification);

            if (IsFound)
            {
                clsPeople Person = clsPeople.Find(PersonID);

                if (Person == null)
                {
                    return null;
                }

                return new clsInstructor(Person.PersonID, Person.Name, Person.Address,
                    Person.Phone, Person.Email, Person.DateOfBirth, Person.Gender,
                     Person.ImagePath, InstructorID, Qualification);

            }
            else
            {
                return null;
            }
        }

        public static clsInstructor FindByInstructorName(string Name)
        {
            clsPeople Person = clsPeople.Find(Name);
            if (Person != null)
            {
                return FindByPersonId(Person.PersonID);
            }
            return null;

        }

        private bool _AddNewInstructor()
        {
            this.InstructorID = clsInstructorsData.Add(this.PersonID,
                this.Qualification);

            return (this.InstructorID.HasValue);
        }

        private bool _UpdateInstructor()
        {
            return clsInstructorsData.Update(this.InstructorID,
                this.PersonID, this.Qualification);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInstructor())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateInstructor();
            }

            return false;
        }

        public static bool Exist(int? InstructorID)
        {
            return clsInstructorsData.Exist(InstructorID);
        }

        public static bool ExistByPersonID(int? PersonID)
        {
            return clsInstructorsData.ExistWithPersonID(PersonID);
        }

        public static bool DeleteInstructor(int? InstructorID)
        { 
            return clsInstructorsData.Delete(InstructorID);
        }

        public static DataTable AllInstructors()
        {
            return clsInstructorsData.All();
        }

        public static int Count()
        {
            return clsInstructorsData.Count();
        }

    }
}
