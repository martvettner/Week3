using System;

namespace PercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum;
            int UserScore;
            double result;

            Console.WriteLine("What is your maximum score?");
            maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("what is your score?");
            UserScore = Int32.Parse(Console.ReadLine());
            result = (UserScore * 100) / maximum;

            Console.WriteLine($"You scored {result}%.");
           if (result >= 90)
            {
                Console.WriteLine("your grade is 5");
            }
           else if (result >= 80)
               
            {
                Console.WriteLine("your grade is 4");
            }
            else if (result >= 61)

            {
                Console.WriteLine("your grade is 3");
            }
           else
            {
                Console.WriteLine("your grade is 2");
            }
        }
    }
}