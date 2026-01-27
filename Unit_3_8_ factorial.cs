//  find factorial of a given number
using System;

namespace Unit_3_8__factorial
{
    internal class Program
    {
        static void Main()
        {
            int num, fact = 1,i;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}
