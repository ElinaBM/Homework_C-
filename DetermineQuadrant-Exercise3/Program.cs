using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineQuadrant_ConditionalStatements_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Please write X coordinate:");
            while (double.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("Entered value is not a number. Please enter a number!");
            }

            Console.WriteLine("Please write Y coordinate:");
            while (double.TryParse(Console.ReadLine(), out y) == false)
            {
                Console.WriteLine("Entered value is not a number. Please enter a number!");
            }

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Given coordinates are in 1st quadrant.");
                }
                else
                {
                    Console.WriteLine("Given coordinates are in 4th quadrant.");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Given coordinates are in 2nd quadrant.");
                }
                else
                {
                    Console.WriteLine("Given coordinates are in 3rd quadrant.");
                }
            }
            Console.ReadLine();
        }
    }
}

