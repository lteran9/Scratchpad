using System;
using System.Text;
using DataStructures.Core.Graphs;

namespace DataStructures.UseCases.Graphs
{
    public class DepthFirstSearch : IUseCase<string>
    {
        private readonly string _start;
        private readonly AdjacencyList<string> _graph;

        public DepthFirstSearch(AdjacencyList<string> graph, string start)
        {
            _start = start;
            _graph = graph;
        }

        public string Execute()
        {
            if (_graph?.IsValid() == true)
            {
                var path = new StringBuilder();
                var visited = new List<string>();
                var stack = new Stack<string>();

                stack.Push(_start);

                while (stack.Count > 0)
                {
                    var node = stack.Pop();

                    if (visited.Contains(node))
                        continue;

                    visited.Add(node);
                    path.Append($"{node} ");

                    var neighbors = _graph.Edges[node];
                    for (int i = neighbors.Count - 1; i >= 0; i--)
                    {
                        var neighbor = neighbors[i];
                        if (!visited.Contains(neighbor))
                        {
                            stack.Push(neighbor);
                        }
                    }
                }
            }

            return string.Empty;
        }
    }
}