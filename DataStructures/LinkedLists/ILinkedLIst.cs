using System;

namespace DataStructures.LinkedLists
{
   interface ILinkedList<T>
   {
      void Add(T item, Node<T>.Location location = Node<T>.Location.Tail);
      void Remove(T item);

      T Find(T item);
   }
}