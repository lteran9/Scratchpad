using System;
using DataStructures.Trees;

namespace DataStructures.Tests.TreeTests
{
   /// <summary>
   /// Use this base class to inherit multiple binary trees to test with.
   /// </summary>
   public class BaseTree
   {
      protected BinaryTree<int> BalancedTree
      {
         get
         {
            return new BinaryTree<int>(0);
         }
      }
   }
}