using System;
using System.Collections.Generic;
using DataStructures.Core.Graphs;
using DataStructures.Tests.GraphTests.Data;
using DataStructures.UseCases.Factory;
using DataStructures.UseCases.Graphs;
using Xunit;

namespace DataStructures.Tests.GraphTests
{
    public class InterviewQuestions
    {
        [Theory]
        [ClassData(typeof(OrgDepartmentTestData))]
        public void GivenAnOrganizationWithDepartments_WhenAskedForEmployees_ThenProvideAll(List<FindEmployeesInOrganization.OrgDepartment> testData)
        {
            // Arrange
            var orgStructure = GraphFactory.CreateGraph<string>();
            // Alpha: Bravo
            orgStructure.AddEdge(testData[0].Organization, testData[1].Organization);
            // Alpha: Charlie
            orgStructure.AddEdge(testData[1].Organization, testData[2].Organization);
            // Bravo: Delta
            orgStructure.AddEdge(testData[1].Organization, testData[3].Organization);

            // Act

            // Assert
            Assert.True(true);
        }
    }
}