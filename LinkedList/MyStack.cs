using Nancy.Routing.Trie;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace week4_Assignment
{
    class MyStack<T> : IEnumerable<T>
    {
        LinkedList<T> myStack = new LinkedList<T>();


  

        internal void Push(T name)
        {
            myStack.AddFirst(name);

        }

        internal T Peek()
        {
            return myStack.First.Value;

        }

        internal T Pop()
        {
            T temp = myStack.First.Value;
            myStack.Remove(temp);
            return temp;

        }
        
        



        public IEnumerator<T> GetEnumerator()
        {
            return myStack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myStack.GetEnumerator();
        }
    }
}
