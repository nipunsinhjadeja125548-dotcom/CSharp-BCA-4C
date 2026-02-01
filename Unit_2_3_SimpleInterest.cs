// Simplr Interest 
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja

using System;


namespace Unit_2_3_SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p, r, t, si;


            Console.Write("amount:  ");
            p = float.Parse(Console.ReadLine());

            Console.Write("rate:  ");
            r = float.Parse(Console.ReadLine());

            Console.Write("time:  ");
            t = float.Parse(Console.ReadLine());

            si = p * r * t / 100;

            Console.WriteLine(" simple Interest: " + si);
        }
    }
}
