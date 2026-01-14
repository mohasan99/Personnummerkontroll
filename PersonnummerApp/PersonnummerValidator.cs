using System;
using System.Linq;

namespace PersonnummerApp
{
    public static class PersonnummerValidator
    {
        public static bool IsValid(string pnr)
        {
            string cleanPnr = new string(pnr.Where(char.IsDigit).ToArray());

            if (cleanPnr.Length == 12) 
            {
                cleanPnr = cleanPnr.Substring(2);
            }

            if (cleanPnr.Length != 10) return false;

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int digit = int.Parse(cleanPnr[i].ToString());

                if (i % 2 == 0)
                {
                    digit *= 2;
                    if (digit > 9) digit -= 9; 
                }

                sum += digit;
            }

            return sum % 10 == 0;
        }
    }
}