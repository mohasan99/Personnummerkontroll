using System;

namespace PersonnummerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gör konsolen lite snyggare
            Console.WriteLine("========================================");
            Console.WriteLine("    SVENSK PERSONNUMMERKONTROLL");
            Console.WriteLine("========================================");
            
            while (true) // Loop så ni kan testa flera nummer efter varandra test
            {
                Console.WriteLine("\nSkriv in ett personnummer (eller 'avsluta' för att stänga):");
                Console.Write("> ");
                string input = Console.ReadLine();

                // Möjlighet att stänga programmet
                if (input.ToLower() == "avsluta") break;

                // Här anropar vi logiken som ni skapade i Validator-klassen
                bool isValid = PersonnummerValidator.IsValid(input);

                if (isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Resultat: Giltigt personnummer! ✅");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Resultat: Ogiltigt personnummer. ❌");
                }

                Console.ResetColor(); // Återställ färgen till normalt
            }
        }
    }
}