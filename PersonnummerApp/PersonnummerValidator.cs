using System;
using System.Linq;

namespace PersonnummerApp
{
    public static class PersonnummerValidator
    {
        public static bool IsValid(string pnr)
        {
            // 1. Tvätta bort allt utom siffror (hanterar bindestreck och plustecken)
            string cleanPnr = new string(pnr.Where(char.IsDigit).ToArray());

            // 2. Hantera 12-siffriga nummer (ta bort seklet för att få 10 siffror)
            if (cleanPnr.Length == 12) 
            {
                cleanPnr = cleanPnr.Substring(2);
            }

            // Kontrollera att vi nu har exakt 10 siffror
            if (cleanPnr.Length != 10) return false;

            // 3. Implementera Luhn-algoritmen
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int digit = int.Parse(cleanPnr[i].ToString());

                // Multiplicera varannan siffra med 2, börja med den första
                if (i % 2 == 0)
                {
                    digit *= 2;
                    // Om produkten är tvåsiffrig, splittra och addera (t.ex. 16 blir 1+6=7)
                    if (digit > 9) digit -= 9; 
                }

                sum += digit;
            }

            // 4. Hela summan ska vara jämnt delbar med 10
            return sum % 10 == 0;
        }
    }
}