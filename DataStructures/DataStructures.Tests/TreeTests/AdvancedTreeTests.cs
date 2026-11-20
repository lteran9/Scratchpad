using DataStructures.Core.Trees;
using System;
using Xunit;

namespace DataStructures.Tests.TreeTests
{
   /// <summary>
   /// Tests advanced tree operations.
   /// </summary>
   public class AdvancedTreeTests
   {
      [Fact]
      public void IsBalancedBinaryTree()
      {

      }

      [Fact]
      public void IsFullBinaryTree()
      {
         var tree = new BinarySearchTree<int>(2);

         Assert.True(tree.IsFullBinaryTree(null));
         Assert.True(tree.IsFullBinaryTree(tree.Root));

         tree.AddNode(1);
         Assert.False(tree.IsFullBinaryTree(tree.Root));

         tree.AddNode(3);
         Assert.True(tree.IsFullBinaryTree(tree.Root));

         tree.AddNode(4);
         Assert.False(tree.IsFullBinaryTree(tree.Root));
      }

      [Fact]
      public void IsPerfectBinaryTree()
      {
         var tree = new BinarySearchTree<int>(2);

         Assert.True(tree.IsPerfectBinaryTree(null, 0));
         Assert.True(tree.IsPerfectBinaryTree(tree.Root, 1));
         Assert.False(tree.IsPerfectBinaryTree(tree.Root, 2));

         tree.AddNode(1);
         tree.AddNode(3);
         Assert.True(tree.IsPerfectBinaryTree(tree.Root, 2));

         tree.AddNode(4);
         Assert.False(tree.IsPerfectBinaryTree(tree.Root, 2));
      }

      [Fact]
      public void IsCompleteBinaryTree()
      {

      }
   }
}