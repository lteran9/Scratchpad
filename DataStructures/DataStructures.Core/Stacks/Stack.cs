using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.Stacks
{
   public class Stack<T> : IStack<T>
   {
      private Node<T> Head { get; set; }

      public void Add(T item)
      {
         if (Head == null)
         {
            Head = new Node<T>(item);
         }
         else
         {
            var newHead = new Node<T>(item);
            newHead.Next = Head;
            Head = newHead;
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
            var tempHead = Head;

            Head = Head.Next;

            return tempHead.Data;
         }

         throw new Exception("Head is null.");
      }
   }
}