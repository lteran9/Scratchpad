using System;
using DataStructures.Core.Graphs;

namespace DataStructures.UseCases.Graphs
{
    public class FindEmployeesInOrganization : IUseCase<string>
    {
        private AdjacencyList<OrgDepartment> _graphOrg;

        public FindEmployeesInOrganization(AdjacencyList<OrgDepartment> graphOrg)
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

        public struct OrgDepartment
        {
            public string Organization { get; set; }
            public List<string> Employees { get; set; }

            public OrgDepartment()
            {
                Organization = string.Empty;
                Employees = new List<string>();
            }

            public override string ToString()
            {
                return Organization;
            }
        }
    }
}