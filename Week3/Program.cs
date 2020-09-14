using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login;
            string Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if ((Login == "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("Welcome!");
            }else if ((Login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("your password is incorrect");
            }else if ((Login != "admin") && ( Password == "pass1234"))
            {
                Console.WriteLine("the login is incorrect");
            }else
            {
                Console.WriteLine("you shall not pass");
            }
        }
    }
}
