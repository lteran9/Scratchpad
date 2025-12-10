using System;
using DataStructures.Core.Graphs;

namespace DataStructures.UseCases.Graphs
{
    public class FindEmployeesInOrganization : IUseCase<string>
    {
        private AdjacencyList<string> _graphOrg;

        public FindEmployeesInOrganization(AdjacencyList<string> graphOrg)
        {
            _graphOrg = graphOrg;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Comma separated string with employee names under organization.</returns>
        public string Execute()
        {
            if (_graphOrg?.IsValid() == true)
            {

            }

            return string.Empty;
        }
    }
}