using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1. Skriv ut alla tal mellan 0 – 100 med en for-loop.

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            

            // 2. Skriv ut alla tal mellan 100 – 0 med en for-loop.

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine("i = {0} ", i);
            }
            

            // 3. Skriv ut alla jämna tal mellan 0 - 100 med en for-loop.

            for (int i = 2; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            // a. Med & utan modulus.

            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            // 4.Skriv ut alla ojämna tal mellan 1 - 99 med en for-loop.

            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            
            // a.Med & utan modulus.

            for (int i = 0; i <=100; i++)
            {
                if (i%2 !=0)
                {
                    Console.WriteLine(i);
                }
            }

            //5. Skapa en array/lista med minst 10 integers.
            // Använd en for-loop för att hitta det största talet.
            // Använd en foreach-loop för att hitta det största talet.

            int[] arrayWithInt = new int[] { 10, 20, 25, 66, 30, 80, 100, 23, 32, 40};
            int highestNr = 0; 
           
            for (int i = 0; i < arrayWithInt.Length; i++)
            {
                if (arrayWithInt[i]>highestNr)
                {
                    highestNr = arrayWithInt[i];
                }
            }
            Console.WriteLine(highestNr);
            
            foreach (int item in arrayWithInt)
            {
                if (item > highestNr)
                {
                    highestNr = item;
                }
            }
            Console.WriteLine(highestNr);
            

            // 6. Skapa en loop som skriver ut alla tal mellan 1–100. Undantag:
            // Om talet är delbart med 3, skriv ut SOS
            // Om talet är delbart med 5, skriv ut 21GB
            // Om talet är delbart med 3 och 5, skriv ut SOS21GB.

            for (int i = 1; i <=100; i++)
            {
                if (i%3==0 && i%5==0)
                {
                    Console.WriteLine("{0} {1}",i,"SOS21GB");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("{0} {1}",i, "SOS");
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("{0} {1}",i,"21GB");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
           
            // 7. Be användaren skriva in ett värde.
            // Skapa en for-loop som startar på 0 och slutar på det värde användaren angett.
            // För varje iteration:
            // Addera värdet till en variabel.
            // När loopen är klar, skriv ut den totala summan.

            Console.Write("Skriv in en siffra där loopen ska sluta:");
            int stop = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= stop; i++) // i = 0 så länge i är större eller lika med stopvärdet öka med 1 för varje itteration.
            {
                sum += i; // Summan av talen är lika med i + i (upprepas i varje itteration tills stop)
            }
            Console.Write("Summan av talen i loopen är: ");
            Console.WriteLine(sum); // Totalsumman av alla tal är lagrad i variabeln sum
            

            // 8. List<string> education = new List<string>() { "utveckling","Objekt","orienterad"," ","System"};
            // Använd en for-loop för att flytta ”utveckling” till rätt position, ett steg i taget.
            // Använd funktionen Reverse() för att byta platsen på två element åt gången.
            // Skriv ut alla strängar på en rad, använd valfri loop.

            List<string> education = new List<string>() { "utveckling", "Objekt", "orienterad", " ", "System" };

            for (int i = 0; i < education.Count-1; i++) // Minus ett för inte hamna utanförlistan 
            {
                education.Reverse(i, 2); // i = index 0, byt plats på två element i taget
            }

            foreach (string item in education) // För varje item i listan education, skriv ut item
            {
                Console.Write(item);
            }

            // 9. Be användaren skriva in sitt namn.
            // Använd en foreach-loop(char c in name) för att skriva ut namnet; varje bokstav på en ny rad.

            Console.Write("Skriv in ditt namn: ");
            string name = Console.ReadLine(); 

            foreach (char letter in name) // En sträng fungerar som en lista av chars, så för varje char i listan vill vi skriva ut en boksstav. I excemplet kallar vi variabeln char för letter.
            {
                Console.WriteLine(letter);
            }
             
            // 10. Be användaren skriva in en textsträng.
            // Konvertera textsträngen till en lista av chars.
            // Skapa en tom lista av chars.
            // Använd en loop för att addera varje char i den första listan till den nya, i omvänd ordning.

            Console.WriteLine("Skriv in en valfri textsträng som du vill konvertera till chars: ");
            string userInput = Console.ReadLine(); 

            List<char> listWithUserInput = new List<char>(); // Vi har valt att listan ska innehålla datatypen char.
            listWithUserInput.AddRange(userInput); // Lägger till userInput i listan ListWithUserInput och konverterar automatiskt textsträngen till chars.
            Console.WriteLine("Din textsträng i en lista av chars:");

            foreach (char item in listWithUserInput) // Skriver ut listan med char, varje char på en egen rad. 
            {
                Console.WriteLine(item);
            }

            List<char> emptyList = new List<char>(); // En tom lista
            listWithUserInput.Reverse(); // Vänder på listan
            emptyList.AddRange(listWithUserInput); // Lägger till listan med chars i en ny lista
    
            // Skriv ut listan med chars
            foreach (char item in listWithUserInput)
            {
                Console.WriteLine(item);
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

            for (int i = 0; i < userStringList.Count/2; i++)
            {
                if (userStringList[i] == userStringList[userStringList.Count - (i +1)])
                {
                    Console.WriteLine("Palindrom");
                }
                else
                {
                    Console.WriteLine("Inget Palindrom");
                }
            }
           

            // 12. Be användaren skriva in ett värde.
            // Skapa en loop som skriver ut samtliga fibonaccital fram till det värde användaren har angett.
            // Fibonaccital = summan av de två tidigare talen.
            // De första två talen är 0 och 1.
            // Output = 0 1 1 2 3 5 8....

            Console.WriteLine("Hur många fibonaccital vill du se?");
            int stop = Convert.ToInt32(Console.ReadLine());

            int nr1 = 0;
            int nr2 = 1;
            int sum;

            for (int i = 0; i <= stop; i++)
            {
                sum = nr1 + nr2;
                Console.WriteLine(sum);
                nr1 = nr2;
                nr2 = sum; 
            }
             

            //13. Skapa en lista med plats för 10 element.
            // Använd en for-loop för att ta in 10 värden från användaren.
            // Skriv ut summan av alla tal, samt medelvärdet.

            int userInput;
            int sum = 0;
            double average;

            List<int> list13 = new List<int>(10);

            Console.WriteLine("Skriv in 10 nummer: ");
            
            for (int i = 0; i < list13.Capacity; i++)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                list13.Add(userInput); 
            }

            for (int i = 0; i < list13.Count; i++)
            {
                sum += list13[i];
            }

            average = (double)sum / list13.Count;

            Console.WriteLine("Summan av talen är: {0}", sum);
            Console.WriteLine("Medelvärdet på talen är: {0}", average);
            

            //14. Skapa en 2D-array med ints. T.ex. int[,] numbers = new int[,] { {1,2 },{3,4 },{5,6 } };
            // Skriv ut alla talen med hjälp av en nested for-loop.
            // Skriv ut alla talen med hjälp av en foreach-loop.
            // Tips: För att få ut rätt längd på en 2D - array används GetLength(index) istället för Length.

            int[,] numbers = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1); 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(numbers[i,j]);
                }
            }
            */

            //15. Skriv ut en multiplikationstabell med hjälp av en for-loop.
            //Låt användaren bestämma vilket tal som ska användas.
            //Låt användaren bestämma hur långt talet ska multipliceras.
            // T.ex: tal = 5, antal iterationer: 20
            // Output: 5x0 = 0, 5x1 = 1..... 5x19 = 95, 5x20 = 100


        }
    }
}
