using System;
using DataStructures.Core.Graphs;

namespace Algorithms.Core.Search
{
    /// <summary>
    /// Breadth First Search
    /// </summary>
    public class BreadthFirstSearch<T> where T : notnull
    {
        private readonly IGraph<T> _graph;

        /// <summary>
        /// Create a new instance of the Breadth First Search algorithm.
        /// </summary>
        public BreadthFirstSearch()
        {
            _graph = new AdjacencyList<T>();
        }

        /// <summary>
        /// Create a new instance of the Breadth First Search algorithm using the passed in Graph data structure.
        /// </summary>
        public BreadthFirstSearch(IGraph<T> graph)
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
            var visitedSet = new HashSet<T>();

            if (_graph.ContainsVertex(startingVertex) && _graph.ContainsVertex(targetVertex))
            {
                var queue = new Queue<T>();
                visitedSet.Add(startingVertex);
                queue.Enqueue(startingVertex);

                while (queue.Count > 0)
                {
                    var vertex = queue.Dequeue();
                    visited.Add(vertex);

                    if (EqualityComparer<T>.Default.Equals(vertex, targetVertex))
                    {
                        return visited;
                    }

                    foreach (var neighbor in _graph.OutEdges(vertex))
                    {
                        if (visitedSet.Add(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return visited;
        }
    }
}