using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Coding_Questions.QueueUsingStack
{
    internal class MyQueue
    {
        Stack<int> queue;
        Stack<int> temporaryStack;
        int Length;

        public MyQueue()
        {
            queue = new Stack<int>();
            temporaryStack = new Stack<int>();
            Length = 0;
        }

        public void Push(int x)
        {
            queue.Push(x);
            Length++;
        }

        public int? Pop()
        {
            if (queue.Count == 0)
                return null;

            MoveToTemporaryStack();
            var value = temporaryStack.Pop();
            RestoreFromTemporaryStack();
            Length--;
            return value;
        }

        public int? Peek()
        {
            if( queue.Count == 0 )
                return null;

            MoveToTemporaryStack();
            var value = temporaryStack.Peek();
            RestoreFromTemporaryStack() ;
            return value;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }

        private void RestoreFromTemporaryStack()
        {
            while (temporaryStack.Count > 0)
            {
                queue.Push(temporaryStack.Pop());
            }
        }

        private void MoveToTemporaryStack()
        {
            while (queue.Count > 0)
            {
                temporaryStack.Push(queue.Pop());
            }
        }
    }
}
