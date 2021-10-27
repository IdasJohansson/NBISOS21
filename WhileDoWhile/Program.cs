using System;
using System.Collections.Generic;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // While, så länge villkoret inom parantesen är sant så körs kodblocket.
            /*
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i);
                i++; // ökar i men ett varje varv till i = 9
                // det går också att skirva i = i +
            }
           

            //.1 Skriv ut alla tal från 1-10.

            int i = 1;
            while (i <=10)
            {
                Console.WriteLine(i);
                i++;
            }

            //2. Skriv ut alla tal från 10-1

            i = 10;
            while (i>=1)
            {
                Console.WriteLine(i);
                i--;
            }
            

            //3. Skriv ut alla jämna tal från 1-100
            // a. Nästa steg: Låt användaren välja start & stopp.

            Console.WriteLine("Skriv in ett startnr: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett stoppnr: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            while (i <=stop)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
             

            //4. Skriv ut alla ojämna tal från 1-100
            a. Nästa steg: Låt användaren välja start & stopp.

            Console.WriteLine("Skriv in ett startnr: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett stoppnr: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            while (start <= stop)
            {
                Console.WriteLine(start);
                ++;
            }
            

            //5. Skapa en array med valfritt antal integers. Skapa en loop som summerar samtliga tal. Skriv ut resultatet.

            //while
            int[] arrayWithNr = new int[] { 20, 30, 40 };
            int i = 0;
            int sum = 0;

            while (arrayWithNr.Length > i)
            {
                sum = sum + arrayWithNr[i];
                i++;
            }
            Console.WriteLine(sum);

            //doWhile
             

            //6. Be användaren mata in sin ålder
            // Skriv ut hur många år det är kvar till pension
            // Fråga användaren om man vill spola fram tiden till pension.
            // Svaret ska får vara valfri datatyp.
            // Om användaren väljer att spola fram tiden:
            // Öka åldern med 1 och skriv ut varje ökning till dess att användaren än 65.
            // Vid 65 ska användaren få bestämma om de vill stanna kvar på den åldern eller spola tillbaks tiden. Om användaren väljer att stanna kvar:
            // skriver programmet ut något passande och avslutas
            // Om användaren väljer att inte stanna kvar:
            // Åldern ändras till den ursprungliga ålder.
            // Använd en loop för att skriva ut förändringen, år för år.
            // Skriv något passande och avsluta programmet.

            int age = 0;
            int pension = 65; 

            Console.WriteLine("Skriv in din ålder: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vill du spola fram tiden till pension? Skriv 1 för Ja eller 2 för Nej");
            int choice = Convert.ToInt32(Console.ReadLine());

            int originalAge = age; 

            while (choice == 1 && age <= pension)
            {
                Console.WriteLine(age);
                age++;
            }
            Console.WriteLine("Vill du stanna kvar på 65 eller spola tillbaka tiden igen? Skriv 1 för Ja eller 2 för Nej");

            choice = Convert.ToInt32(Console.ReadLine());
            while (choice == 1 && age >= originalAge)
            {
                Console.WriteLine(age);
                age--;
                if (choice == 2)
                {
                    Console.WriteLine("Okej, ha ett bra liv som 65!");
                }
            }
            Console.WriteLine("Du är nu {0} år gammal igen", age);

            //. Blir fel siffror.... 66 och 29...
           
            //6.

            // Be använaren om ålder
            Console.WriteLine("Skriv in din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //Antal år kvar till pension
            int retirementAge = 65;
            int yearsLeft = retirementAge - age;
            Console.WriteLine("Du har {0} år kvar till pension.", yearsLeft);

            //Fråga om att spola fram tiden.
            Console.WriteLine("Vill du spola fram till pension? [J/N] ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'J')
            {
                int originalAge = age;
                //Skriv ut ålder varje år
                while (age < retirementAge)
                {
                    age++;
                    Console.WriteLine("Du har nu {0} år", age);
                }

                Console.WriteLine("Vill du stanna kvar här? [J/N]");
                choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'N')
                {
                    while (age > originalAge)
                    {
                        age--;
                        Console.WriteLine("Du är {0} år.", age);
                    }
                }
                else
                {
                    Console.WriteLine("Okej, njut av livet!");
                }
            }
            Console.WriteLine("Tack för din tid!");
           
            //7.
            // Skriv ett program som sparar information om 3 användare. Varje användare ska ha:
            // Namn, Ort, Skostorlek, Favoritkaraktär i valfri serie/ film.
            // Allt ska sparas i en array, och värdena ska skrivas in via konsolen.
            // Skriv ut en sammanställning för varje användare.

            string[,] userArray = new string[3, 4]; // En array med 3 rader och fyra kolumner, för 3 användare med fyra värden var.

            int userCount = 0; 
            int users = userArray.GetLength(0); // Varför står det 0 här? 

            while (userCount < users) // Så länge userCount är mindre än users så körs loopen, users är lika lång som längden på arrayen. 
            {
                Console.WriteLine("Användare {0}", userCount +1);
                Console.WriteLine("Namn: ");
                userArray[userCount, 0] = Console.ReadLine(); // Namn läggs in i arrayen på plats [0,0] första varvet, [1,0] andra varvet, [2,0] tredje varvet, [3, 0] fjärde varvet.  
                Console.WriteLine("Ort: ");
                userArray[userCount, 1] = Console.ReadLine(); // Ort läggs in i arrayen på plats [0, 1] första varvet, [1, 1] andra varvet, [2, 1] tredje varvet, [3, 1] fjärde varvet. 
                Console.WriteLine("Skostorlek: ");
                userArray[userCount, 2] = Console.ReadLine(); // Skostorlek läggs in i arrayen på plats[0, 2] första varvet, [1, 2] andra varvet, [2, 2] tredje varvet, [3, 2] fjärde varvet. 
                Console.WriteLine("Favoritkaraktär: ");
                userArray[userCount, 3] = Console.ReadLine(); // Favoritkaraktär läggs in i arrayen på plats[0, 3] första varvet, [1, 3] andra varvet, [2, 3] tredje varvet, [3, 3] fjärde varvet. 
                Console.ReadLine();
                userCount++; 
            }

            userCount = 0;
            while (userCount < users)
            {
                Console.WriteLine("Användare {0}", userCount + 1);
                Console.WriteLine("Namn: {0}", userArray[userCount, 0]);
                Console.WriteLine("Ort: {0}", userArray[userCount, 1]);
                Console.WriteLine("Skostorlek: {0}", userArray[userCount, 2]);
                Console.WriteLine("Favoritkaraktär: {0}", userArray[userCount, 3]);
                userCount++;
            }

          
            //8.Skapa ett program som låter användaren gissa på ett tal.
            // Loopa tills att användaren gissar rätt alt. ger användaren x antal gissningar. Räkna, och skriv ut, antal gissningar för användaren.
            // Lagra felaktigt gissade nummer i en lista.
            // Tips: Random

            int correctNr = 10;
            int wrongNr = 0;
            int guesses = 0;  

            List<int> wrongGuesses = new List<int>() { };

            while (wrongNr != correctNr && guesses<= 10)
            {
                Console.WriteLine("Gissa vilket nr, du har 10 gissningar på dig.");
                wrongNr = Convert.ToInt32(Console.ReadLine());

                if (wrongNr == correctNr)
                {
                    Console.WriteLine("Rätt gissning!");
                }
                else
                {
                    wrongGuesses.Add(wrongNr);
                    guesses++;
                    Console.WriteLine("Gissning nr: {0} / 10", guesses);
                    Console.WriteLine("Försök igen!");
                }
                foreach (int item in wrongGuesses)
                {
                    Console.WriteLine("Fel gissning: {0}", item);
                }
            }

            //9. Be användaren skriva in ett tal.
            // Skriv ut multiplikationstabellen för talet (0-10).

            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0; 

            while (count <= 10)
            {
                Console.WriteLine("{0} * {1} = {2}", number, count,number * count);
                count++;
            }
           
            // 10.Be användaren skriva in ett valfritt tal.
            // Skapa en array av valfri typ, med plats för lika många element som användaren har valt.Skapa en loop som ser till att användaren skriver in värden för varje element.
            // Skriv ut samtliga element i arrayen innan programmet avslutas.

            Console.Write("Enter desired number of elements: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[elements];
            int count = 0;

            while (count < elements)
            {
                Console.Write("Enter a number to insert: ");
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

            count = 0;
            while (count < elements)
            {
                Console.WriteLine(numbers[count]);
                count++;
            }

            //11. Skapa en variabel som heter memory, sätt värdet till 0. Skapa en variabel som heter value, sätt värdet till 0.
            // Skapa en while-loop med villkoret value>=0
            // Fråga användaren efter ett nytt värde.
            // Omvandla värdet och lägg det i variabeln value. Addera value till memory.
            // När loopen bryts, skriv ut värdet som lagrats i memory.

            // Skapa en variabel som heter memory värde 0
            int memory = 0;

            // Skapa en variable som heter value värde 0
            int value = 0;

            // While-loop, villkor value >=0
            while (value >= 0) // Så länge value är större än 0 så fortsätter loppen, för att bryta loopen måste man skriva in ett negativt tal. 
            {
                // Be användaren om värde
                Console.WriteLine("Skriv in valfritt tal: ");
                // Omvandla och lagra värde
                value = Convert.ToInt32(Console.ReadLine());
                if (value <0) // För att bryta loopen och inte ta med det sista värdet? 
                {
                    continue; //Nästa iteration i samma loop, nästa omgång av loopen
                    break; //Bryter loopen
                }
                // Addera till memory
                memory += value; // memory = memory + value
                // memory = memory: 10 + value:5
            }

            // När loopen bryts skriv ut summan
            Console.WriteLine("Total summa: {0}", memory); // Så länge value är större än 0 så fortsätter loppen, för att bryta loopen måste man skriva in ett negativt tal.
             */

            // 12.Skriv ett program där användaren ska gissa på huvudstäder. Lagra länder och huvudstäder i två separata arrays/ listor.Skriv ut ”Vad heter huvudstaden i .... ?”
            // Kontrollera om svaret är rätt.
            // Skriv ut något passande beroende på om det är rätt eller fel.
            // Loopa tills användaren gissat på samtliga länder, alt x antal gissningar. Räkna antal rätta resp. felaktiga svar.


        }
    }
}
