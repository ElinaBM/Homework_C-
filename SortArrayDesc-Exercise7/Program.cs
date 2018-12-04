using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayDesc_Exercise7 {
    class Program {
        static void Main(string[] args) {
            int length, element;


            Console.WriteLine("We will create an array of integer type elements!" + "\n" + "Enter length of your Array:");

            while (int.TryParse(Console.ReadLine(), out length) == false) {
                Console.WriteLine("You need to enter whore number. Please enter length: ");
            }
            Console.WriteLine();

            int[] integerArray = new int[length];

            for (int i = 0; i < length; i++) {
                Console.WriteLine("Write array element:");
                while (int.TryParse(Console.ReadLine(), out element) == false) {
                    Console.WriteLine("Your entered value is not integer. Please enter integer value!");
                }
                integerArray[i] = element;
            }

            Array.Sort(integerArray);
            Array.Reverse(integerArray);

            Console.WriteLine("\nArray elements in descending order are: ");

            foreach (int el in integerArray) {
                Console.WriteLine(el);
            }

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();

        }

    }
}

