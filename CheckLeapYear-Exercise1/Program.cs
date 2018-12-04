using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CheckLeapYear_ConditionalStatements_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            int year;

            Console.WriteLine("Please enter a year!");

            while (int.TryParse(Console.ReadLine(), out year) == false)
            {
                Console.WriteLine("Please enter year as a number!");
            }


            if (DateTime.IsLeapYear(year) == true)
            {
                Console.WriteLine("This is a leap year!");
            }

            else
            {
                Console.WriteLine("This is not a leap year!");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();


        }
    }
}

