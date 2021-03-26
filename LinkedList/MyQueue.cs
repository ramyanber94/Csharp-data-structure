using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace week4_Assignment
{
    class MyQueue<T> : IEnumerable<T>
    {
        LinkedList<T> myQueue = new LinkedList<T>();


        public LinkedList<T> getMyQueue()
        {
            return this.myQueue;
        }


 
        internal void Enqueue(T name)
        {
           myQueue.AddLast(name);
        }
        internal T Peek()
        {
            return myQueue.First.Value;
        }


        internal T Dequeue()
        {
            T temp = myQueue.First.Value;
            myQueue.Remove(temp);
            return temp;

           
        }

      

        public IEnumerator<T> GetEnumerator()
        {
            return myQueue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myQueue.GetEnumerator();
        }
    }
}
