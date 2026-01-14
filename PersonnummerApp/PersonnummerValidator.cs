using System;
using System.Linq;

namespace PersonnummerApp {
    public static class PersonnummerValidator {
        public static bool IsValid(string pnr) {
            // Tar bort allt som inte är siffror
            var digits = pnr.Where(char.IsDigit).Select(c => c - '0').ToArray();
            
            // Hantera 12 siffror genom att ta bort seklet (de första två)
            if (digits.Length == 12) digits = digits.Skip(2).ToArray();
            if (digits.Length != 10) return false;

            int sum = 0;
            for (int i = 0; i < 10; i++) {
                int temp = digits[i];
                if (i % 2 == 0) { // Multiplicera varannan siffra med 2
                    temp *= 2;
                    if (temp > 9) temp -= 9; // Siffersumma
                }
                sum += temp;
            }
            return sum % 10 == 0;
        }
    }
}