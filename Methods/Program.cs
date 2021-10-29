using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // METODER
            // En metod utan retur startar med void, ska man göra en metod som returnerar ett värde ska man börja med att definera datatypen.
            // Glöm inte heller att skriva ut return; Eller return samtVa

            // ------------------------------------------------------------------------------------------------------------------------

            /*
            // 1.Skapa en metod som skriver ut en hälsning.

            void Greeting()
            {
                Console.WriteLine("Hej! ");
            }
            Greeting();

            // 2. Skapa en metod som skriver ut en hälsning och det namn användaren skriver in.

            void GreetingName()
            {
                Console.WriteLine("Skriv in ditt namn: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hej, {0} !", name);
            }
            GreetingName();

// ------------------------------------------------------------------------------------------------------------------------

            // 3.Skapa en metod som frågar användaren efter dess ålder. Returnera om användaren är över 18 eller inte.

            string ReturnAge()
            {
                Console.WriteLine("Hur gammal är du?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 18)
                {
                    string over18 = "Du är över 18";
                    return over18;
                }
                else
                {
                    string under18 = "Du är under 18";
                    return under18;
                }
            }

            Console.WriteLine(ReturnAge());
            
// ------------------------------------------------------------------------------------------------------------------------

            //4.Skapa en metod som tar in två tal.
            // Addera talen och returnera summan.

            int ReturnSum()
            {
                Console.WriteLine("Skriv in två tal: ");
                int nr1 = Convert.ToInt32(Console.ReadLine());
                int nr2 = Convert.ToInt32(Console.ReadLine());
                int result = nr1 + nr2;
                return result;
            }
            Console.WriteLine(ReturnSum());

// ------------------------------------------------------------------------------------------------------------------------
            
            //5. Skapa en metod som skriver ut om ett tal är jämnt eller inte.

            void EvenOrOdd() 
            {
                Console.WriteLine("Skriv in ett tal för att ta reda på om det är jämnt eller inte: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput%2 ==0)
                {
                    Console.WriteLine("{0}, är ett jämnt tal.", userInput);
                }
                else
                {
                    Console.WriteLine("{0}, är ett ojämnt tal.", userInput);
                }
            }
            EvenOrOdd();

// ------------------------------------------------------------------------------------------------------------------------

            //6. Skapa en metod som returnerar om ett tal är jämnt eller inte.

            string ReturnEvenOrOdd()
            {
                Console.WriteLine("Skriv in ett tal för att ta reda på om det är jämnt eller inte: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput % 2 == 0)
                {
                    string even = "Jämnt tal!";
                    return even;
                }
                else
                {
                    string odd = "Ojämnt tal!";
                    return odd;
                }
            }
            Console.WriteLine(ReturnEvenOrOdd());
          
// ------------------------------------------------------------------------------------------------------------------------

            //7. Skapa en metod som returnerar om två tal är lika eller inte.

            string ReturnAlike()
            {
                Console.WriteLine("Skriv in två tal: ");
                int num1 = Convert.ToInt32(Console.ReadLine()); 
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 == num2)
                {
                    string equal = "Talen är lika!";
                    return equal; 
                }
                else
                {
                    string unequal = "Talen är inte lika!";
                    return unequal;
                }
            }
            Console.WriteLine(ReturnAlike());
            
// ------------------------------------------------------------------------------------------------------------------------

            //8. Skapa en metod som konverterar Celsius till Fahrenheit. Resultatet ska skrivas ut.
            // Fahrenheit = (Celsius / 5.0) * 9 + 32

            void CelsiusToFarenheight()
            {
                Console.WriteLine("Skriv in din temperatur i Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double farenheight = (celsius / 5) * 9 + 32;
                Console.WriteLine("Temperaturen i farenheight är {0}", farenheight);
            }
            CelsiusToFarenheight();

// ------------------------------------------------------------------------------------------------------------------------            
      
            //9. Skapa en metod som räknar ut arean av en kvadrat. (basen x höjden) Metoden ska skriva ut resultatet.

            void SquareArea(int side)
            {
                int area = side * side;
                Console.WriteLine("Arean för kvadraten är {0}", area);
            }
            SquareArea(10);
            

// ------------------------------------------------------------------------------------------------------------------------

            //10.  Skapa en metod som räknar ut arean av en rektangel. (basen x höjden) Metoden ska skriva ut resultatet.

            void AreaRektangle()
            {
                Console.Write("Skriv basen: ");
                int bas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Skriv in höjden: ");
                int height = Convert.ToInt32(Console.ReadLine());
                int area = bas * height;
                Console.WriteLine("Arean på kvadraten är: {0}", area);
            }
            AreaRektangle();
            
// ------------------------------------------------------------------------------------------------------------------------

            // 11.  Skapa en metod som räknar ut arean av en rätvinklig triangel. Metoden ska skriva ut resultatet.
            // basen*höjden/2 = arean

            void AreaTriangle()
            {
                Console.WriteLine("Enter length of base: ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                double h = Convert.ToInt32(Console.ReadLine());
                double area = b * h / 2;
                Console.WriteLine("Area of the triangle is: {0}", area);
            }
            AreaTriangle(); 
            

// ------------------------------------------------------------------------------------------------------------------------

            // 12. Skapa en metod som räknar ut arean och omkretsen av en cirkel. Metoden ska skriva ut resultaten.
            // Omkrets = 2 * radien * pi
            // Area = pi * radien * radien

            void Circle()
            {
                Console.WriteLine("Enter radious: ");
                double radious = Convert.ToDouble(Console.ReadLine());
                double pi = 3.14;
                double area = 2 * pi * radious;
                double circumference = pi * radious * radious;

                Console.WriteLine("Circumference is: {0} and Area is: {1}", circumference, area); // Hur avrundar man decimalerna på en double? 
            }
            Circle();
             
// ------------------------------------------------------------------------------------------------------------------------

            // 13.Skapa en metod för att kasta tärningar.
            // Användaren ska välja hur många gånger tärningen ska kastas.
            // Returnera summan av alla kast.
            // Tips: Random

            int throwDiceReturnSum()
            {
                Random rnd = new Random();
                int sum = 0; 

                Console.WriteLine("How many times do you want to throw the dice?");
                int throws = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= throws; i++)
                {
                    sum += rnd.Next(1,7); // För att slumpa ett tal mellan 1-6 måste man ta range upp till 7. 
                }
                return sum; 
            }
            Console.WriteLine(throwDiceReturnSum());
           

// ------------------------------------------------------------------------------------------------------------------------

            // 14.Skapa en metod som tar in en array, och returnerar det största talet.

            // Här ligger arrayen inne i metoden
            int methodWithArray()
            {
                int[] arrayWithNr = new int[] { 100, 200, 300, 700, 30, 22};
                int highestNr = 0;

                for (int i = 0; i < arrayWithNr.Length; i++)
                {
                    if (arrayWithNr[i] > highestNr)
                    {
                        highestNr = arrayWithNr[i];
                    }
                }
                return highestNr;
            }
            Console.WriteLine(methodWithArray());
            

            // Här plockar jag upp en array som ligger utanför metoden och skickar med in i metoden. 
            int[] arrayWithNr = new int[] { 100, 200, 300, 700, 30, 22 };

            int findHighestNr(int[] numbers) //För att metoden ska förstå att den ska ta med en array skriver vi i det här,
                                             //Namnet existerar bara inne i metoden inte utanför.
                                             // Så i detta ex är numbers = arrrayWithIntNr. 
            {
                int highestNr = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > highestNr)
                    {
                        highestNr = numbers[i];
                    }
                }
                return highestNr;
            }
            Console.WriteLine(findHighestNr(arrayWithNr)); // Här skriver vi arrayWithNr som är den Array vi vill att metoden ska kolla igenom. 

            int[] secondArray = new int[] { 1, 70, 34, 27, 55, 12 }; 
            Console.WriteLine(findHighestNr(secondArray)); // Samma metod kolla igenom en ny array.
           

// ------------------------------------------------------------------------------------------------------------------------


            // 15. Skapa en metod som tar in en array, och returnerar det minsta talet.


            int[] arrayNumbers = new int[] { 90, 30, 1, 40, 20 };

            int FindSmallestNr(int[] numbers)
            {
                int smallest = numbers[0]; // Som utgångspunkt är index 0 i arrayen det minsta numret.

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < smallest)
                    {
                        smallest = numbers[i];
                    }
                }
                return smallest; 
            }
            Console.WriteLine(FindSmallestNr(arrayNumbers));

            

// ------------------------------------------------------------------------------------------------------------------------

            // 16.Skapa en metod som skriver ut om ett inmatat tal är ett primtal eller inte.
            // Primtal: Endast delbart med 1 och sig självt.T.ex: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31...

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
             

// ------------------------------------------------------------------------------------------------------------------------

       
            // 17.Skapa en metod som tar in ett tal samt en exponent.Skriv ut resultatet.
            // Exponent = upphöjt till.T.ex. 23 = 2 * 2 * 2

            void Expo()
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a exponent: ");
                int exp = Convert.ToInt32(Console.ReadLine());

                int result = 1;

                for (int i = 1; i <= exp; i++) // Kommer loopas lika många gånger som exponenten anges
                {
                    result *= number;
                }
                Console.WriteLine("{0} upphöjt i {1} = {2}", number, exp, result);
            }
            Expo(); 
            
// ------------------------------------------------------------------------------------------------------------------------

            // 18. Skapa en metod som tar in en char.
            // Skriv ut om det är en siffra eller bokstav.
            // Om bokstav, skriv ut om det är en vokal eller konsonant.

            Console.WriteLine("Enter a char: ");
            char userInput = Convert.ToChar(Console.ReadLine()); 

            void NumberOrLetter(char c)
            {
                bool result = Char.IsDigit(c);
                if (result == true)
                {
                    Console.WriteLine("{0} = Number!", c);
                }
                else
                {
                    Console.WriteLine("{0} = Letter!", c);

                    List<char> wovels = new List<char>() { 'a', 'o', 'u', 'å', 'e', 'i', 'y', 'ä', 'ö' };
                    if (wovels.Contains(c))
                    {
                        Console.WriteLine("{0} = a wovel", c);
                    }
                    else
                    {
                        Console.WriteLine("{0} = a consonant", c);
                    }
                }
            }
            NumberOrLetter(userInput);
           

// ------------------------------------------------------------------------------------------------------------------------


            // 19. Skapa en metod som tar in två värden. (Pris och moms)
            // Båda ska skrivas in som integers. Tex, 100 och 25. Returnera priset inkl. moms.

// ------------------------------------------------------------------------------------------------------------------------

            // 20.Skapa en metod som returnerar om ett är ett heltal eller inte.
            // Indata ska vara en double.
            // Metoden får inte innehålla någon sorts konvertering.
            // T.ex. 1.0 = sant, 1.01 = falskt.


            string Number()
            {
                Console.WriteLine("Enter a number: ");
                double userInput = Convert.ToDouble(Console.ReadLine());
                string answer;

                if (userInput%1 == 0)
                {
                    answer = "INTEGER"; 
                }
                else
                {
                    answer = "DOUBLE"; 
                }
                return answer; 
            }
            Console.WriteLine(Number());
           


// ------------------------------------------------------------------------------------------------------------------------

            // 21.Skapa en metod som tar in 2 tal.
            // Returnera nästa tal som är större än tal1+tal2; och delbart med tal2.
            // T.ex.Indata = 1,
            // 2.Summa:
            // 3, nästa tal som är större än 3 och delbart med 2 är 4.

// ------------------------------------------------------------------------------------------------------------------------
             */
            // 22. Skapa en metod som räknar antal siffror i en textsträng. Returnera antalet siffror.
            // T.ex.fry32g5gs = 3

            string test = "fry32g5gs";

            int CountNumbers(string numbers)
            {
                int count = 0;

                foreach (char c in numbers)
                {
                    if (c >= '0' && c <= '9')
                    {
                        count++;
                    }
                }

                return count;
            }
            Console.WriteLine(CountNumbers(test));

// ------------------------------------------------------------------------------------------------------------------------

            // 23.Bygg vidare på 22.
            //Skriv ut summan av siffrorna i textsträngen.

            int count = 0; 

            foreach (char item in test) // Denna loop räknar antalet siffror i textsträngen
            {
                if (char.IsDigit(item))
                {
                    count++; 
                }
            }

            Console.WriteLine(count);

            int sum = 0; 

            foreach (char item in test) // Denna loop adderar siffrorna i texsträngen och sparar dom i inten sum. 
            {
                if (char.IsDigit(item))
                {
                    Console.Write(item);
                    sum += Convert.ToInt32(item.ToString());

                }
            }
        }
    }
}
