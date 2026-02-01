// Arithmetic operator
// Enrollment number : 92400527061
// Name : Nipunsinh Jadeja
using System;


namespace Unit_2_2_Arithmrtie
{
    internal class Program
    {
        static void Main()
        {
            int no1, no2;
            char op;

            Console.Write("Enter first number: ");
            no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            no2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("addition: " + (no1 + no2));
            }
            else if (op == '-')
            {
                Console.WriteLine("subtration: " + (no1 - no2));
            }
            else if (op == '*')
            {
                Console.WriteLine("multiplition: " + (no1 * no2));
            }
            else if (op == '/')
            {
                Console.WriteLine("division: " + no1 / no2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}
