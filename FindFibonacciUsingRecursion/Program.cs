//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindFactorialUsingRecursion
//{
//    internal class Program
//    {
//        public static void Main(string[] args) 
//        {
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Find Fibonacci using recursion");
//            Console.WriteLine("---------------------------------");

//            const int index = 43;
//            var result = FindFibonacciAtIndexRecursive(index);
//            Console.WriteLine($"The number in Fibonnaci sequence at {index} is {result}");
           
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("Find Factorial using iteration");
//            Console.WriteLine("---------------------------------");

//            result = FindFibonacciAtIndexIterative(index);
//            Console.WriteLine($"The number in Fibonnaci sequence at {index} is {result}");
//        }

//        // Time complexity - O(2^n) - Exponential
//        public static int FindFibonacciAtIndexRecursive(int index)
//        {
//            if( index < 0 )
//            {
//                throw new ArgumentOutOfRangeException("index");
//            }

//            if(index <= 1)
//            {
//                return index;
//            }

//            return FindFibonacciAtIndexRecursive(index - 2) + FindFibonacciAtIndexRecursive(index - 1);
//        }

//        // Time complexity - O(n) - Linear
//        public static int FindFibonacciAtIndexIterative(int index)
//        {
//            var fib = new List<int>() { 0, 1 };
//            for(int i = 2; i <= index; i++)
//            {
//                fib.Add(fib[i - 2] + fib[i - 1]);
//            }

//            return fib[index];
//        }
//    }
//}
