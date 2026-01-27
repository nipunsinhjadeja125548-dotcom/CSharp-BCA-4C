// even and or 
using System;


namespace Unit_3_6_ODDEVEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("number is Even");
            }
            else
            {
                Console.WriteLine("number is Odd");
            }
        }
    }
}
