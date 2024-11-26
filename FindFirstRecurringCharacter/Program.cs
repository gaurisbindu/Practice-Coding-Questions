////Question -Given an array of elements find the item that gets repeated first time
////Given an array = [2,5,1,2,3,5,1,2,4]:
////It should return 2

////Given an array = [2,1,1,2,3,5,1,2,4]:
////It should return 1

////Given an array = [2,3,4,5]:
////It should return undefined

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindFirstRecurringCharacter
//{
//    internal class Program
//    {
//        //static int[] Nums = [2, 5, 1, 2, 3, 5, 1, 2, 4];
//        //static int[] Nums = [2, 1, 1, 2, 3, 5, 1, 2, 4];
//        //static int[] Nums = [2, 3, 4, 5];

//        static int[] Nums = [];

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Given an array of elements find the item that gets repeated first time ");
//            Console.WriteLine("Input - " + Nums);

//            Console.Write("Input - [");
//            foreach (var item in Nums)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.Write("]\n");

//            var output = SolutionOne.FindFirstRecurringCharacter(Nums);

//            Console.WriteLine("Output - {0}", output == null ? "Null" : output);

//        }
//    }
//}