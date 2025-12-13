using System;
using System.Text;
using Algorithms.Core.Search;
using DataStructures.Core.Graphs;

namespace Algorithms.UseCases.Graphs
{
    public class BreadthFirstSearchUseCase : IUseCase<string>
    {
        private readonly string _origin;
        private readonly string _target;
        private readonly BreadthFirstSearch<string> _algorithm;

        public BreadthFirstSearchUseCase(AdjacencyList<string> graph, string start, string end)
        {
            _algorithm = new BreadthFirstSearch<string>(graph);
            _origin = start;
            _target = end;
        }

        public string Execute()
        {
            return string.Join(", ", _algorithm.Find(_origin, _target));
        }
    }
}