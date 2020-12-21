using System;

namespace Models.Graphs
{
   public class Edge<T> : IEquatable<Edge<T>>
   {
      public int Weight { get; private set; }
      public Vertex<T> Source { get; private set; }
      public Vertex<T> Target { get; private set; }

      public Edge(Vertex<T> source, Vertex<T> target, int weight = 0)
      {
         this.Source = source;
         this.Target = target;
         this.Weight = weight;
      }

      public bool Equals(Edge<T> other)
      {
         return Source.Equals(other.Source) && Target.Equals(other.Target);
      }
   }
}