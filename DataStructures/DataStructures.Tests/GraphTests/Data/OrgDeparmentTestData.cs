using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DataStructures.UseCases.Graphs;

namespace DataStructures.Tests.GraphTests.Data
{
    public class OrgDepartmentTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return GetOrgDeparmentData();
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private List<string> Departments
        {
            get
            {
                return new List<string>()
                {
                    "Alpha", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India"
                };
            }
        }

        private List<string> Employees
        {
            get
            {
                return new List<string>()
                {
                    "James, Carter",
                    "Emily, Johnson",
                    "Michael, Thompson",
                    "Sarah, Williams",
                    "Daniel, Anderson",
                    "Olivia, Martinez",
                    "Christopher, Brown",
                    "Jessica, Davis",
                    "Matthew, Wilson",
                    "Sophia, Garcia",
                    "Andrew, Miller",
                    "Hannah, Rodriguez",
                    "Aaron, Rodgers",
                    "Michael, Wilson",
                    "Trey, McBride",
                    "Trevor, Lawrence",
                    "Brock, Purdy",
                    "Kyler, Murray"
                };
            }
        }

        private object[] GetOrgDeparmentData()
        {
            var data = new List<FindEmployeesInOrganization.OrgDepartment>();
            var employeeData = new Stack<string>(Employees);

            foreach (var dept in Departments)
            {
                data.Add(
                    new FindEmployeesInOrganization.OrgDepartment()
                    {
                        Organization = dept,
                        Employees = new List<string>()
                        {
                            employeeData.Pop(),
                            employeeData.Pop()
                        }
                    });
            }

            return new object[] { data };
        }
    }
}