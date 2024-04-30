using System;
using System.Reflection.Metadata;

namespace DataStructures.LinkedLists
{
   public class LinkedList<T>
   {
      public int Size { get; private set; }

      public Node<T> Root { get; private set; }

      private LinkedList() { }

      public LinkedList(T head)
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

      public void Add(Node<T> node)
      {
         if (node != null)
         {
            if (Size == 0)
            {
               Root = node;
            }
            else
            {
               var runner = Root;

               while (runner.Next != null)
               {
                  runner = runner.Next;
               }

               runner.Next = node;
            }

            Size++;
         }
      }

      /// <summary>
      /// Returns the first instance of a Node with value of T found in the linked list. 
      /// </summary>
      /// <param name="data"></param>
      /// <returns></returns>
      public Node<T> Find(T data)
      {
         if (Root != null)
         {
            var runner = Root;

            while (runner != null)
            {
               if (runner.Data.Equals(data))
               {
                  return runner;
               }

               runner = runner.Next;
            }
         }

         return null;
      }

      /// <summary>
      /// Returns the Node at the specified index.
      /// </summary>
      /// <param name="index"></param>
      /// <returns></returns>
      public Node<T> GetAt(int index)
      {
         if (Root != null)
         {
            int loops = 0;
            var runner = Root;
            while (runner != null)
            {
               if (loops == index)
               {
                  return runner;
               }
               loops++;
               runner = runner.Next;
            }
         }

         return null;
      }

      /// <summary>
      /// Removes the first instance of T found in the linked list.
      /// </summary>
      /// <param name="value"></param> 
      /// <returns></returns>
      public void Remove(T value)
      {
         // Do not allow the removal of the Head node
         if (Root.Data.Equals(value))
         {
            Root = Root.Next;
            Size--;
         }
         else
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

      public void RemoveDuplicates()
      {
         if (Root != null)
         {
            var current = Root;
            while (current != null)
            {
               Remove(current, current.Data);
               current = current.Next;
            }
         }
      }

      private void Remove(Node<T> runner, T value)
      {
         if (runner != null)
         {
            do
            {
               if (runner.Next?.Data.Equals(value) == true)
               {
                  runner.Next = runner.Next?.Next;
                  Size--;
               }
               else
               {
                  runner = runner.Next;
               }
            } while (runner?.Next != null);
         }
      }

      public Node<T> ReturnKthToLast(int k)
      {
         if (Root != null)
         {
            var numberOfNodes = Count();
            // Validate that K is a valid parameter
            if (k > numberOfNodes)
            {
               throw new Exception("Value of K is greater than number of Nodes in LinkedList.");
            }
            else
            {
               int index = numberOfNodes - k;
               var runner = Root;

               if (index == numberOfNodes)
               {
                  index--;
               }

               for (int i = 0; i < index; i++)
               {
                  runner = runner.Next;
               }

               return runner;
            }
         }

         return null;
      }

      public void DeleteMiddleNode(Node<T> middle)
      {
         if (middle != null)
         {
            var overwrite = middle.Next;
            middle.Data = overwrite.Data;
            middle.Next = overwrite.Next;
            Size--;
         }
      }

      public int Count()
      {
         int count = 0;

         if (Root != null)
         {
            var runner = Root;
            while (runner != null)
            {
               count++;
               runner = runner.Next;
            }
         }

         return count;
      }

      public void Clear()
      {
         Size = 0;
         Root = null;
      }

      public static LinkedList<int> SumLists(LinkedList<int> a, LinkedList<int> b)
      {
         if (a != null && b != null)
         {
            var aLength = a.Count();
            var bLength = b.Count();
            var result = new LinkedList<int>();

            result.Root = AddNodes(a.Root, b.Root, 0);

            return result;
         }

         return null;
      }

      private static Node<int> AddNodes(Node<int> l1, Node<int> l2, int carry)
      {
         if (l1 == null && l2 == null && carry == 0)
         {
            return null;
         }

         var result = new Node<int>(0);
         int value = carry;
         if (l1 != null)
         {
            value += l1.Data;
         }

         if (l2 != null)
         {
            value += l2.Data;
         }

         result.Data = value % 10;

         /* Recurse */
         if (l1 != null || l2 != null)
         {
            result.Next = AddNodes(
               l1 != null ? l1.Next : null,
               l2 != null ? l2.Next : null,
               value > 10 ? 1 : 0);
         }

         return result;
      }
   }
}