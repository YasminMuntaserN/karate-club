using Karate_Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarateClub__Project_3_.Global_Classes
{
    public class clsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

        public static int ValidateNumbers(string text)
        {
            int Num = -1;
            if (int.TryParse(text, out int Result))
            {
                Num = Result;
            }
            return Num;

        }

    }
}
