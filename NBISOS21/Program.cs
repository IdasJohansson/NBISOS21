using System;

namespace Vecka1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tre tal:  ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int tal3 = Convert.ToInt32(Console.ReadLine());

            int sum = tal1 + tal2 + tal3;

            Console.WriteLine(sum);

            if (tal1 > tal2 && tal1 > tal3)
            {
                Console.WriteLine(tal1);
            }
            if (tal2 > tal1 && tal2 > tal3)
            {
                Console.WriteLine(tal2);
            }
            else
            {
                Console.WriteLine(tal3);
            }
        }
    }
}
