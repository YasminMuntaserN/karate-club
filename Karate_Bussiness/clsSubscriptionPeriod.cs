using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsSubscriptionPeriod
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? PeriodID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Fees { get; set; }
        public bool IsPaid { get; set; }
        public int? MemberID { get; set; }
        public  clsMember MemberInfo =>clsMember.Find(MemberID);
        public int? PaymentID { get; set; }
        public clsPayments PaymentInfo => clsPayments.Find(PaymentID);

        public clsSubscriptionPeriod()
        {
            Mode = enMode.AddNew;
            PeriodID = null;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            Fees = 0;
            IsPaid = false;
            MemberID = null;
            PaymentID = null;
        }

       private clsSubscriptionPeriod( int? periodID, DateTime startDate, DateTime endDate, decimal fees, bool isPaid, int? memberID, int? paymentID)
        {
            PeriodID = periodID;
            StartDate = startDate;
            EndDate = endDate;
            Fees = fees;
            IsPaid = isPaid;
            MemberID = memberID;
            PaymentID = paymentID;
            Mode = enMode.Update;
        }

        public static clsSubscriptionPeriod FindByPeriodID(int? PeriodID)
        {
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;
            decimal Fees = 0;
            bool IsPaid = false;
            int? MemberID = null;int ?PaymentID = null;

            bool IsFound = clsSubscriptionPeriodsData.GetSubscriptionPeriodByID(PeriodID,ref StartDate,
                ref EndDate, ref Fees, ref IsPaid, ref MemberID, ref PaymentID);

            if (IsFound)
            {
                return new clsSubscriptionPeriod(PeriodID, StartDate,
                 EndDate, Fees, IsPaid, MemberID, PaymentID);
            }
            else
            {
                return null;
            }
        }

        public static clsSubscriptionPeriod FindByMemberID(int? MemberID)
        {
            DateTime StartDate = DateTime.Now, EndDate = DateTime.Now;
            decimal Fees = 0;
            bool IsPaid = false;
            int? PeriodID = null; int? PaymentID = null;

            bool IsFound = clsSubscriptionPeriodsData.GetSubscriptionPeriodByMemberID(MemberID, ref StartDate,
                ref EndDate, ref Fees, ref IsPaid, ref PeriodID, ref PaymentID);

            if (IsFound)
            {
                return new clsSubscriptionPeriod(PeriodID, StartDate,
                 EndDate, Fees, IsPaid, MemberID, PaymentID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewSubscriptionPeriod()
        {
            this.PeriodID = clsSubscriptionPeriodsData.Add(this.StartDate, this.EndDate,this.Fees ,this.IsPaid,
               this.MemberID, this.PaymentID);

            return (this.PeriodID.HasValue);
        }

        private bool _UpdateInstructor()
        {
            return clsSubscriptionPeriodsData.Update(this.PeriodID, this.StartDate, this.EndDate, this.Fees, this.IsPaid,
               this.MemberID, this.PaymentID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubscriptionPeriod())
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

        public static bool Exist(int? PeriodID)
        {
            return clsSubscriptionPeriodsData.Exist(PeriodID);
        }

        public static bool ExistWithMemberIDAndPeriodNotEnd(int? MemberID)
        {
            return clsSubscriptionPeriodsData.ExistWithMemberIDAndPeriodNotEnd(MemberID);
        }

        public static bool ExistByPaymentID(int? PaymentID)
        {
            return clsSubscriptionPeriodsData.ExistWithPaymentID(PaymentID);
        }

        public static bool Delete(int? PeriodID)
        {
            return clsSubscriptionPeriodsData.Delete(PeriodID);
        }

        public static DataTable AllSubscriptionPeriods()
        {
            return clsSubscriptionPeriodsData.All();
        }

        public static DataTable AllSubscriptionPeriods(string MemberName)
        {
            return clsSubscriptionPeriodsData.All(MemberName);
        }

        public static int Count()
        {
            return clsSubscriptionPeriodsData.Count();
        }
    }
}
