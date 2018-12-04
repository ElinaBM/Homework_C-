using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeNumbers_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, tempNumber;

            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine("Your entered 1st number is {0} and your entered 2nd number is {1}.", number1, number2);

            tempNumber = number1;
            number1 = number2;
            number2 = tempNumber;

            Console.WriteLine("Numbers have been switched! Now 1st number is {0} and 2nd number is {1}", number1, number2);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
     
    }
}
