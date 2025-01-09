//using System;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.Random_Practice
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Two Sum");
//            Console.WriteLine("------------------");

//            int[] nums = { 2, 7, 11, 15 };
//            int target = 9;

//            //var result = TwoSum(nums, target);
//            //Console.WriteLine(result);

//            int[] Nums = [-1, 0, 1, 2, -1, -4];
//            var result2 = ThreeSum(Nums);

//            var x = new OrderedDictionary();
//            x.Add(3, new int[2] { 1, 2 });
//            x.Add(2, new int[2] { 1, 2 });
//            x.Add(1, new int[2] { 1, 2 });

//            var y = x;
//        }

//        public static int[] TwoSum(int[] nums, int target)
//        {
//            var result = new int[2];

//            if (!nums.Any())
//            {
//                return result;
//            }
//            HashSet<IList<int>> triplets = new HashSet<IList<int>>();
//            var triplet = new List<int> { 1, 2, 3 };
//            var triplet2 = new List<int> { 2, 3, 1 };

//            var orderedTriplet = triplet.Order().ToList();
//            var orderedTriplet2 = triplet2.Order().ToList();

//            triplets.Add(orderedTriplet);
//            if (!triplets.Contains(orderedTriplet2))
//                triplets.Add(orderedTriplet2);


//            Dictionary<int, int> compliments = new Dictionary<int, int>();
//            for (int i = 0; i < nums.Length; i++)
//            {

//                if (!compliments.ContainsKey(nums[i]))
//                {
//                    var compliment = target - nums[i];
//                    compliments.Add(compliment, i);
//                }
//                else
//                {
//                    result[0] = compliments[i];
//                    result[1] = i;
//                    break;
//                }
//            }

//            return result;
//        }

//        public static IList<IList<int>> ThreeSum(int[] nums)
//        {
//            nums = nums.Order().ToArray();
//            var x = new List<IList<int>>();
//            x.Add(nums);

//            var triplets = new HashSet<(int, int, int)>();

//            var dict = new Dictionary<char, char>();
//            dict.Add('(', ')');
//            dict.Add('{', '}');
//            dict.Add('[', ']');


//            var z = new int[4] { 2, 4, 3, 2};

//            var pairs = new List<int[]>();


//            var length = nums.Length;

//            Stack<int> s = new Stack<int>();
//            s.Count();

//            for (int i = 0; i < length; i++)
//            {
//                var possibleThirds = new HashSet<int>();
//                for (int j = i + 1; j < length; j++)
//                {
//                    var third = -(nums[i] + nums[j]);
//                    //Console.WriteLine(third);

//                    if (possibleThirds.Contains(third))
//                    {
//                        Console.WriteLine("Found a match");
//                        var temp = new List<int>() { nums[i], nums[j], third };
//                        var ordered = temp.Order().ToList();
//                        var tuple = (ordered[0], ordered[1], ordered[2]);
//                        triplets.Add(tuple);
//                        Console.WriteLine("{0} {1} {2}", nums[i], nums[j], third);
//                    }

//                    possibleThirds.Add(third);
//                }
//            }

//            return triplets
//                .Select(tuple => (IList<int>)new List<int> { tuple.Item1, tuple.Item2, tuple.Item3 })
//                .ToList();
//        }
//    }
//}
