using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //.1 Be användaren mata in tre tal. Addera talen.
            // Skriv ut summan.
            // Skriv sedan ut dem i storleksordning. Störst först.

            Console.WriteLine("Skriv in tre tal:  ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int tal3 = Convert.ToInt32(Console.ReadLine());

            int sum = tal1 + tal2 + tal3;

            Console.Write("Summan av de tre talen är: ");
            Console.WriteLine(sum);

            if (tal1 > tal2 && tal1 > tal3) // Om tal1 är störra än tal2 OCH tal3.
            {
                if (tal2 > tal3)    // Om tal2 är större än tal3 = tal2 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal1, tal2, tal3);
                }
                else                // Om tal2 inte är större än tal3 = tal3 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal1, tal3, tal2);
                }
            }
            if (tal2 > tal1 && tal2 > tal3) // Om tal2 är större än tal1 OCH tal3.
            {
                if (tal1 > tal3)    // Om tal1 är större än tal3 = tal1 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal2, tal1, tal3);
                }
                else                // Om tal1 inte är större än tal3 = tal3 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal2, tal3, tal1);
                }
            }
            else    // Om inte tal1 eller tal2 är störst = tal3 är störst.
            {
                if (tal1 > tal2)    // Om tal1 inte är större än tal2 = tal1 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal3, tal1, tal2);
                }
                else                // Om tal1 inte är större än tal2 = tal2 är näst störst.
                {
                    Console.WriteLine("Storleksordning: {0} {1} {2}", tal3, tal2, tal1);
                }

            // ------------------------------------------------------------------------------------------------------------------------


                //2. 2. Be användaren mata in två tal.
                // Skriv ut det tal som är störst, minst samt differensen mellan talen.

                Console.WriteLine("Skriv in två tal: ");
                tal1 = Convert.ToInt32(Console.ReadLine());
                tal2 = Convert.ToInt32(Console.ReadLine());

                if (tal1 > tal2)
                {
                    Console.WriteLine("Det största talet är: {0} ", tal1);
                    Console.WriteLine("Skillnaden mellan talen är: {0} ", (tal1 - tal2));
                }
                else
                {
                    Console.WriteLine("Det största talet är: {0} ", tal2);
                    Console.WriteLine("Skillnaden mellan talen är: {0} ", (tal2 - tal1));
                }

           // ------------------------------------------------------------------------------------------------------------------------

                //3. Be användaren mata in två tal. Addera talen
                // Skriv ut summan.
                // Om talen är lika, hälsa användaren att den saknar fantasi.

                int nr1 = Convert.ToInt32(Console.ReadLine());
                int nr2 = Convert.ToInt32(Console.ReadLine());

                int summa = (nr1 + nr2);
                Console.WriteLine(summa);

                if (nr1 == nr2)
                {
                    Console.WriteLine("Du saknar fantasi!");
                }

            // ------------------------------------------------------------------------------------------------------------------------

                   //4. Be användaren mata in sin ålder
                    //Skriv ut hur många år det är kvar till pension
                    //Fråga användaren om man vill spola fram tiden till pension. Svaret ska vara en char. (J / N)
                    //Om användaren svarar "J" så ändras åldern till 65.
                    //Vid 65 ska användaren få bestämma om de vill stanna kvar på den åldern eller spola tillbaks tiden Presentera dessa val i form av en meny med WriteLine.
                    //"1. Jag vill stanna på denna ålder"
                    //"2. Jag ångrar mig! Ta mig tillbaks!"
                    //Väljer användaren 1 så skriver programmet ut något passande och avslutas Väljer användaren 2 så ändras åldern till ursprungsåldern.
                    //Skriv något passande och avsluta programmet.

                int age;
                int pension = 65;

                Console.Write("Skriv in din ålder: ");
                age = Convert.ToInt32(Console.ReadLine());

                int result = pension - age;

                Console.WriteLine("Du har {0} år kvar till pension", result);
                Console.WriteLine("Vill du spola fram tiden till pension? Svara J eller N");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'J')
                {
                    age = 65;
                    Console.WriteLine("Din ålder är nu {0}", age);
                    Console.WriteLine("1. Vill du stanna kvar på denna ålder? (Skriv 1)");
                    Console.WriteLine("2. Jag ångrar mig, spola tillbaka (Skriv 2)");

                    int response = Convert.ToInt32(Console.ReadLine());

                    if (response == 1)
                    {
                        Console.WriteLine("Njut av pensionärslivet!");
                    }
                    else
                    {
                        age = result;
                        Console.WriteLine("Du är {0) gammal igen", age);
                    }
                }

                Console.WriteLine("The End");

    // ------------------------------------------------------------------------------------------------------------------------
              
            // 5. Deklarera fem strings.
            // Ex. string myFirstString;
            // Tilldela dessa strings fem olika värden
            // Deklarera fem ints.
            // Ex. int myFirstInt;
            // Tilldela dessa ints fem olika värden
            // Skriv ut till konsolen första stringen och första int.
            // Ex. Console.WriteLine(myFirstString + myFirstInt); Repetera detta steg för alla variabler.


            // Deklarera;
            string first;
            string second;
            string third;
            string fourth;
            string fifth;

            int one;
            int two;
            int three;
            int four;
            int five;

            // Tilldela värde:
             first = "Hej!";
             second = "Hallå!"; 
             third = "Tjena!";
             fourth = "Goddag!";
             fifth = "God morgon!";

             one = 1;
             two = 2;
             three = 3;
             four = 4;
             five = 5;

            // Skriv ut:
            Console.WriteLine("{0}. {1}", one, first);
            Console.WriteLine("{0}. {1}", two, second);
            Console.WriteLine("{0}. {1}", three, third);
            Console.WriteLine("{0}. {1}", four, fourth);
            Console.WriteLine("{0}. {1}", five, fifth);
             
 // ------------------------------------------------------------------------------------------------------------------------

            // 6.Be användaren skriva in ett tal mellan 1 och 7.Skriv ut matchande veckodag.

            Console.WriteLine("Choose a number between 1-7: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("{0} = Monday", day);
            }
            else if (day ==2)
            {
                Console.WriteLine("{0} = Tuseday", day);
            }
            else if (day == 3)
            {
                Console.WriteLine("{0} = Wednesday", day);
            }
            else if (day == 4)
            {
                Console.WriteLine("{0} = Thursday", day);
            }
            else if (day == 5)
            {
                Console.WriteLine("{0} = Friday", day);
            }
            else if (day == 6)
            {
                Console.WriteLine("{0} = Saturday", day);
            }
            else
            {
                Console.WriteLine("{0} = Sunday", day);
            }
            

// ------------------------------------------------------------------------------------------------------------------------

            // 7.Be användaren mata in två textsträngar.
            // Skriv ut om värdena matchar varandra eller inte.

            Console.WriteLine("Please enter one word two times: ");
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            if (firstWord == secondWord)
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("You didn't follow the instructions.");
            }

// ------------------------------------------------------------------------------------------------------------------------


            // 8.Skriv ett program som skriver ut följande information om dig:
            // Namn
            // Ålder
            // Längd
            // Ort
            // Hobby
            // Superkraft

            Console.WriteLine("PLEASE ENTER BELOW INFO: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();
            Console.Write("Height: ");
            string height = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Hobby: ");
            string hobby = Console.ReadLine();
            Console.Write("Superpower: ");
            string sp = Console.ReadLine(); 

            Console.Clear();

            Console.WriteLine("Theese are your answears: ");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", name, age, height, city, hobby, sp );
            
       // ------------------------------------------------------------------------------------------------------------------------

       
            //9. 

            Console.WriteLine("Enter you age:");
            int age9 = Convert.ToInt32(Console.ReadLine());

            if (age9 < 18)
            {
                Console.WriteLine("Du är under 18");
            }
            else if (age9 > 18 && age9 < 65)
            {
                Console.WriteLine("Du är mellan 19 och 65");
            }
            else
            {
                Console.WriteLine("Du är över 65");
            }
         // ------------------------------------------------------------------------------------------------------------------------

            // 10. 
            Console.WriteLine("Enter you age:");
            int age10 = Convert.ToInt32(Console.ReadLine());

            if (age10 < 18)
            {
                Console.WriteLine("Under 18.");
            }
            else
            {
                if (age10 > 18 && age10 < 65)
                {
                    Console.WriteLine("Mellan 19 och 65");
                }
                else
                {
                    Console.WriteLine("Över 65");
                }
            }
           
   // ------------------------------------------------------------------------------------------------------------------------

            // 11.Deklarera en variabel som heter ticketPrice, tilldela valfritt värde.
            // Personer under 12 ska få 30 % rabatt på priset.
            // Personer över 65 ska få 35 % rabatt på priset.
            // Studenter ska få 20 % rabatt på priset.
            // Priset ska beräknas efter input från användaren.
            // Skriv ut originalpriset samt det nya priset i konsolen.

            double ticketPrice = 100;
            double orgPrice = 0; 

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            

            if (age <= 12)
            {
                orgPrice = ticketPrice;
                ticketPrice = orgPrice * 0.7;
                Console.WriteLine("Ticketprice: {0}:- (Org.Price {1}:-)", ticketPrice, orgPrice);
            }
            else if (age > 12 && age < 65)
            {
                Console.Write("Are you a student? [Y/N] ");
                char student = Convert.ToChar(Console.ReadLine());
                if (student == 'Y')
                {
                    orgPrice = ticketPrice;
                    ticketPrice = orgPrice * 0.8;
                    Console.WriteLine("Ticketprice: {0}:- (Org.Price {1}:-)", ticketPrice, orgPrice);
                }
                else
                {
                    Console.WriteLine("Ticketprice: {0}:-", ticketPrice);
                }
            }
            else
            {
                orgPrice = ticketPrice;
                ticketPrice = orgPrice * 0.65;
                Console.WriteLine("Ticketprice: {0}:- (Org.Price {1}:-)", ticketPrice, orgPrice);
            }


            double ticketPrice;
            ticketPrice = 135;
            double tpUnder12 = ticketPrice * 0.7;
            double tpOver65 = ticketPrice * 0.65;
            double tpStudent = ticketPrice * 0.8;

            Console.Write("Hur gammal är du? ");
            int age11 = Convert.ToInt32(Console.ReadLine());

            if (age11 < 12)
            {
                Console.WriteLine("Ordpris: {0}, Under 12: {1}", ticketPrice, tpUnder12);
            }
            else if (age11 >= 64)
            {
                Console.WriteLine("Ordpris: {0}, Över 65: {1}", ticketPrice, tpOver65);
            }
            else
            {
                Console.WriteLine("Är du student? JA/NEJ");
                string student = Console.ReadLine();
                if (student == "JA")
                {
                    Console.WriteLine("Ordpris: {0}, Studentpris: {1}", ticketPrice, tpStudent);
                }
                else
                {
                    Console.WriteLine("Ditt pris: {0}", ticketPrice);
                }
            }

       // ------------------------------------------------------------------------------------------------------------------------

            //12 . Be användaren mata in ett tal.
            // Användaren ska få provision baserat på talet. Över 1000 = 8%
            // Över 500 = 6%
            // Under 500 = 3%
            // Skriv ut procentsatsen samt vad summan blir.

            Console.WriteLine("Hur mycket har du sålt för? ");
            int amount = Convert.ToInt32(Console.ReadLine());
            double over1000 = amount * 0.08;
            double over500 = amount * 0.06;
            double under500 = amount * 0.03;

            if (amount > 1000)
            {
                Console.WriteLine("Provisionen är 8%");
                Console.WriteLine("Din provision är {0}", over1000);
            }
            else if (amount > 500)
            {
                Console.WriteLine("Provisionen är 6%");
                Console.WriteLine("Din provision är {0}", over500);
            }
            else
            {
                Console.WriteLine("Provisionen är 3%");
                Console.WriteLine("Din provision är {0}", under500);
            }

       // ------------------------------------------------------------------------------------------------------------------------

            // 13. Deklarera en boolean som heter bokad, tilldela den värdet false.
            // Ge användaren möjlighet att välja mellan 5 olika filmer.
            // När användaren har valt film ska priset visas samt en fråga om användaren vill boka en biljett.
            // Om användaren väljer att boka biljetten, ändra bokad till true.
            // Skapa en ny if-sats.
            // Skriv ut om biljetten är bokad eller inte. Använd bokad variabeln.


            bool bokad = false;

            Console.WriteLine("Vilken film vill du se?");
            Console.WriteLine("1. Start Wars");
            Console.WriteLine("2. Hungergames");
            Console.WriteLine("3. Sagan om ringen");
            Console.WriteLine("4. Harry potter");
            Console.WriteLine("5. James Bond");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            int starWars = 100;
            int hungergames = 105;
            int saganOmRingen = 110;
            int harryPotter = 115;
            int jamesBond = 120;

            if (userChoice == 1)
            {
                Console.WriteLine("1. Start Wars");
                Console.WriteLine("Pris: {0} ", starWars);
                Console.WriteLine("Vill du boka en biljett? JA/NEJ");
                string ticket = Console.ReadLine();
                if (ticket == "JA")
                {
                    bokad = true;
                }
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("2. Hungergames");
                Console.WriteLine("Pris: {0} ", hungergames);
                Console.WriteLine("Vill du boka en biljett? JA/NEJ");
                string ticket = Console.ReadLine();
                if (ticket == "JA")
                {
                    bokad = true;
                }
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("3. Sagan om ringen");
                Console.WriteLine("Pris: {0} ", saganOmRingen);
                Console.WriteLine("Vill du boka en biljett? JA/NEJ");
                string ticket = Console.ReadLine();
                if (ticket == "JA")
                {
                    bokad = true;
                }
            }
            else if (userChoice == 4)
            {
                Console.WriteLine("4. Harry potter");
                Console.WriteLine("Pris: {0} ", harryPotter);
                Console.WriteLine("Vill du boka en biljett? JA/NEJ");
                string ticket = Console.ReadLine();
                if (ticket == "JA")
                {
                    bokad = true;
                }
            }
            else
            {
                Console.WriteLine("5. James Bond");
                Console.WriteLine("Pris: {0} ", jamesBond);
                Console.WriteLine("Vill du boka en biljett? JA/NEJ");
                string ticket = Console.ReadLine();
                if (answer == "JA")
                {
                    bokad = true;
                }
            }
            if (bokad == true)
            {
                Console.WriteLine("Biljetten är bokad!");
            }
            else
            {
                Console.WriteLine("Du har inte bokat biljett");
            }
   // ------------------------------------------------------------------------------------------------------------------------


            // 14. Deklarera en int med valfritt namn, tilldela ett valfritt värde. (0-10) Be användaren mata in sitt namn.
            // Hälsa användaren välkommen, inkludera namnet.
            // Fråga om spelaren vill spela ett spel.
            // Om inte, avsluta programmet.
            // Om ja, be användaren gissa på vilket tal som är korrekt.
            // Skriv ut något passande beroende på om svaret är rätt eller inte.

            int number = 10;

            Console.Write("Skriv in ditt namn: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Välkommen {0} vill du spela ett spel?", userName);
            string answer = Console.ReadLine();

            if (answer == "Ja")
            {
                Console.Write("Gissa vilket nummer jag tänker på: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Grattis du gissade rätt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, fel gissning :(");
                }
            }
            else
            {
                Console.WriteLine("Okej, hitta på något roligare då");
            }

 // ------------------------------------------------------------------------------------------------------------------------


            //15. Be användaren mata in en ålder.
            // Skriv ut någon av följande baserat på svaret.
            // 0-12 = Barn
            // 13-19 = Ungdom
            // 20-64 = Vuxen
            // 65+ = Pensionär

            Console.Write("Skriv in din ålder: ");
            int age15 = Convert.ToInt32(Console.ReadLine());

            if (age15 <= 12)
            {
                Console.WriteLine("Barn");
            }
            else if (age15 <= 13 && age15 <= 19)
            {
                Console.WriteLine("Ungdom");
            }
            else if (age15 >= 20 && age15 <= 64)
            {
                Console.WriteLine("Vuxen");
            }
            else
            {
                Console.WriteLine("Pensionär");
            }
 // ------------------------------------------------------------------------------------------------------------------------


            //16.  Be användaren mata in ett tal. Skriv ut om talet är jämnt eller inte.

            Console.WriteLine("Skriv in ett tal ");
            int number16 = Convert.ToInt32(Console.ReadLine());

            if (number16 % 2 == 0)
            {
                Console.WriteLine("{0} är ett jämnt tal.", number16);
            }
            else
            {
                Console.WriteLine("{0} är ett udda tal.", number16);
            }
 // ------------------------------------------------------------------------------------------------------------------------


            // 17. Be användaren mata in ett veckonummer (1-52) samt datum (1-31).
            // I tvättstugan i huset där användaren bor får man endast tvätta på udda veckor och jämna datum.
            // Skriv ut om användaren får tvätta eller inte på den valda dagen.


            Console.Write("Skriv in ett veckornr (1-52): ");
            int week = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Skriv in en dag (1-31): ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (week % 2 != 0 && day % 2 == 0)
            {
                Console.WriteLine("Det går bra att tvätta");
            }
            else
            {
                Console.WriteLine("Tyvärr, då du kan inte tvätta");
            }

 // ------------------------------------------------------------------------------------------------------------------------

            // 18. Be användaren skriva in ett årtal. Skriv ut om det är ett skottår eller inte.
            // Regler för skottår:
            // Skottår kan delas med 4
            // Skottår kan inte delas med 100, förutom om det också kan delas med 400.

            Console.WriteLine("Skriv in ett årtal: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0} är ett skottår!", year);
            }
            else
            {
                Console.WriteLine("{0} är inte ett skottår", year);
            }

        }*/
        }
    }
}
