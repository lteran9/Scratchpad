using Trees;
using Xunit;
using System;

namespace DataStructures.TreeTests
{
   public class BinaryTreeTests 
   {
      [Fact]
      public void SampleTest()
      {
         var tree = new BinaryTree<int>(10);

         tree.AddNode(7);
         tree.AddNode(12);
         tree.AddNode(3);
         tree.AddNode(15);
      }
   }
}