using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please start inserting arrays:");

            int numberOfArrays;
            while (!int.TryParse(Console.ReadLine(), out numberOfArrays) || numberOfArrays <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of arrays:");
            }

            long product = 1;
            bool productCalculated = false;

            for (int i = 0; i < numberOfArrays; i++)
            {
                Console.WriteLine($"Enter array #{i + 1}:");

                int arrayLength;
                while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer for the array length:");
                }

                int[] array = new int[arrayLength];
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write($"Enter element #{j + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out array[j]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer for the array element:");
                    }
                }

                if (i < arrayLength)
                {
                    product *= array[i];
                    productCalculated = true;
                }
            }

            if (productCalculated)
            {
                Console.WriteLine($"Output: Product of the n-th elements = {product}");
            }
            else
            {
                Console.WriteLine("No valid product calculation was possible based on the inputs provided.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
