using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, number4;

            List<double> numberList = new List<double>();

            do
            {
                Console.WriteLine("Write number: ");
                double.TryParse(Console.ReadLine(), out number1);
                Console.WriteLine("Enter another? Y or N");
                numberList.Add(number1);
            }

            while (Console.ReadLine().ToUpper() == "Y");
 

            double average = CalculateAverage(numberList);
            Console.WriteLine("The average value of your entered numbers is " + average);
            Console.ReadLine();
            
        
        }

        private static double CalculateAverage(List<double> list)
        {
            double avg;
            avg = list.Average();
            return avg ;
        }
        
    }
}
