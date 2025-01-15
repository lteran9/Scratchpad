using System;

namespace DataStructures.UseCases.LinkedLists
{
   public class AddToList<T> : IUseCase<Core.LinkedLists.LinkedList<T>>
   {
      private readonly T _value;
      private readonly Core.LinkedLists.LinkedList<T> _linkedList;

      public AddToList(Core.LinkedLists.LinkedList<T> linkedList, T value)
      {
         _value = value;
         _linkedList = linkedList;
      }

      public Core.LinkedLists.LinkedList<T> Execute()
      {
         if (_value != null)
         {
            var runner = _linkedList.Root;

            while (runner.Next != null)
            {
               runner = runner.Next;
            }

            runner.Next = new Core.LinkedLists.Node<T>(_value);
         }

         return _linkedList;
      }
   }
}