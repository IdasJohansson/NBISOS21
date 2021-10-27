using System;
using System.Collections.Generic;

namespace ArraysListor
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //1. 
            string[] firstArray = new string[] { "Ida", "Susanna", "Johansson" };
            Console.WriteLine(firstArray[0]);
            Console.WriteLine(firstArray[1]);
            Console.WriteLine(firstArray[2]);

            //2.
            int[] secondArray = new int[] { 100, 1000, 10000, };
            Console.WriteLine(secondArray[0]);
            Console.WriteLine(secondArray[1]);
            Console.WriteLine(secondArray[2]);

            //3.
            char[] thirdArray = new char[] { 'I', 'D', 'A' };
            Console.Write(thirdArray[0]);
            Console.Write(thirdArray[1]);
            Console.Write(thirdArray[2]);
            Console.WriteLine();
           

            //.4
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

            //5.
       
            //8.
            List<string> firstList = new List<string>() {"Ida", "Susanna", "Johansson" };
            Console.WriteLine(firstList[0]);
            Console.WriteLine(firstList[1]);
            Console.WriteLine(firstList[2]);

            //9.
            List<int> secondList = new List<int>() {1, 2, 3 };
            Console.WriteLine(secondList[0]);
            Console.WriteLine(secondList[1]);
            Console.WriteLine(secondList[2]);

            //10.
            List<char> thirdList = new List<char>() { 'I', 'd', 'a' };
            Console.Write(thirdList[0]);
            Console.Write(thirdList[1]);
            Console.WriteLine(thirdList[2]);
            */

            //11.
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


        }
    }
}
