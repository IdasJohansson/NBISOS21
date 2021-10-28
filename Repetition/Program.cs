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
             */


            static void WelcomeApp()
            {
                Console.WriteLine("Välkommen, skriv in ditt namn!");

            }

            static void Main(string[] args)
            {
                bool Finish = true;
                double result;
                char Count;

                List<string> Historik = new List<string>();

                WelcomeApp();

                string name = Console.ReadLine();

                Console.WriteLine("Hej " + name);

                while (Finish)

                {
                    Console.WriteLine("Skriv in ett tal");
                    int tal1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Skriv ett till tal");
                    int tal2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Välj operator: ");
                    Count = Convert.ToChar(Console.ReadLine());

                    if (Count == '+')
                    {
                        result = tal1 + tal2;
                        Console.WriteLine("{0}{1}{2}", tal1, tal2, result);
                        Historik.Add(string.Format("{0} + {1} = {2}", tal1, tal2, result));
                    }
                    else if (Count == '*')
                    {
                        result = tal1 * tal2;
                        Console.WriteLine(result);
                        Historik.Add(string.Format("{0} * {1} = {2}", tal1, tal2, result));
                    }
                    else if (Count == '-')
                    {
                        result = tal1 - tal2;
                        Console.WriteLine(result);
                        Historik.Add(string.Format("{0} - {1} = {2}", tal1, tal2, result));

                    }
                    else if (Count == '/')
                    {
                        result = tal1 / tal2;
                        Console.WriteLine(result);
                        Historik.Add(string.Format("{0} / {1} = {2}", tal1, tal2, result));
                    }


                    Console.WriteLine(" Vill du köra om? [JA(/NEJ] ");
                    string svar = Console.ReadLine();


                    if (svar == "NEJ")
                    {
                        Console.WriteLine("vill du se tidiagre uträknigar? [JA / NEJ]");
                        string choice = Console.ReadLine();

                        if (choice == "JA")
                        {
                            foreach (string item in Historik)
                            {
                                Console.WriteLine("Uträkning är: {0}", item);
                            }
                        }
                        else
                        {
                            Finish = false;
                        }
                    }
                }
            }
        }
    }
}