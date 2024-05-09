using System;

namespace DataStructures.Core.LinkedLists
{
   interface ILinkedList<T>
   {
      void Add(T item);
      void Remove(T item);

      T Find(T item);
   }
}