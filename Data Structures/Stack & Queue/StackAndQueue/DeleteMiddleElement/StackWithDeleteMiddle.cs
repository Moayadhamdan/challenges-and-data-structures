using StackAndQueue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : StackClass
    {
        // DeleteMiddle method
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int middleIndex = (Count() - 1) / 2;

            Stack<int> tempStack = new Stack<int>();

            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(Pop());
            }

            Pop();

            while (tempStack.Count > 0)
            {
                Push(tempStack.Pop());
            }
        }

        // Helper method to count elements in the stack
        private int Count()
        {
            int count = 0;
            Node current = top;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}
