using System;

namespace PersonnummerApp {
    class Program {
        static void Main(string[] args) {
            Console.Write("Skriv in personnummer: ");
            string input = Console.ReadLine();

            if (PersonnummerValidator.IsValid(input)) {
                Console.WriteLine("Giltigt! ✅");
            } else {
                Console.WriteLine("Ogiltigt! ❌");
            }
        }
    }
}