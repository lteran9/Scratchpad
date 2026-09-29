using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.Stacks
{
    public class Stack<T> : IStack<T> where T : IComparable
    {
        private int count = 0;
        private Node<T> head;

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Push(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
            }
            else
            {
                var newHead = new Node<T>(item);
                newHead.Next = head;
                head = newHead;
            }

            count++;
        }

        public T Peek()
        {
            if (head != null)
            {
                return head.Data;
            }

            throw new InvalidOperationException("The stack is empty.");
        }

        public T Pop()
        {
            if (head != null)
            {
                var temp = head;

                head = head.Next;

                count--;

                return temp.Data;
            }

            throw new InvalidOperationException("Head is null.");
        }
    }
}