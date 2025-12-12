using System;
using System.Text;
using DataStructures.Core.Graphs;

namespace DataStructures.UseCases.Graphs
{
    public class BreadthFirstSearch : IUseCase<string>
    {
        private readonly string _start;
        private readonly AdjacencyList<string> _graph;

        public BreadthFirstSearch(AdjacencyList<string> graph, string start)
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
                var queue = new Queue<string>();

                visited.Add(_start);
                queue.Enqueue(_start);

                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    path.Append($"{node} ");

                    foreach (var neighbor in _graph.Edges[node])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }

                return path.ToString().Trim();
            }

            return string.Empty;
        }
    }
}