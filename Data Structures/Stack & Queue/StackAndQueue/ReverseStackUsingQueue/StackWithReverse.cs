using StackAndQueue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.ReverseStackUsingQueue
{
    public class StackWithReverse : StackClass
    {
        // ReverseStack method
        public void ReverseStack()
        {
            Queue<int> queue = new Queue<int>();

            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            while (queue.Count > 0)
            {
                Push(queue.Dequeue());
            }
        }
    }
}
