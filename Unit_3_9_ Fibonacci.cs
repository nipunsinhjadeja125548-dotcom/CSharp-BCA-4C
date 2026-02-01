// Fibonacci series up to a number inputted by user
// Enrollment number : 924007061
// Name : Nipunsinh Jadeja


using System;

namespace Unit_3_9__Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 1, c, i;

            Console.Write("Enter number : ");
            i = Convert.ToInt32(Console.ReadLine());

            while (a <= i)
            {
                Console.Write(a + " ");
               
                c = a + b;
                a = b;
                b = c;
            }
        }



    }
}
