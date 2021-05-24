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
      }
   }
}