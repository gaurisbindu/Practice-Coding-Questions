//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindFirstOccuranceOfTrueInSortedBoooleanArray
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Find first occurance of value 'true' in sorted boolean array");
//            //var values = new bool[5] { false, false, true, true, true };
//            //var values = new bool[3] { false, false, false };
//            //var values = new bool[1] { true };
//            //var values = new bool[5] { true, true, true, true, true };
//            //var values = new bool[2] { false, true };
//            var values = new bool[9] { false, false, false, false, false, false, false, false, true };


//            Console.Write("Input - [");
//            foreach (var item in values)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            // O(N)
//            //var result = SolutionOne_Naive.FindFirstOccuranceOfTrue(values);

//            // O(logN)
//            var result = SolutionTwo_Efficient.FindFirstOccuranceOfTrue(values);

//            Console.WriteLine("Result - " + result);

//            Console.ReadLine();
//        }


//    }
//}
