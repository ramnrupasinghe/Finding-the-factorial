using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace finding__product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again = "";
            do {
                Console.WriteLine("Enter a number");
                BigInteger number;

                while (!BigInteger.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                BigInteger product = 1;
                for (BigInteger i = 1; i <= number; i++)
                {
                    product *= i;
                }

                Console.WriteLine("The product of " + number + " is: " + product);

                Console.Write("Do you want to get product for another number? (Y/N) ");
                again = Console.ReadLine();

                while (!(again.ToUpper() == "Y" || again.ToUpper() == "N"))
                {

                    Console.Write("Invalid input. Please enter Y or N: ");
                    again = Console.ReadLine();

                }

            } while (again.ToUpper() == "Y");

            if (again.ToUpper() == "N")
            {
                Console.WriteLine("Please press enter key to end...");
                Console.ReadLine();
            }
                     
        }
    }
}
