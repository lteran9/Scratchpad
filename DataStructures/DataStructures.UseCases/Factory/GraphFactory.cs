using System;
using DataStructures.Core.Graphs;

namespace DataStructures.UseCases.Factory
{
    /// <summary>
    /// Creates graph instances for use cases and tests.
    /// </summary>
    public static class GraphFactory
    {
        public static AdjacencyList<T> CreateGraph<T>() where T : notnull
        {
            return new AdjacencyList<T>();
        }
    }
}