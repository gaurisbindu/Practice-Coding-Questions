using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.FindFactorialUsingRecursion
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Find Factorial using recursion");
            Console.WriteLine("---------------------------------");

            const int number = 5;
            var result = FindFactorialUsingRecursion(number);
            Console.WriteLine($"The factorial of {number} is {result}");
           
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Find Factorial using iteration");
            Console.WriteLine("---------------------------------");

            result = FindFactorialUsingIteration(number);
            Console.WriteLine($"The factorial of {number} is {result}");
        }

        public static int FindFactorialUsingRecursion(int number)
        {
            if(number == 0)
                return 1;

            if(number <= 2)
                return number;

            return number * FindFactorialUsingRecursion(number - 1);
        }

        public static int FindFactorialUsingIteration(int number)
        {
            if (number == 0)
                return 1;

            if (number < 2)
                return number;

            var result = 1;
            for(int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
