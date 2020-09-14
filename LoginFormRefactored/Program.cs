using System;

namespace LoginFormRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login, Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if(Login == "admin" &&  Password == "pass123")
            {
                Console.WriteLine("Welcome, Admin");
            }else
            {
                Console.WriteLine("Login failed. Try again.");
            }

        }
    }
}
