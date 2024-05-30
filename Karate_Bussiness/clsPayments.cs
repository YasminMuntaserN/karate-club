using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsPayments
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? PaymentID {  get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int? MemberID { get; set; }

        public clsPayments()
        {
            this.PaymentID = null;
            this.Date = DateTime.Now;   
            this.MemberID = null;
            this.Amount = 0;

            Mode = enMode.AddNew;
        }

        public clsPayments( int? paymentID, decimal amount,DateTime date, int? memberID)
        {
            PaymentID = paymentID;
            Date = date;
            Amount = amount;
            MemberID = memberID;
            Mode = enMode.Update;
        }

        public static clsPayments Find(int? paymentID)
        {
            int? MemberID = null;
            decimal amount = 0;
            DateTime Date = DateTime.Now;

            bool IsFound = clsPaymentsData.GetPaymentInfoByID(paymentID, ref MemberID, ref amount, ref Date);

            if (IsFound)
            {
                return new clsPayments(paymentID, amount, Date, MemberID);

            }
            else
            {
                return null;
            }
        }

        public static clsPayments FindByMemberID(int? MemberID)
        {
            int? paymentID = null;
            decimal amount = 0;
            DateTime Date = DateTime.Now;

            bool IsFound = clsPaymentsData.GetPaymentInfoByMemberID(MemberID, ref paymentID, ref amount, ref Date);

            if (IsFound)
            {
                return new clsPayments(paymentID, amount, Date, MemberID);

            }
            else
            {
                return null;
            }
        }

        private bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentsData.Add(this.MemberID,
                this.Amount, this.Date);

            return (this.PaymentID.HasValue);
        }

        private bool _UpdatePayment()
        {
            return clsPaymentsData.Update(this.PaymentID,this.MemberID,
                this.Amount, this.Date);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePayment();
            }

            return false;
        }

        public static bool ExistByMemberID(int? MemberID)
        {
            return clsPaymentsData.ExistByMemberID(MemberID);
        }

        public static bool ExistByPaymentID(int? PaymentID)
        {
            return clsPaymentsData.Exist(PaymentID);
        }

        public static bool Delete(int? PaymentID)
        {
            return clsPaymentsData.Delete(PaymentID);
        }

        public static DataTable All()
        {
            return clsPaymentsData.All();
        }

        public static int? Pay(clsMember member)
        {
            clsPayments payment = new clsPayments();
            payment.Amount = member.NextBeltRank.TestFees;
            payment.MemberID = member.MemberID;
            payment.Date = DateTime.Now;

            if (payment.Save())
            {
                return payment.PaymentID;
            }else
            {
                return null;    
            }
        }

        public static bool SetActiveMemberAfterPayment(clsSubscriptionPeriod SubscriptionPeriod)
        {
            if (SubscriptionPeriod.IsPaid)
            {
                clsMember Member = clsMember.Find(SubscriptionPeriod.MemberID);
                if (Member.IsPaid && Member != null)
                {
                    if (clsPayments.Pay(Member) != -1)
                    {
                        Member.IsActive = true;
                        if (Member.Save())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;   
        }

    }
}
