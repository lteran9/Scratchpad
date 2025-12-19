using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.Queues
{
    /// <summary>
    /// Custom Queue implementation, first in first out.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T> : IQueue<T>
    {
        // Using custom Node implementation for variable size q's
        private Node<T> Head { get; set; }

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = new Node<T>(item);
            }
            else
            {
                var runner = Head;

                while (runner.Next != null)
                {
                    runner = runner.Next;
                }

                runner.Next = new Node<T>(item);
            }
        }

        public T Peek()
        {
            if (Head != null)
            {
                return Head.Data;
            }

            throw new Exception("Head is null.");
        }

        public T Pop()
        {
            if (Head != null)
            {
                var temp = Head;

                Head = Head.Next;

                return temp.Data;
            }

            throw new Exception("Head is null.");
        }
    }
}