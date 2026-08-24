using System;
using DataStructures.Core.Graphs;

namespace Algorithms.Core.Search
{
    /// <summary>
    /// Depth First Search
    /// </summary>
    public class DepthFirstSearch<T> where T : notnull
    {
        private readonly IGraph<T> _graph;

        /// <summary>
        /// Create a new instance of the Depth First Search algorithm.
        /// </summary>
        public DepthFirstSearch()
        {
            _graph = new AdjacencyList<T>();
        }

        /// <summary>
        /// Create a new instance of the Depth First Search algorithm using the passed in Graph data structure.
        /// </summary>
        public DepthFirstSearch(IGraph<T> graph)
        {
            _graph = graph ?? throw new ArgumentNullException(nameof(graph));
        }

        /// <summary>
        /// Add an Edge between Vertices to the Graph object.
        /// </summary>
        public void AddEdge(T parent, T child)
        {
            _graph.AddEdge(parent, child);
        }

        /// <summary>
        /// Return a list of items that are connected to the starting Vertex.
        /// </summary>
        public List<T> Find(T startingVertex, T targetVertex)
        {
            var visited = new List<T>();

            if (_graph.ContainsVertex(startingVertex) && _graph.ContainsVertex(targetVertex))
            {
                var stack = new Stack<T>();
                var visitedSet = new HashSet<T>();
                stack.Push(startingVertex);

                while (stack.Count > 0)
                {
                    var vertex = stack.Pop();

                    if (!visitedSet.Add(vertex))
                    {
                        continue;
                    }

                    if (EqualityComparer<T>.Default.Equals(vertex, targetVertex))
                    {
                        return visited;
                    }

                    visited.Add(vertex);
                    foreach (var neighbor in _graph.OutEdges(vertex))
                    {
                        stack.Push(neighbor);
                    }
                }
            }

            return visited;
        }
    }
}
