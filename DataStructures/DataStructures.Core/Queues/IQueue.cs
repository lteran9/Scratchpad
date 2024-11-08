using System;

namespace DataStructures.Core.Queues 
{
   public interface IQueue<T> 
   {
      void Add(T item);

      T Peek();
      T Pop();
   }
}