//// Question - Given two sorted arrays create an array which merges the two and preserves sorting
//// For Ex - Array1 = [ 0, 3, 4, 31] Array2 = [4, 6, 30] This should be merged as
//// ResultArray = [0, 3, 4, 4, 6, 30, 31]

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.MergeSortedArrays
//{
//    internal class Program
//    {
//        static int[] Array1 = [0, 3, 4, 31];
//        static int[] Array2 = [4, 6, 30];

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Merge Sorted Arrays");

//            var mergedArray = SolutionOne_UseArrays.MergeAndPreserveSorting(Array1, Array2);

//            Console.Write("Merged Array - [ ");
//            foreach (var item in mergedArray)
//            {
//                Console.Write(item + " ");
//            }
//            Console.Write("]");

//        }

//    }
//}
