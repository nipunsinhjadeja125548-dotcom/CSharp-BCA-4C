// Compound Interest 
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja

using System;


namespace Unit_2_4__CompoundInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p, r, t, ci, a, n;

            Console.Write("amount:  ");
            p = double.Parse(Console.ReadLine());

            Console.Write("rate:  ");
            r = double.Parse(Console.ReadLine());

            Console.Write("time:  ");
            t = double.Parse(Console.ReadLine());

            Console.Write("compounding year: ");
            n = double.Parse(Console.ReadLine());

            a = p * Math.Pow((1 + r / n), n * t);
            ci = a - p;

            Console.WriteLine("Compound Interest: " + ci);
        }
    }
}
