//Question - Implement a first in first out (FIFO) queue using only two stacks.
//The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

//Implement the MyQueue class:

//void push(int x) Pushes element x to the back of the queue.
//int pop() Removes the element from the front of the queue and returns it.
//int peek() Returns the element at the front of the queue.
//boolean empty() Returns true if the queue is empty, false otherwise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.QueueUsingStack
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Implement Queue using Stack under the hood");

            var myQueue = new MyQueue();
            myQueue.Push(1);
            myQueue.Push(2);
            myQueue.Push(3);

            var peek = myQueue.Peek();
            Console.WriteLine("Peeked Item - " + peek);

            var output = myQueue.Pop();
            Console.WriteLine("Popped Item - " + output);

            peek = myQueue.Peek();
            Console.WriteLine("Peeked Item - " + peek);

            output = myQueue.Pop();
            Console.WriteLine("Popped Item - " + output);

            peek = myQueue.Peek();
            Console.WriteLine("Peeked Item - " + peek);

            myQueue.Push(4);

            output = myQueue.Pop();
            Console.WriteLine("Popped Item - " + output);

            peek = myQueue.Peek();
            Console.WriteLine("Peeked Item - " + peek);

            Console.WriteLine("Is Queue Empty - {0}", myQueue.IsEmpty() ? "Yes" : "No");

            Console.ReadLine();

        }

    }
}
