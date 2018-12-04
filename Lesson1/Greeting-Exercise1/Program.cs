using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int number;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            surname = Console.ReadLine();

            Console.WriteLine("Enter a number");

            while (int.TryParse(Console.ReadLine(), out number) == false)
                
            {
                Console.WriteLine("You neet to enter number!!! Enter a number");   
            }
                        
                //Console.WriteLine("Hello, "+ name + " "+ number);
                Console.WriteLine("Hello, {0} {1}. You have entered number {2}.", name, surname, number);
                Console.WriteLine("Press any key to exit.");
                Console.Read();
            
        }
    }
}
