using DataStructures.Core.LinkedLists;

namespace DataStructures.UseCases.LinkedLists
{
   public class LinkedListManipulation
   {
      public Core.LinkedLists.LinkedList<int>? SumLists(Core.LinkedLists.LinkedList<int> a, Core.LinkedLists.LinkedList<int> b)
      {
         if (a != null && b != null)
         {
            var aLength = a.Count();
            var bLength = b.Count();
            var result = new Core.LinkedLists.LinkedList<int>();

            result.Root = AddNodes(a.Root, b.Root, 0);

            return result;
         }

         return null;
      }

      public Core.LinkedLists.LinkedList<int>? SortTwoLists(Core.LinkedLists.LinkedList<int> a, Core.LinkedLists.LinkedList<int> b)
      {
         if (a != null && b != null)
         {
            var sorted = new Core.LinkedLists.LinkedList<int>();

            var firstHead = a.Root;
            var secondHead = b.Root;

            while (firstHead != null || secondHead != null)
            {
               if (firstHead == null)
               {
                  sorted.Add(secondHead!.Data);
                  secondHead = secondHead.Next;
               }
               else if (secondHead == null)
               {
                  sorted.Add(firstHead!.Data);
                  firstHead = firstHead.Next;
               }
               else if (firstHead.Data < secondHead.Data)
               {
                  sorted.Add(firstHead.Data);
                  firstHead = firstHead.Next;
               }
               else if (firstHead.Data > secondHead.Data)
               {
                  sorted.Add(secondHead.Data);
                  secondHead = secondHead.Next;
               }
               else
               {
                  // Both values are equal
                  sorted.Add(firstHead.Data);
                  // Advance both pointers
                  firstHead = firstHead?.Next;
                  secondHead = secondHead?.Next;
               }
            }

            return sorted;
         }

         return null;
      }

      public Core.LinkedLists.LinkedList<int>? InsertNodeAtPosition(Core.LinkedLists.LinkedList<int> llist, int data, int position)
      {
         if (llist != null)
         {
            var runner = llist.Root;
            var nlist = new Core.LinkedLists.LinkedList<int>();
            int index = 0;

            while (runner != null)
            {
               if (index == position)
               {
                  nlist.Add(data);
                  // Signal that data has been added to linked list
                  index = int.MinValue;
               }
               else
               {
                  nlist.Add(runner.Data);
                  runner = runner.Next;
               }

               index++;
            }

            // If data has not been added to linked list add it to the last position
            if (index != int.MinValue)
            {
               nlist.Add(data);
            }

            return nlist;
         }

         return null;
      }

      private Node<int>? AddNodes(Node<int>? l1, Node<int>? l2, int carry)
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
               l1?.Next,
               l2?.Next,
               value > 10 ? 1 : 0);
         }

         return result;
      }
   }
}