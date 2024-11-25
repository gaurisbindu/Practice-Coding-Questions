//// Question - Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string.
//// If there are two or more words that are the same length, return the first word from the string with that length.
//// Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"

//// Example - 1
//// Input: "fun&!! time"
//// Output: time

//// Example - 2
////Input: "I love dogs"
////Output: love

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Coding_Questions.FindLongestWordInASentence
//{
//    internal class Program
//    {
//        static string Sentence = "Hello world123 567"; //"fun&!! time"; //"I love! singing";

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Given a setnce find the first longest word ");
//            Console.WriteLine("Input - " + Sentence);

//            var longestWord = SolutionOne.FindLongestWord(Sentence);

//            Console.WriteLine("Output - " + longestWord);

//        }
//    }
//}
