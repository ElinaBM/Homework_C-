using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber_ConditionalStatements_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            double number;
            List<double> numberList = new List<double>();

            for (int i = 1; i < 4; i++)
            {

                string ordInd = GetOrdinalIndicator(i);

                Console.WriteLine("Please enter a {0}{1} number!", i, ordInd);

                while (double.TryParse(Console.ReadLine(), out number) == false)
                {
                    Console.WriteLine("This is not a number. Please enter number!");
                }

                numberList.Add(number);

            }

            Console.WriteLine("Largest numbers is " + numberList.Max().ToString());
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();


        }

        private static string GetOrdinalIndicator(int number)
        {
            string ordinalIndicator;


            switch (number)
            {
                case 1:
                    ordinalIndicator = "st";
                    break;

                case 2:
                    ordinalIndicator = "nd";
                    break;
                case 3:
                    ordinalIndicator = "rd";
                    break;

                default:
                    ordinalIndicator = "th";
                    break;

            }



            return ordinalIndicator;
        }


    }
}

