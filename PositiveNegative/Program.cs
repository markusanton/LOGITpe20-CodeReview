using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            Console.WriteLine("Enter your number: ");
            var userInput = Int32.Parse(Console.ReadLine());

            if (userInput > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else if (userInput < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else if (userInput == 0)
            {
                Console.WriteLine("You entered 0, please enter another number.");
            }
            else
            {
                Console.WriteLine("Please try again.");
            }

        }
    }
}
