using System;
using System.Linq;

namespace Activity_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Corrected the size of the array to 8 to include numbers from 0 to 7
            int[] numbers = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1}", num);
            }

            // Wait for user input before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}