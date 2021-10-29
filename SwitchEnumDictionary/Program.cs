using System;
using System.Collections.Generic;

namespace SwitchEnumDictionary
{
    class Program
    {
        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday, 
        }

        static void Main(string[] args)
        {
            /*
            // 1. 1. Be användaren skriva in ett tal. (1–7)
            // Skriv ut veckodagen det motsvarar med hjälp av en switch-sats.

            Console.WriteLine("Vilken dag är din favoritdag? Ange en siffra mellan 1-7.");
            int dag = Convert.ToInt32(Console.ReadLine()); 

            switch (dag)
            {
                case 1:
                Console.WriteLine("Måndag!");
                    break;
                case 2:
                    Console.WriteLine("Tisdag!");
                    break;
                case 3:
                    Console.WriteLine("Onsdag!");
                    break;
                case 4:
                    Console.WriteLine("Torsdag!");
                    break;
                case 5:
                    Console.WriteLine("Fredag!");
                    break;
                case 6:
                    Console.WriteLine("Lördag!");
                    break; 
                default:
                    Console.WriteLine("Söndag!");
                    break;
            }
           
         // ------------------------------------------------------------------------------------------------------

            // 2. Be användaren skriva in ett tal. (1–7)
            // Skriv ut veckodagen det motsvarar med hjälp av en switch-sats.
            // Veckodagen ska vara lagrad i Enum.

            Console.WriteLine("Choose a number between 1-7: ");
            int weekday = Convert.ToInt32(Console.ReadLine());

            switch (weekday)
            {
                case 1:
                    Console.WriteLine(Weekdays.Monday);
                    break;
                case 2:
                    Console.WriteLine(Weekdays.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(Weekdays.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(Weekdays.Thursday);
                    break;
                case 5:
                    Console.WriteLine(Weekdays.Friday);
                    break;
                case 6:
                    Console.WriteLine(Weekdays.Saturday);
                    break;
                default:
                    Console.WriteLine(Weekdays.Sunday);
                    break;
            }
            
         // ------------------------------------------------------------------------------------------------------

            // 3. Be användaren skriva in ett tal. (1–7)
            // Skriv ut veckodagen det motsvarar med hjälp av en switch-sats.
            // Veckodagen ska vara lagrad i Enum och hämtas med GetName.

            Console.WriteLine("Choose a number between 1-7: ");
            int weekday = Convert.ToInt32(Console.ReadLine());

            switch (weekday)
            {
                case 1:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 1));
                    break;
                case 2:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 2));
                    break;
                case 3:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 3));
                    break;
                case 4:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 4));
                    break;
                case 5:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 5));
                    break;
                case 6:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 6));
                    break;
                default:
                    Console.WriteLine(Enum.GetName(typeof(Weekdays), 7));
                    break;
            }
            

         // ------------------------------------------------------------------------------------------------------

            // 4. Skapa en tom dictionary som ska innehålla integer och string.
            // Använd en loop för att lägga till varje veckodag.
            // Nyckeln ska vara den int som motsvarar dagen.

            Dictionary<int, string> weekdays = new Dictionary<int, string>() { };

            for (int i = 1; i <= 7; i++) // Vi skapar en int i som till en början är 1, loopen pågår tills i är mindre/lika med 7, i ökas med 1 varje iteration. 
            {
                Console.WriteLine("Skriv namn för veckodag nr: {0}", i);
                string day = Console.ReadLine();

                weekdays.Add(i, day); // För varje iteration adderas nyckeln och värdet till listan. Första rundan 1 samt det som användaren skriver in och lagrar i stringen day, Måndag. 
            }

            Console.WriteLine("Alla lagrade värden i Dictionaryn är: ");
            foreach (KeyValuePair<int, string> item in weekdays) // För varje nyckel med värde, i dictionaryn weekdays.
            {
                Console.WriteLine("Key: {0} Value: {1}", item.Key, item.Value); // Ropa på nyckel, respektive värde genom att skriva item.Key, item.Value
            }
             

         // ------------------------------------------------------------------------------------------------------

            // 5.Be användaren skriva in ett tal. (1–7)
            // Lagra i en variabel veckodagen det motsvarar med hjälp av dictionary, alltså hämta upp motsvarande ur dictionary med hjälp av userinput. 

            Dictionary<int, string> dictionaryAddWeekday = new Dictionary<int, string>() { { 1, "Mon" }, { 2, "Tue" }, { 3, "Wed" }, { 4, "Thur" }, { 5, "Fri" }, { 6, "Sat" }, { 7, "Sun" } }; 

            Console.Write("Enter a number between 1-7:");
            int nrOfDay = Convert.ToInt32(Console.ReadLine());

            string day = dictionaryAddWeekday[nrOfDay];

            Console.WriteLine("String stored in Dictionary with Key: {0} is: {1}",nrOfDay, day);
          

         // ------------------------------------------------------------------------------------------------------


            // 6.Be användaren skriva in ett tal. (1–12).
            // Lagra i en variabel hur många dagar motsvarande månad har.
            // Skriv ut antalet dagar.
            // Används en switch-sats.

            Console.Write("Enter at number between 1-12: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int days = 0; // En variabel som lagrar antal dagar att återanvända i switch-satsen.

            switch (userInput)
            {
                case 1: days = 31; break; // Om userInput är 1 ändras värdet i days till 31
                case 2: days = 28; break;
                case 3: days = 31; break;
                case 4: days = 30; break;
                case 5: days = 31; break;
                case 6: days = 30; break;
                case 7: days = 31; break;
                case 8: days = 31; break;
                case 9: days = 30; break;
                case 10: days = 31; break;
                case 11: days = 30; break;
                case 12: days = 31; break;
                default: break;
            }

            Console.WriteLine("Month nr {0} has {1} days.",userInput, days); // Skriver ut vilket nr användaren valde samt vilket värde days har, alltså antal dagar.
            
          // ------------------------------------------------------------------------------------------------------

            // 7. Be användaren skriva in en månad.
            // Lagra i en variabel hur många dagar motsvarande månad har.
            // Skriv ut antalet dagar.
            // Använd dictionary.

            Dictionary<string, int> daysInMonth = new Dictionary<string, int>() { { "Jan", 31 }, { "Feb", 28 }, { "Mars", 31 }, { "Apr", 30 }, { "May", 31 }, { "June", 30 }, { "July", 31 }, { "Aug", 31 }, { "Sept", 30 }, { "Oct", 31 }, { "Nov", 30 }, { "Dec", 31 } };

            Console.Write("Choose a month [Jan, Feb, Mars, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec]: ");
            string month = Console.ReadLine(); // Detta är nyckelvärdet i dictionaryn. 

            int days = daysInMonth[month]; // I Variablen days lägger vi in antal dagar infrån ovan dictionary med hjälp av userinput. Namnet på Dictionaryn och vilken nyckel vi ska använda.

            Console.WriteLine("{0} has {1} days :) ", month, days); // Det lagrade värdet i ovan nyckel skrivs ut

           // ------------------------------------------------------------------------------------------------------

            // 8. Be användaren skriva in en månad.
            // Skriv ut hur många dagar motsvarande månad har.
            // Används en switch-sats och dictionary.

            Dictionary<string, int> monthDays = new Dictionary<string, int>() { { "Jan", 31 }, { "Feb", 28 }, { "Mars", 31 }, { "Apr", 30 }, { "May", 31 }, { "June", 30 }, { "July", 31 }, { "Aug", 31 }, { "Sept", 30 }, { "Oct", 31 }, { "Nov", 30 }, { "Dec", 31 } };

            Console.Write("Choose a month [Jan, Feb, Mars, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec]: ");
            string month = Console.ReadLine(); // Detta är nyckelvärdet i dictionaryn.

            Console.Write("Number of days in {0} is: ", month);
            switch (month) // Nyckeln är month
            {
                case "Jan": Console.WriteLine(monthDays[month]); break;  // Om month är "Jan", Skriv ut(Namnet på dictionaryn[nyckelvärdet])
                case "Feb": Console.WriteLine(monthDays[month]); break;
                case "Mars": Console.WriteLine(monthDays[month]); break;
                case "Apr": Console.WriteLine(monthDays[month]); break;
                case "May": Console.WriteLine(monthDays[month]); break;
                case "June": Console.WriteLine(monthDays[month]); break;
                case "July": Console.WriteLine(monthDays[month]); break;
                case "Aug": Console.WriteLine(monthDays[month]); break;
                case "Sept": Console.WriteLine(monthDays[month]); break;
                case "Oct": Console.WriteLine(monthDays[month]); break;
                case "Nov": Console.WriteLine(monthDays[month]); break;
                case "Dec": Console.WriteLine(monthDays[month]); break;
                default: break;
            }

           // ------------------------------------------------------------------------------------------------------
            

            // 9.Be användaren skriva in två tal.
            // Be användaren välja operator. (+-* /)
            // Använd en switch-sats och lagra resultatet av uträkningen i en variabel. Skriv ut resultatet.

            Console.WriteLine("Please enter two numbers: ");
            double num1 = Convert.ToInt32(Console.ReadLine()); 
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose operator: + - * / : ");
            char operatorChoice = Convert.ToChar(Console.ReadLine());

            double result = 0; // Variabel som lagrar resultatet. 

            Console.Clear(); //Rensar consolen

            switch (operatorChoice)
            {
                case '+': // Om användaren har valt +:
                    result = num1 + num2;  // De två inmatade talen adderas och värdet lagras i variabeln result  
                    break; // Switch-satsen avbryts
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;

                default:
                    break;
            }
          
            Console.WriteLine("{0} {1} {2} = {3}",num1, operatorChoice, num2, result); // Värdet skrivs ut

          // ------------------------------------------------------------------------------------------------------
           

            // 10.Be användaren skriva in ett tal.
            // Använd en switch-sats för att skriva ut om talet är jämnt eller inte.

            Console.WriteLine("Please enter a number to tell if its even or odd: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); //Rensar consolen

            switch (number%2)
            {
                case 0:
                    Console.WriteLine("{0} is an even number :) ", number);
                    break; 

                default:
                    Console.WriteLine("{0} is an odd number :) ", number); 
                    break;
            }
            
            // ------------------------------------------------------------------------------------------------------

            // 11.Be användaren skriva in en bokstav.
            // Används en switch-sats för att skriva ut om det är en vokal eller konsonant.

            Console.WriteLine("Enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine()); 

            switch (letter)
            {
                case 'a':
                case 'o':
                case 'u':
                case 'å':
                case 'e':
                case 'i':
                case 'y':
                case 'ä':
                case 'ö':
                    Console.Clear(); 
                    Console.WriteLine("{0} is a vocal", letter);
                    break;

                default:                                            // Om inget av ovan case stämmer, skriv ut detta. 
                    Console.Clear();
                    Console.WriteLine("{0} is a consonant", letter);
                    break;
            }

            // ------------------------------------------------------------------------------------------------------
            

            // 12. Be användaren skriva in två tal.
            // Använd en switch-sats för att skriva ut vilket tal som är störst.

            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (num1>num2) //Skicka med inmatningarna från användaren som villkor.
            {
                case true: //Stämmer villkoret i inmatningen
                    Console.WriteLine("{0} is the highest number.",num1 );
                    break;

                default: //Om det ej stämmer
                    Console.WriteLine("{0} is the highest number", num2);
                    break;
            }
           
            // ------------------------------------------------------------------------------------------------------
            

            // Skapa två dictionaries.Båda ska ha string som nyckel och double som värde.
            // Gör en dictionary för frukt samt pris på en veckodag. 
            // Gör en dictionary för frukt samt pris på en helgdag. 
            // Be användaren skriva in vilken dag det är. (1-7)
            // Be användaren skriva in vilken frukt den vill handla.
            // Be användaren skriva in antal av den valda frukten.
            // Skriv ut det totala priset, baserat på antal och dag.

            Dictionary<string, double> weekdays = new Dictionary<string, double>()
            {
                {"Banana", 2.50 },
                {"Apple", 1.20 },
                {"Orange", 0.85 },
                {"Grapefruit", 1.45 },
                {"Kiwi", 2.70 },
                {"Pineapple", 5.50 },
                {"Grapes", 3.85 }
            };

            Dictionary<string, double> weekends = new Dictionary<string, double>()
            {
                {"Banana", 2.70 },
                {"Apple", 1.25 },
                {"Orange", 0.90 },
                {"Grapefruit", 1.60 },
                {"Kiwi", 3.00 },
                {"Pineapple", 5.60 },
                {"Grapes", 4.20 }
            };

            Console.WriteLine("On what day do you want to make your purchase? (Enter a number 1-7)");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What kind of fruit would you like to buy? Banana, Apple, Orange, Grapefruit, Kiwi, Pineapple or Grapes.");
            string fruit = Console.ReadLine(); // Detta blir nyckeln.
            Console.WriteLine("Enter qty: ");
            int qty = Convert.ToInt32(Console.ReadLine()); // Antal att räkna med

            double price; 

            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    price = weekdays[fruit] * qty; // Hämtar nyckeln fruit i dictionary weekdays och gångrar med antalet
                    break; 
                default:
                    price = weekends[fruit] * qty;
                    break;
            }
            Console.WriteLine("{0} {1}, will cost: {2}", qty, fruit, price);

           // ------------------------------------------------------------------------------------------------------

            // 14.Be användaren skriva in ett tal. (0–10)
            // Använd en switch-sats för att skriva ut rätt betyg.

            Console.WriteLine("What was your score on the test? (0-10)");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your grade is: ");
            switch (score)
            {
                case 0:
                case 1: 
                    Console.WriteLine("F"); 
                    break;
                case 2:
                case 3:
                    Console.WriteLine("E");
                    break; 
                case 4:
                case 5:
                    Console.WriteLine("D");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("C");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("A");
                    break;
            }
          

            // ------------------------------------------------------------------------------------------------------

            //15. Skapa en dictionary med alla veckodagar.
            // Använd valfri loop för att, i en ny dictionary, byta plats på nyckel och värde.

            Dictionary<int, string> weekdays = new Dictionary<int, string>()
            {
                {1, "Monday"},
                {2, "Tuesday"},
                {3, "Wednesday"},
                {4, "Thursday"},
                {5, "Friday"},
                {6, "Saturday"},
                {7, "Sunday"}
            };

            foreach (KeyValuePair<int, string> item in weekdays) // Skriver ut hela Dictionary weekdays
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(); // Tom rad



            Dictionary<string, int> switchedValues = new Dictionary<string, int>() { }; // Tom dictionary med string som key och int som value
            foreach (KeyValuePair<int, string> item in weekdays) // För varje int och sting i Dictionary weekdays
            {
                switchedValues.Add(item.Value, item.Key); //Lägg till value i switchedValues (Blir nyckel), Lägg till key (Blir value)
            }

            foreach (KeyValuePair<string, int> item in switchedValues) // skriver ut hela Dictionary switched values
            {
                Console.WriteLine(item);
            }

           // ------------------------------------------------------------------------------------------------------

            // 16.Bygg vidare på övning 15.
            // Efter att du lagt till varje ny nyckel & värde i din andra dictionary, radera samma värden ur den första.


            foreach (KeyValuePair<int, string> item in weekdays)
            {
                weekdays.Remove(item.Key);
                Console.WriteLine(weekdays.Count);
            }
            Console.WriteLine("First Dictionary now contains {0} values.", weekdays.Count);
              */
        }
    }
}
