// Radius of circle 
// Enrollment number : 92400527061
// Name  : Nipunsinh Jadeja

using System;


namespace Unit_2_5_ROC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            double roc;

            Console.Write("radius of a circle : ");
            r = Convert.ToInt32(Console.ReadLine());

            roc = 3.14 * r * r;

            Console.WriteLine("radius of a circle: " + roc);

        }
    }
}
