using System;
using System.Text;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
   public class LinkedList<T>
   {
      public int Size { get; private set; }

      public Node<T> Root { get; private set; }

      public LinkedList(
         T head,
         bool allowDuplicates = true)
      {
         Root = new Node<T>(head);
         Size = 1; // Head node counts as a node
      }

      public void Add(T value)
      {
         if (value != null)
         {
            var runner = Root;

            while (runner.Next != null)
            {
               runner = runner.Next;
            }

            runner.Next = new Node<T>(value);

            Size++;
         }
      }

      public T Get(int index)
      {
         if (Root != null)
         {
            var runner = Root;

            while (runner != null)
            {
               runner = runner.Next;
            }

            return runner.Data;
         }

         return default(T);
      }

      public void Remove(T value)
      {
         // Do not allow the removal of the Head node
         if (Root.Data.Equals(value) == false)
         {
            var runner = Root;

            while (runner.Next != null)
            {
               if (runner.Next.Data.Equals(value) == true)
               {
                  runner.Next = runner.Next.Next;
                  Size--;
                  return;
               }
               runner = runner.Next;
            }
         }
      }

      public void Clear()
      {
         Size = 0;
         Root = null;
      }
   }
}