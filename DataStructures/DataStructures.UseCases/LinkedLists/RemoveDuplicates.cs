using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.UseCases.LinkedLists
{
   public class RemoveDuplicates<T> : IUseCase<Core.LinkedLists.LinkedList<T>>
   {
      private readonly Core.LinkedLists.LinkedList<T> _linkedList;

      public RemoveDuplicates(Core.LinkedLists.LinkedList<T> linkedList)
      {
         _linkedList = linkedList;
      }

      public Core.LinkedLists.LinkedList<T> Execute()
      {
         var current = _linkedList.Root;
         while (current != null)
         {
            Remove(current, current.Data);
            current = current.Next;
         }

         return _linkedList;
      }

      /// <summary>
      /// Remove all instances of value from the list.
      /// </summary>
      /// <param name="runner"></param>
      /// <param name="value"></param>
      private void Remove(Node<T>? runner, T value)
      {
         if (runner != null)
         {
            do
            {
               // Compare next Data with value
               if (runner.Next?.Data?.Equals(value) == true)
               {
                  runner.Next = runner.Next?.Next;
               }
               else
               {
                  runner = runner.Next;
               }
            } while (runner?.Next != null);
         }
      }

   }
}