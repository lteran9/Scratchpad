using System;
using DataStructures.Core.Trees;
using DataStructures.UseCases.Trees;
using Xunit;

namespace DataStructures.Tests.TreeTests
{
   public class InOrderTraversalTests
   {
      [Fact]
      public void TestCase_0()
      {
         var tree = new BinarySearchTree<int>(1);
         tree.AddNode(2);
         tree.AddNode(5);
         tree.AddNode(3);
         tree.AddNode(4);
         tree.AddNode(6);

         Assert.True(tree.Root.Data == 1);
         Assert.True(tree.Root.RightChild.Data == 2);
         Assert.True(tree.Root.RightChild.RightChild.Data == 5);
         Assert.True(tree.Root.RightChild.RightChild.LeftChild.Data == 3);
         Assert.True(tree.Root.RightChild.RightChild.LeftChild.RightChild.Data == 4);
         Assert.True(tree.Root.RightChild.RightChild.RightChild.Data == 6);

         var output = (new InOrderTraversal(tree.Root)).Execute();
         Assert.Equal("1 2 3 4 5 6", output);
      }

      [Fact]
      public void TestCase_1()
      {
         var tree = new BinarySearchTree<int>(1);
         tree.AddNode(14);
         tree.AddNode(3);
         tree.AddNode(7);
         tree.AddNode(4);
         tree.AddNode(5);
         tree.AddNode(15);
         tree.AddNode(6);
         tree.AddNode(13);
         tree.AddNode(10);
         tree.AddNode(11);
         tree.AddNode(2);
         tree.AddNode(12);
         tree.AddNode(8);
         tree.AddNode(9);

         var output = (new InOrderTraversal(tree.Root)).Execute();
         Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15", output);
      }
   }
}