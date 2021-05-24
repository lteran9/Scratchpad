using System;
using DataStructures.Trees;
using Xunit;

namespace DataStructures.TreeTests
{
   public class BinaryTreeTests
   {
      [Fact]
      public void RebalanceTest()
      {
         /// Balanced Tree: the heights of the two child subtrees of any node differ by at most one.

      }

      [Fact]
      public void TreeHeightTests()
      {
         var tree = new BinaryTree<int>(2);

         Assert.Equal(0, tree.GetHeight());

         tree.AddNode(1);
         tree.AddNode(3);

         Assert.Equal(1, tree.GetHeight());
      }

      [Fact]
      public void SimpleAddTest()
      {
         var tree = new BinaryTree<int>(10);

         tree.AddNode(7);
         tree.AddNode(12);
         tree.AddNode(3);
         tree.AddNode(15);

         Assert.Equal(10, tree.Root.Data);
         Assert.Equal(7, tree.Root.LeftChild.Data);
         Assert.Equal(12, tree.Root.RightChild.Data);
         Assert.Equal(5, tree.Length);
      }

      [Fact]
      public void PreventDuplicatesTest()
      {
         var tree = new BinaryTree<int>(5);

         tree.AddNode(5);
         tree.AddNode(6);
         tree.AddNode(5);
         tree.AddNode(5);
         tree.AddNode(6);
         tree.AddNode(5);

         Assert.Equal(2, tree.Length);
      }
   }
}