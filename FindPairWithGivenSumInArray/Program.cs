////Question - Given an array of integers write a function that  tells user whether it has a pair of 
//// items with given sum
//// For Ex-
//// char[] array1 = [1, 2, 3, 4]; Sum = 8;
//// should return false
//// char[] array2 = [1, 2, 4, 4]; Sum = 8
//// should return true

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindPairWithGivenSumInArray
//{
//    internal class Program
//    {
//        static readonly int[] Numbers = new int[] { 1, 2, 4, 4 };
//        const int Sum = 6;

//        public static void Main(string[] args)
//        {

//            Console.WriteLine("Find Pair With Given Sum In Array");
            
//            // Inefficient O(n^2)
//            var result1 = SolutionOne_Naive.FindPairWithGivenSumInArray(Numbers, Sum);
//            Console.WriteLine(result1);

//            // Efficient O(n)
//            var result2 = SolutionTwo_Efficient.FindPairWithGivenSumInArray(Numbers, Sum);
//            Console.WriteLine(result2);

//        }

//    }
//}
