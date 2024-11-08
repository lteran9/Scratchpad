using System;

namespace DataStructures.Core.Stacks 
{
   public interface IStack<T>
   {
      void Add(T item);

      T Peek();
      T Pop();
   }
}