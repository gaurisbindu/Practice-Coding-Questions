//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.IsValidBST
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//            var tree = new BinarySearchTree();
//            tree.Insert(5);
//            tree.Insert(4);
//            tree.Insert(6);
//            tree.Insert(null);
//            tree.Insert(null);
//            tree.Insert(3);
//            tree.Insert(7);

//            var result = tree.BreadthFirstSearch();

//            Console.Write("[");
//            foreach (var item in result)
//            {
//                Console.Write(item.ToString() + " ");
//            }
//            Console.Write("]");

//            Console.ReadLine();
//        }
//    }
//}
