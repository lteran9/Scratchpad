using System;
using System.Text;
using DataStructures.Core.Graphs;
using Algorithms.UseCases;
using Algorithms.Core.Search;

namespace Algorithms.UseCases.Graphs
{
    public class DepthFirstSearchUseCase : IUseCase<string>
    {
        private readonly string _origin;
        private readonly string _target;
        private readonly DepthFirstSearch<string> _algorithm;

        public DepthFirstSearchUseCase(AdjacencyList<string> graph, string origin, string target)
        {
            _algorithm = new DepthFirstSearch<string>(graph);
            _origin = origin;
            _target = target;
        }

        public string Execute()
        {
            return string.Join(", ", _algorithm.Find(_origin, _target));
        }
    }
}