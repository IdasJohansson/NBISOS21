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
           */

          
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

            for (int i = 0; i < userStringList.Count; i++)
            {
                if (userStringList[i] == userStringList[userStringList.Count - (i + 1)]) // Jämför bokstav för bokstav baifrån och framifrån för att se om de är lika. Hade bara behövt jämföra halva ordet egentligen. 
                {
                    Console.WriteLine("Samma bokastavsindex");
                }
                else
                {
                    Console.WriteLine("Inget Palindrom");
                }
            }
        

        }
    }
}
