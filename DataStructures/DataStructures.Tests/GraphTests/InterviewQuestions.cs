using System;
using DataStructures.Core.Graphs;
using DataStructures.UseCases.Factory;
using Xunit;

namespace DataStructures.Tests.GraphTests
{
    public class InterviewQuestions
    {
        [Fact]
        public void GivenAnOrganizationWithDepartments_WhenAskedForEmployees_ThenProvideAll()
        {
            var orgStructure = GraphFactory.CreateGraph<string>();

            #region Set up scenario

            orgStructure.AddEdge("Alpha", "Alpha"); // Cyclical edge?
            orgStructure.AddEdge("Alpha", "Bravo");
            orgStructure.AddEdge("Alpha", "Charlie");
            orgStructure.AddEdge("Bravo", "Delta");
            orgStructure.AddEdge("Bravo", "Echo");

            #endregion



        }
    }
}