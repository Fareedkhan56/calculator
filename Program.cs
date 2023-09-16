using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string value;

            do
            {
                Console.Write("Enter First Value : ");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter symbol '+, -, 8, /, %' : ");
                string symbol = Console.ReadLine();

                Console.Write("Enter Secnod Value : ");
                int secondValue = Convert.ToInt32(Console.ReadLine());

                int result;

                switch (symbol)
                {
                    case "+":
                        result = firstValue + secondValue;
                        Console.WriteLine("here is result {0}", result); break;

                    case "-":
                        result = firstValue - secondValue;
                        Console.WriteLine("here is result {0}", result); break;

                    case "*":
                        result = firstValue * secondValue;
                        Console.WriteLine("here is result {0}", result); break;

                    case "/":
                        result = firstValue / secondValue;
                        Console.WriteLine("here is result {0}", result); break;

                    case "%":
                        result = firstValue % secondValue;
                        Console.WriteLine("here is result {0}", result); break;

                    default:
                        Console.Write("something wrong in input"); break;
                }
                Console.WriteLine("Do you want to continue (y,n)");
                value = Console.ReadLine();
            } while (value == "y" || value == "Y");
            

            Console.ReadLine();
        }
    }
}
