using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzales_UsingControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // clear screen when program starts

            Console.WriteLine("This program will determine what type of number and display its range.");
            Console.Write("\nEnter a number: ");
            string input = Console.ReadLine();
            int number;

            // OUTPUT 1: Process first input and display range for even number
            if (int.TryParse(input, out number))  // check if input is numeric
            {
                if (number % 2 == 0) // check if number is even
                {
                    Console.WriteLine($"\n{number} is even."); // show number type
                    Console.WriteLine($"\nHere is the range from {number} to 1:"); // display range
                    for (int i = number; i >= 1; i--)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    // OUTPUT 3: Odd number show error message then program continues to try-again
                    Console.WriteLine("\nSorry, I can't provide a range for odd numbers.");
                }
            }
            else
            {
                // OUTPUT 3: Non-numeric input → show error message then program continues to try-again
                Console.WriteLine("\nThe value you entered is not a number. Please try typing a numeric input.");
            }

            // OUTPUT 2: Ask the user if they want to continue and handle response
            Console.Write("\nDo you want to try again? (y/n): ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "y")
            {
                Console.Clear();  //  CLEAR SCREEN
                Main(args);       //  START PROGRAM AGAIN
            }
            else if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("\nThank you for using this program! Hope you had fun exploring numbers.");  // normal end
            }
            else
            {
                // OUTPUT 3: Irrelevant input for try-again show error message and end
                Console.WriteLine("\nInvalid input. Program will now close.");
            }

            Console.ReadKey();

        }
    }
}
    
