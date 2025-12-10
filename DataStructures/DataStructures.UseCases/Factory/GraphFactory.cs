using System;
using DataStructures.Core.Graphs;

namespace DataStructures.UseCases.Factory
{
    public static class GraphFactory
    {
        public static AdjacencyList<T> CreateGraph<T>()
        {
            return new AdjacencyList<T>();
        }
    }
}