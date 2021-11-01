using System;
using System.Collections.Generic;

namespace ArraysListor
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //1. Skapa en array som innehåller 3 textsträngar. Skriv ut samtliga värden med hjälp av index.

            string[] firstArray = new string[] { "Ida", "Susanna", "Johansson" };
            Console.WriteLine(firstArray[0]);
            Console.WriteLine(firstArray[1]);
            Console.WriteLine(firstArray[2]);

            //2. Skapa en array som innehåller 3 integers. Skriv ut samtliga värden med hjälp av index.

            int[] secondArray = new int[] { 100, 1000, 10000, };
            Console.WriteLine(secondArray[0]);
            Console.WriteLine(secondArray[1]);
            Console.WriteLine(secondArray[2]);

            //3. Skapa en array som innehåller chars.

            char[] thirdArray = new char[] { 'I', 'D', 'A' };
            Console.Write(thirdArray[0]);
            Console.Write(thirdArray[1]);
            Console.Write(thirdArray[2]);
            Console.WriteLine();
           

            //4. Skapa en array med alla veckodagar. Be användaren skriva in ett tal (1-7). Skriv ut rätt veckodag.

            string[] weekArray = new string[] { "Mon", "Tis", "Ons", "Tors", "Fre", "Lör", "Sön" };
            Console.Write("Välj en veckodag 1-7: ");
            int weekday = Convert.ToInt32(Console.ReadLine());

            if (weekday == 1)
            {
                Console.WriteLine(weekArray[0]);
            }
            else if (weekday == 2)
            {
                Console.WriteLine(weekArray[1]);
            }
            else if (weekday == 3)
            {
                Console.WriteLine(weekArray[2]);
            }
            else if (weekday == 4)
            {
                Console.WriteLine(weekArray[3]);
            }
            else if (weekday == 5)
            {
                Console.WriteLine(weekArray[4]);
            }
            else if (weekday == 6)
            {
                Console.WriteLine(weekArray[5]);
            }
            else
            {
                Console.WriteLine(weekArray[6]);
            }

            //5. Skapa en array med alla månader. Be användaren skriva in ett tal (1-12). Skriv ut rätt månad.
           
            string[] months = new string[]
            {
                "January",
                "February",
                "Mars",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            Console.Write("Enter a number between 1-12: ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine(months[0]);
            }
            else if (month == 2)
            {
                Console.WriteLine(months[1]);
            }
            else if (month == 3)
            {
                Console.WriteLine(months[2]);
            }
            else if (month == 4)
            {
                Console.WriteLine(months[3]);
            }
            else if (month == 5)
            {
                Console.WriteLine(months[4]);
            }
            else if (month == 6)
            {
                Console.WriteLine(months[5]);
            }
            else if (month == 7)
            {
                Console.WriteLine(months[6]);
            }
            else if (month == 8)
            {
                Console.WriteLine(months[7]);
            }
            else if (month == 9)
            {
                Console.WriteLine(months[8]);
            }
            else if (month == 10)
            {
                Console.WriteLine(months[9]);
            }
            else if (month == 11)
            {
                Console.WriteLine(months[10]);
            }
            else
            {
                Console.WriteLine(months[11]);
            }
            

            // 6. Skapa en lista som innehåller 3 textsträngar. Skriv ut samtliga värden med hjälp av index.
            List<string> firstList = new List<string>() {"Ida", "Susanna", "Johansson" };
            Console.WriteLine(firstList[0]);
            Console.WriteLine(firstList[1]);
            Console.WriteLine(firstList[2]);

            // 7. Skapa en lista som innehåller 3 integers. Skriv ut samtliga värden med hjälp av index.
            List<int> secondList = new List<int>() {1, 2, 3 };
            Console.WriteLine(secondList[0]);
            Console.WriteLine(secondList[1]);
            Console.WriteLine(secondList[2]);
            

            // 8. Skapa en lista med alla veckodagar. Be användaren skriva in ett tal (1-7). Skriv ut rätt veckodag.

            List<string> weekdays = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            Console.Write("Please enter a number between 1-7: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine(weekdays[0]);
            }
            else if (day == 2)
            {
                Console.WriteLine(weekdays[1]);
            }
            else if (day == 3)
            {
                Console.WriteLine(weekdays[2]);
            }
            else if (day == 4)
            {
                Console.WriteLine(weekdays[3]);
            }
            else if (day == 5)
            {
                Console.WriteLine(weekdays[4]);
            }
            else if (day == 6)
            {
                Console.WriteLine(weekdays[5]);
            }
            else if (day == 7)
            {
                Console.WriteLine(weekdays[6]);
            }
            else
            {
                Console.WriteLine(weekdays[7]);
            }
           

            // 9. Skapa en lista med alla månader.
            // Be användaren skriva in ett tal(1 - 12) Skriv ut rätt månad.

            List<string> months = new List<string>()
            {
                 "January",
                "February",
                "Mars",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            Console.Write("Enter a number between 1-12: ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine(months[0]);
            }
            else if (month == 2)
            {
                Console.WriteLine(months[1]);
            }
            else if (month == 3)
            {
                Console.WriteLine(months[2]);
            }
            else if (month == 4)
            {
                Console.WriteLine(months[3]);
            }
            else if (month == 5)
            {
                Console.WriteLine(months[4]);
            }
            else if (month == 6)
            {
                Console.WriteLine(months[5]);
            }
            else if (month == 7)
            {
                Console.WriteLine(months[6]);
            }
            else if (month == 8)
            {
                Console.WriteLine(months[7]);
            }
            else if (month == 9)
            {
                Console.WriteLine(months[8]);
            }
            else if (month == 10)
            {
                Console.WriteLine(months[9]);
            }
            else if (month == 11)
            {
                Console.WriteLine(months[10]);
            }
            else
            {
                Console.WriteLine(months[11]);
            }


            //10. Skapa en lista som innehåller chars. Lagra ditt namn i den. Skriv ut ditt namn på en rad.
            List<char> thirdList = new List<char>() { 'I', 'd', 'a' };
            Console.Write(thirdList[0]);
            Console.Write(thirdList[1]);
            Console.WriteLine(thirdList[2]);


            //11. Skapa en lista som innehåller talen 1-10.
            //a.räkna antal element i listan
            List<int> listWithNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int amount = listWithNumbers.Count;
            Console.WriteLine(amount);
            //b. vänd ordningen på elementen i listan
            listWithNumbers.Reverse();
            //c. Lägg till ett valfritt nummer, på valfritt index.
            listWithNumbers.Insert(2,22);
            //d.Skriv ut antal element i listan.
            int elements = listWithNumbers.Capacity;
            Console.WriteLine(elements);
            Console.WriteLine(listWithNumbers.Count); // Eller bara såhär.
            //e.Sortera listan.
            listWithNumbers.Sort();
            //f.Radera alla jämna tal.
            listWithNumbers.RemoveAll(item => item % 2 == 0);
            //g.Lägg till tre nya tal i slutet av listan.
            listWithNumbers.Add(100);
            listWithNumbers.Add(200);
            listWithNumbers.Add(300);
            listWithNumbers.AddRange(new int[] { 90, 80, 70 });

            foreach (int item in listWithNumbers) // För att skriva ut alla element i listan. 
            {
                Console.WriteLine(listWithNumbers);
            }

            // 12. Skapa en valfri textsträng.
            //a.Konvertera, och lagra, strängen i en lista av chars.

            string word = "Ida"; //1. skapa en sträng

            List<char> charWord = new List<char>(); //. skapa en lista

            charWord.AddRange(word); // Lägger till textsträngen i listan charWord. Konverterar automatiskt.

            foreach (char c in charWord) // Skriver ut char för char på samma rad. 
            {
                Console.Write(c);
            }
             */

        }
    }
}
