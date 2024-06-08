using System;
using DataStructures.Core.Trees;
using Xunit;

namespace DataStructures.Tests.TreeTests
{
   public class TreeNodeTests
   {
      [Fact]
      public void TestCase_0()
      {
         // Tree with 3 nodes
         var root = new TreeNode<int>(0);
         root.AddLeftChild(new TreeNode<int>(1));
         root.AddRightChild(new TreeNode<int>(2));

         Assert.True(root.Data == 0);
         Assert.True(root.LeftChild.Data == 1);
         Assert.True(root.RightChild.Data == 2);
      }

      [Fact]
      public void TestCase_1()
      {
         // Tree with 5 nodes all right childs
         var leaf = new TreeNode<int>(5);
         var node4 = new TreeNode<int>(4);
         var node3 = new TreeNode<int>(3);
         var node2 = new TreeNode<int>(2);
         var root = new TreeNode<int>(1);

         node4.AddRightChild(leaf);
         node3.AddRightChild(node4);
         node2.AddRightChild(node3);
         root.AddRightChild(node2);

         Assert.True(root.Data == 1);
         Assert.True(root.RightChild.Data == 2);
         Assert.True(root.RightChild.RightChild.Data == 3);
         Assert.True(root.RightChild.RightChild.RightChild.Data == 4);
         Assert.True(root.RightChild.RightChild.RightChild.RightChild.Data == 5);
      }

      [Fact]
      public void TestCase_2()
      {
         // Tree with 5 nodes all left childs
         var leaf = new TreeNode<int>(10);
         var node4 = new TreeNode<int>(8);
         var node3 = new TreeNode<int>(6);
         var node2 = new TreeNode<int>(4);
         var root = new TreeNode<int>(2);

         node4.AddLeftChild(leaf);
         node3.AddLeftChild(node4);
         node2.AddLeftChild(node3);
         root.AddLeftChild(node2);

         Assert.True(root.Data == 2);
         Assert.True(root.LeftChild.Data == 4);
         Assert.True(root.LeftChild.LeftChild.Data == 6);
         Assert.True(root.LeftChild.LeftChild.LeftChild.Data == 8);
         Assert.True(root.LeftChild.LeftChild.LeftChild.LeftChild.Data == 10);
      }
   }
}