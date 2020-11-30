using System;

namespace Models.Graphs
{
   public class Edge<T> : IEquatable<Edge<T>>
   {
      public int Weight { get; private set; }
      public Vertex<T> Parent { get; private set; }
      public Vertex<T> Child { get; private set; }

      public Edge(Vertex<T> parent, Vertex<T> child, int weight = 0)
      {
         this.Parent = parent;
         this.Child = child;
         this.Weight = weight;
      }

      public bool Equals(Edge<T> other)
      {
         return Parent.Equals(other.Parent) && Child.Equals(other.Child);
      }
   }
}