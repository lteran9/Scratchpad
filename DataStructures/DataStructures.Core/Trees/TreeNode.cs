using System;

namespace DataStructures.Core.Trees
{
   /// <summary>
   /// Data structure representation of a node for a binary tree, with left and right children.
   /// </summary>
   /// <typeparam name="T"></typeparam>
   public class TreeNode<T>
   {
      public T Data { get; set; }

      public TreeNode<T> LeftChild { get; set; }
      public TreeNode<T> RightChild { get; set; }

      public TreeNode(T data)
      {
         Data = data;
      }

      public TreeNode(T data, TreeNode<T> leftChild, TreeNode<T> rightChild)
      {
         Data = data;
         LeftChild = leftChild;
         RightChild = rightChild;
      }
   }
}