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
           

            //.1

            int i = 1;
            while (i <=10)
            {
                Console.WriteLine(i);
                i++;
            }

            //2.

            i = 10;
            while (i>=1)
            {
                Console.WriteLine(i);
                i--;
            }
            

            //3.

            Console.WriteLine("Skriv in ett startnr: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett stoppnr: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            while (i <=stop)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
             

            //4.

            Console.WriteLine("Skriv in ett startnr: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett stoppnr: ");
            int stop = Convert.ToInt32(Console.ReadLine());

            while (start <= stop)
            {
                Console.WriteLine(start);
                ++;
            }
            

            //5.
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
             

            //6.

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

            Console.WriteLine("Skriv in din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Antal år kvar till pension

            int retairmentAge = 65;
            int yearsleft = retairmentAge - age;
            Console.WriteLine("Du har {0} år kvar till pension.", yearsleft);

            //Fråga om att spola fram tiden

            Console.WriteLine("Vill du spola fram till pension? [J/N]");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'J')
            {
                int originalAge = age;
                // Skriv ut ålder varje år
                while (age < retairmentAge)
                {
                    Console.WriteLine("Du är nu {0} år,", age);
                    age++;
                }
            }
            else
            {
                Console.WriteLine("Okej, njut av livet.");
            }

            Console.WriteLine("Vill du stanna kvar här? [J/N]");
            choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'J')
            {
                while (age > originalAge)
                {
                    age--;
                    Console.WriteLine("Du är nu {0} år", age);
                }
            }
            else
            {
                Console.WriteLine("Njut av pensionen.");
            }

           
            //7.

            //8.

            int correctNr = 10;
            int wrongNr = 0; 

            List<int> wrongGuesses = new List<int>() { };

            while (wrongNr != correctNr)
            {
                Console.WriteLine("Gissa vilket nr: ");
                wrongNr = Convert.ToInt32(Console.ReadLine());
            }
           */


            //11.

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
        }
    }
}
