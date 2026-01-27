using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3_10_Prime
{
    internal class Program
    {
        static void Main()
        {
            int num,i;
            bool isPrime = true;

            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine("The number is Prime");
            else
                Console.WriteLine("The number is Not Prime");
        }
    }
}
