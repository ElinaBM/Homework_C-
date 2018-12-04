using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSeries_Exercise5 {
    class Program {
        static void Main(string[] args) {

            int numberOfSeries, sumOfSeries, number;
            number = 1;
            sumOfSeries = 0;

            Console.WriteLine("Enter number of lines."+"\n");

            while (int.TryParse(Console.ReadLine(), out numberOfSeries) == false) {
                Console.WriteLine("Entered value is not a whole nomer. Please enter a whole number.");
            }
            Console.WriteLine();
            for (int i = 0; i < numberOfSeries; i++) {
                Console.Write(number);
                if (i < numberOfSeries-1) {
                    Console.Write(" + ");
                }
               
                sumOfSeries = sumOfSeries + number;
                number = number*10 + 1;

            }

            Console.WriteLine("\n\nSum of series is {0}", sumOfSeries);
            Console.ReadLine();

        }
    }
}
