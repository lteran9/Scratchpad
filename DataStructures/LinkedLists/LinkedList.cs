using System;
using System.Text;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
   public class LinkedList
   {
      public int Size { get; private set; }
      public Node<string> Root { get; private set; }

      public LinkedList()
      {
         Root = new Node<string>("HEAD");
         Size = 0;
      }

      public void Add(string value)
      {
         if (!string.IsNullOrEmpty(value))
         {
            var runner = Root;

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
         if (Root != null)
         {
            var runner = Root;
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
         if (Root.Data != value)
         {
            var runner = Root;
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
         if (Root != null)
         {
            var runner = Root;
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

      public void Clear()
      {
         Root = new Node<string>("HEAD");
      }
   }
}