using System;
namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in första talet: ");
            double tal1 = double.Parse(Console.ReadLine());

            Console.Write("Skriv in andra talet: ");
            double tal2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Välj ett räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            
            Console.Write("Ange ditt val (1-4): ");
            int val = int.Parse(Console.ReadLine());

            // Variabel för att lagra resultatet
            double resultat = 0;
            bool giltigtVal = true;

            switch (val)
            {
                case 1:
                    resultat = tal1 + tal2;
                    Console.WriteLine($"Resultatet av addition: {tal1} + {tal2} = {resultat}");
                    break;
                case 2:
                    resultat = tal1 - tal2;
                    Console.WriteLine($"Resultatet av subtraktion: {tal1} - {tal2} = {resultat}");
                    break;
                case 3:
                    resultat = tal1 * tal2;
                    Console.WriteLine($"Resultatet av multiplikation: {tal1} * {tal2} = {resultat}");
                    break;
                case 4:
                    if (tal2 != 0) 
                    {
                        resultat = tal1 / tal2;
                        Console.WriteLine($"Resultatet av division: {tal1} / {tal2} = {resultat}");
                    }
                    else
                    {
                        Console.WriteLine("Fel: Division med noll är inte tillåten.");
                    }
                    break;
                default:
                    giltigtVal = false;
                    Console.WriteLine("Ogiltigt val, vänligen välj ett nummer mellan 1 och 4.");
                    break;
            }
        }
    }
}