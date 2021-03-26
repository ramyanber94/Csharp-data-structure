using System;

namespace week4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            MyStack<string> myStack = new MyStack<string>();
            MyQueue<string> myQueue = new MyQueue<string>();

            myStack.Push("first");
            myStack.Push("second");
            myStack.Push("Third");
            myStack.Push("fourth");
            myStack.Push("fifth");
            myStack.Push("sixth");

            Console.WriteLine("Next Item to be Popped : " + myStack.Peek());
            Console.WriteLine("Item " +"**"+ myStack.Pop()+"**"+" "+"has been removed" +"\n");
            Console.WriteLine("Next Item to be Popped : " + myStack.Peek() + "\n");
            Console.WriteLine("Stack Items : ");
            foreach (var item in myStack)
            {
                Console.WriteLine("**"+item+"**");
            }

            Console.WriteLine("\n"+"**********************************************");


            myQueue.Enqueue("first");
            myQueue.Enqueue("second");
            myQueue.Enqueue("Third");
            myQueue.Enqueue("fourth");
            myQueue.Enqueue("fifth");
            myQueue.Enqueue("sixth");
            Console.WriteLine("\nNext Item to be dequeued : " + myQueue.Peek());
            Console.WriteLine("Item "+"**"+myQueue.Dequeue()+"**"+" "+" has been removed "+"\n");
            Console.WriteLine("Next Item to be dequeued : " + myQueue.Peek()+"\n");
            Console.WriteLine("Queue Items :");
            foreach (var item in myQueue)
            {
                Console.WriteLine("**"+item+"**");
            }

        }
    }
}
