//// Question - Given an array of integers write a function that  moves all zeros to the end of array 
//// items with given sum
//// For Ex-
//// int[] array1 = [0, 1, 0, 3, 12]
//// output = [1, 3, 12, 0, 0]

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.MoveZerosFromArray
//{
//    internal class Program
//    {
//        static int[] Nums = [0, 1, 0, 3, 12];

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Given an array of numbers, move the array in place such that all 0s are at the end");

//            Console.Write("Input - [");
//            foreach (var item in Nums)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            //var result = SolutionOne_Naive.MoveZerosToEnd(Nums);

//            var result = SolutionTwo_MoveArrayInPlace.MoveZerosToEnd(Nums);

//            //var result = SolutionTwo_MoveArrayInPlace.MoveZerosToStart(Nums);

//            Console.Write("Output - [");

//            foreach (var item in result)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//        }

//    }
//}
