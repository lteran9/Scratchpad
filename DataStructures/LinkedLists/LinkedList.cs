using System;
using System.Text;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
   public class LinkedList
   {
      public int Size { get; private set; }
      public Node<string> Head { get; private set; }

      public LinkedList()
      {
         Head = new Node<string>("HEAD");
         Size = 1;
      }

      public void Add(string value)
      {
         if (!string.IsNullOrEmpty(value))
         {
            var runner = Head;

            while (runner.Next != null)
            {
               runner = runner.Next;
            }

            runner.Next = new Node<string>(value);

            Size++;
         }
      }

      public string Get()
      {
         if (Head != null)
         {
            var runner = Head;
            var result = new StringBuilder();
            while (runner != null)
            {
               if (runner.Next != null)
               {
                  result.Append($"{runner.Data}->");
               }
               else
               {
                  result.Append(runner.Data);
               }

               runner = runner.Next;
            }

            return result.ToString();
         }

         return string.Empty;
      }

      public void Remove(string value)
      {
         // Do not allow the removal of the Head node
         if (Head.Data != value)
         {
            var runner = Head;
            while (runner.Next != null)
            {
               if (runner.Next.Data == value)
               {
                  runner.Next = runner.Next.Next;
                  Size--;
                  return;
               }
               runner = runner.Next;
            }
         }
      }

      public void RemoveDuplicates()
      {
         if (Head != null)
         {
            var runner = Head;
            // Keep track of values observed
            var list = new List<string>();

            while (runner.Next != null)
            {
               bool skip = false;
               // Add value to list if not seen before
               if (list.Contains(runner.Next.Data) == false)
               {
                  list.Add(runner.Next.Data);
               }
               else
               {
                  Size--;
                  // Remove next node because it is a duplicate
                  runner.Next = runner.Next.Next;
                  // Do not advance runner automatically because Next node has been modified already
                  skip = true;
               }

               if (skip == false)
               {
                  // Advance runner to next node
                  runner = runner.Next;
               }
            }
         }
      }

      public Node<string> ReturnKthToLast(int kth)
      {
         return null;
      }

      public void Clear()
      {
         Head = new Node<string>("HEAD");
      }
   }
}