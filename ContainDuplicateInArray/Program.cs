////Question - Given an array, determine if the array contains an element more than once
//// For Ex-
//// char[] array1 = [1,2,3,1];
//// should return true
//// char[] array1 = [1,2,3,4];
//// should return false


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.ContainDuplicateInArray
//{
//    internal class Program
//    {
//        static int[] Nums = [1, 2, 3, 4];

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Given an array of elements, determine if the array contains an element more than once");
//            Console.Write("Input - [");
//            foreach (var item in Nums)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            var result = SolutionOne_UseHashSet.ContainDuplicates(Nums);

//            Console.WriteLine(result);
//        }
//    }
//}
