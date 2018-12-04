using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number.");
            while(int.TryParse(Console.ReadLine(), out number)==false)
            {
                Console.WriteLine("This is not a number. Please enter a number");
               
            }
            Console.WriteLine("Multiplication Table:");

            for (int i=1; i<11; i++)
            {
                Console.WriteLine("{0} * {1} = " + number * i, number, i);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
