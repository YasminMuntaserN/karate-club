using Karate_DataAccsess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Bussiness
{
    public class clsBeltRank
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? RankID { get; set; }
        public string RankName { get; set; }
        public decimal TestFees { get; set; }

        public clsBeltRank()
        {
            this.RankID = null;
            this.RankName = string.Empty;
            this.TestFees = -1M;

            Mode = enMode.AddNew;
        }

        private clsBeltRank(int? RankID, string RankName, decimal TestFees)
        {
            this.RankID = RankID;
            this.RankName = RankName;
            this.TestFees = TestFees;

            Mode = enMode.Update;
        }

        public static clsBeltRank Find(int? RankID)
        {
            string RankName = "";
            decimal TestFees = 0;

            if (clsBeltRankData.GetRankInfoByID(RankID, ref RankName, ref TestFees))
            {
                return new clsBeltRank(RankID, RankName, TestFees);
            }
            else
            {
                return null;
            }
        }

        public static clsBeltRank Find(string RankName)
        {
            int? RankID = null;
            decimal TestFees = 0;

            if (clsBeltRankData.GetRankInfoByName(RankName, ref RankID, ref TestFees))
            {
                return new clsBeltRank(RankID, RankName, TestFees);
            }
            else
            {
                return null;
            }
        }

        public static string getBeltRanksName(int? RankID)
        {
            clsBeltRank BeltRank = Find(RankID);
            return (BeltRank == null) ? "" : BeltRank.RankName;

        }

        public bool Update()
        {
            return clsBeltRankData.UpdateRank(this.RankID, this.RankName, this.TestFees);
        }

        public static DataTable All()
        {
            return clsBeltRankData.All();
        }

        public static clsBeltRank NextBeltRankInfo(int? RankID)
        {
            int? NextBeltRankID = clsBeltRankData.GetNextBeltRankID(RankID);

            if (NextBeltRankID.HasValue)
            {
                return clsBeltRank.Find(NextBeltRankID);
            }
            else
            {
                return null;
            }
        }

        public static int Count()
        {
           return  clsBeltRankData.Count();    
        }

    }
}
