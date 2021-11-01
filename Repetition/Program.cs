using System;
using System.Collections.Generic;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             for (int i = 0; i < 10; i++)
             {
                 if (i%2 != 0) // Inte delbart med 0 alltså ojämt tal
                 {
                     continue; // Innebär att den hoppar över varje ojämnt tal alltså fortsätter förbi
                     // Hade vi skrivit break här hade loopen avslutats efter en runda. 
                 }
                 Console.WriteLine(i);
             }



             // 11. Be användaren skriva in en textsträng.
             // Konvertera textsträngen till en lista av chars.
             // Använd en loop för att se om textsträngen är en palindrom. (Samma ord baklänges)

             Console.Write("Skriv in en textsträng:");
             string userString = Console.ReadLine();

             List<char> userStringList = new List<char>();
             userStringList.AddRange(userString);

             foreach (char item in userStringList)
             {
                 Console.WriteLine(item);
             }

             for (int i = 0; i < userStringList.Count; i++) // Jämför bokstav för bokstav baifrån och framifrån för att se om de är lika. Hade bara behövt jämföra halva ordet egentligen. (int i = 0; i < userStringList.Count/2; i++)
             {
                 if (userStringList[i] == userStringList[userStringList.Count - (i + 1)]) 
                 {
                     Console.WriteLine("Samma bokastavsindex");
                 }
                 else
                 {
                     Console.WriteLine("Inget Palindrom");
                 }
             }
             


            Dictionary<int, string> weekdays = new Dictionary<int, string>() { { 1, "Måndag" }, { 2, "Tisdag" }, { 3, "Onsdag" }, { 4, "Torsdag" }, { 5, "Fredag" }, { 6, "Lördag" }, { 7, "Söndag" } };

            // Be användaren skriva in ett tal 1-7
            Console.WriteLine("Skriv in ett tal: [1-7]");

            // Konvertera, och lagra, inmatningen
            int input = Convert.ToInt32(Console.ReadLine());

            // Lagra rätt veckodag i en variabel
            string day = weekdays[input];

            // Skriv ut veckodagen
            Console.WriteLine(day);
            

            static void AreaCircle(double radius)
            {
                double pi = 3.14;
                double area = 2 * pi * radius;
                double circumference = pi * radius * radius;

                Console.WriteLine("Circumference of the circle is {0}", circumference);
                Console.WriteLine("Area of the circle is {0}", area);
            }
            AreaCircle(20);
             */
            Console.WriteLine("Alternativ 1: Remove med for-loop");
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            string name = "Handelsakademin";
            List<char> nameList = new List<char>();
            nameList.AddRange(name);

            for (int i = 0; i < vowels.Count; i++)
            {
                for (int j = 0; j <= nameList.Count; j++)
                {
                    if (nameList.Contains(vowels[i]))
                    {
                        nameList.Remove(vowels[i]); // Remove tar bort första förekomsten den hittar. Vi behöver därför loopa flera gånger för att hitta varje element som matchar.
                    }
                }
            }

            foreach (var item in nameList)
            {
                Console.Write(item);
            }
            Console.WriteLine();


        }

    }
}