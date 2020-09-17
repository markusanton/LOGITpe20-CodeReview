using System;
using System.Runtime.InteropServices;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user to enter two numbers and prints out the sum of these numbers*/
            Console.WriteLine("Enter your first number: ");
            int userNumber1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your second number: ");
            int userNumber2 = Int32.Parse(Console.ReadLine());

            int sumResult = userNumber1 + userNumber2;

            Console.WriteLine($"{userNumber1} + {userNumber2} = {sumResult}");
        }
    }
}
