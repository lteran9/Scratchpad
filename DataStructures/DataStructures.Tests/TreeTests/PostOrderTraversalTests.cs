using System;
using Xunit;
using DataStructures.Core.Trees;
using DataStructures.UseCases.Trees;

namespace DataStructures.Tests.TreeTests
{
   public class PostOrderTraversalTests
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

         // Validate tree is in expected format
         Assert.True(tree.Root.Data == 1);
         Assert.True(tree.Root.RightChild.Data == 2);
         Assert.True(tree.Root.RightChild.RightChild.Data == 5);
         Assert.True(tree.Root.RightChild.RightChild.LeftChild.Data == 3);
         Assert.True(tree.Root.RightChild.RightChild.LeftChild.RightChild.Data == 4);
         Assert.True(tree.Root.RightChild.RightChild.RightChild.Data == 6);

         var output = (new PostOrderTraversal(tree.Root)).Execute();
         Assert.Equal("4 3 6 5 2 1", output);
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

         var output = (new PostOrderTraversal(tree.Root)).Execute();
         Assert.Equal("2 6 5 4 9 8 12 11 10 13 7 3 15 14 1", output);
      }

      [Fact]
      public void TestCase_2()
      {
         var tree = new BinarySearchTree<int>(10);
         tree.AddNode(7);
         tree.AddNode(9);
         tree.AddNode(4);
         tree.AddNode(14);
         tree.AddNode(20);
         tree.AddNode(11);

         var output = (new PostOrderTraversal(tree.Root)).Execute();
         Assert.Equal("4 9 7 11 20 14 10", output);
      }
   }
}