using System;
using System.Collections.Generic;

namespace Models.Graphs
{
   public class Vertex<T> : IEquatable<Vertex<T>>
   {
      public T Value { get; private set; }

      public Vertex(T value)
      {
         this.Value = value;
      }

      public bool Equals(Vertex<T> other)
      {
         return Value.Equals(other.Value);
      }
   }
}