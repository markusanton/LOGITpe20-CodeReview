using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            Console.WriteLine("Enter your username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string userPassword = Console.ReadLine();

            if (userName == "user" && userPassword == "user1234")
            {
                Console.WriteLine("Welcome.");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
    }
}
