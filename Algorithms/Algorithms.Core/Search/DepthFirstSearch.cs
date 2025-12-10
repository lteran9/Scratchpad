using System;
using DataStructures.Core.Graphs;

namespace Algorithms.Core.Search
{
    /// <summary>
    /// Depth First Search
    /// </summary>
    public class DepthFirstSearch<T>
    {
        private readonly AdjacencyList<T> Graph;

        /// <summary>
        /// Create a new instance of the Depth First Search algorithm.
        /// </summary>
        public DepthFirstSearch()
        {
            Graph = new AdjacencyList<T>();
        }

        /// <summary>
        /// Create a new instance of the Depth First Search algorithm using the passed in Graph data structure.
        /// </summary>
        public DepthFirstSearch(AdjacencyList<T> graph)
        {
            Graph = graph;
        }

        /// <summary>
        /// Add an Edge between Vertices to the Graph object.
        /// </summary>
        public void AddEdge(T parent, T child)
        {
            Graph.AddEdge(parent, child);
        }

        /// <summary>
        /// Return a list of items that are connected to the starting Vertex.
        /// </summary>
        public List<T> Find(T startingVertex, T targetVertex)
        {
            var visited = new List<T>();

            try
            {
                // If starting and target vertex are part of the Graph
                if (Graph.Edges.ContainsKey(startingVertex) && Graph.Edges.ContainsKey(targetVertex))
                {
                    var stack = new Stack<T>();
                    stack.Push(startingVertex);

                    while (stack.Count > 0)
                    {
                        var vertex = stack.Pop();

                        if (vertex?.Equals(targetVertex) == true)
                        {
                            // Target vertex has been found
                            return visited;
                        }
                        else
                        {
                            // Keep looking for target vertex
                            if (!visited.Contains(vertex))
                            {
                                // Add new vertex to stack
                                visited.Add(vertex);

                                foreach (var neighbor in Graph.OutEdges(vertex))
                                {
                                    // Add neighboring vertices to stack
                                    if (!visited.Contains(neighbor))
                                    {
                                        stack.Push(neighbor);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }

            return visited;
        }
    }
}