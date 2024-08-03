using StackAndQueue.Queue;
using StackAndQueue.ReverseStackUsingQueue;
using StackAndQueue.Stack;
using StackAndQueue.DeleteMiddleElement;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack example
            Console.WriteLine("=============== Stack Example ===============");
            StackClass stack = new StackClass();
            stack.Push(25);
            stack.Push(20);
            stack.Push(15);
            stack.Push(10);
            stack.Push(5);

            Console.WriteLine("Initial Stack:");
            stack.PrintStack();
            Console.WriteLine("\nPerforming Pop Operation (Last In First Out):");
            Console.WriteLine($"Popped Value: {stack.Pop()}");
            Console.WriteLine($"Top Value After Pop: {stack.Peek()}");
            Console.WriteLine($"Is the Stack Empty? {stack.IsEmpty()}");
            Console.WriteLine("\nStack After Pop Operation:");
            stack.PrintStack();

            // Queue example
            Console.WriteLine("=============== Queue Example ===============");
            QueueClass queue = new QueueClass();
            queue.Enqueue(25);
            queue.Enqueue(20);
            queue.Enqueue(15);
            queue.Enqueue(10);
            queue.Enqueue(5);

            Console.WriteLine("Initial Queue:");
            queue.PrintQueue();
            Console.WriteLine("\nPerforming Dequeue Operation (First In First Out):");
            Console.WriteLine($"Dequeued Value: {queue.Dequeue()}");
            Console.WriteLine($"Front Value After Dequeue: {queue.Peek()}");
            Console.WriteLine($"Is the Queue Empty? {queue.IsEmpty()}");
            Console.WriteLine("\nQueue After Dequeue Operation:");
            queue.PrintQueue();

            // Reverse Stack example
            Console.WriteLine("=============== Reverse Stack Example ===============");
            StackWithReverse reverseStack = new StackWithReverse();
            reverseStack.Push(1);
            reverseStack.Push(2);
            reverseStack.Push(3);
            reverseStack.Push(4);
            reverseStack.Push(5);

            Console.WriteLine("Initial Stack:");
            reverseStack.PrintStack();
            Console.WriteLine("\nReversing Stack:");
            reverseStack.ReverseStack();
            Console.WriteLine("Stack After Reversing:");
            reverseStack.PrintStack();

            reverseStack.Push(6);
            reverseStack.Push(7);
            Console.WriteLine("\nStack After Pushing 6 and 7:");
            reverseStack.PrintStack();
            Console.WriteLine("\nReversing Stack Again:");
            reverseStack.ReverseStack();
            Console.WriteLine("Stack After Reversing Again:");
            reverseStack.PrintStack();

            // Delete Middle Element from Stack example
            Console.WriteLine("=============== Delete Middle Element Example ===============");
            StackWithDeleteMiddle stackWithDeleteMiddle = new StackWithDeleteMiddle();
            stackWithDeleteMiddle.Push(7);
            stackWithDeleteMiddle.Push(14);
            stackWithDeleteMiddle.Push(3);
            stackWithDeleteMiddle.Push(8);
            stackWithDeleteMiddle.Push(5);

            Console.WriteLine("Initial Stack:");
            stackWithDeleteMiddle.PrintStack();
            Console.WriteLine("\nDeleting Middle Element:");
            stackWithDeleteMiddle.DeleteMiddle();
            Console.WriteLine("Stack After Deleting Middle Element:");
            stackWithDeleteMiddle.PrintStack();

            stackWithDeleteMiddle.Push(2);
            stackWithDeleteMiddle.Push(9);
            stackWithDeleteMiddle.Push(11);
            Console.WriteLine("\nStack After Pushing 2, 9, 11:");
            stackWithDeleteMiddle.PrintStack();
            Console.WriteLine("\nDeleting Middle Element Again:");
            stackWithDeleteMiddle.DeleteMiddle();
            Console.WriteLine("Stack After Deleting Middle Element Again:");
            stackWithDeleteMiddle.PrintStack();
        }
    }
}
