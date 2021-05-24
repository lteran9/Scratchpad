using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
   /// <summary>
   /// Binary tree used to represent data in a hierarchical format; every node has two children (at most)
   /// and is either a a branch or a leaf.
   /// </summary>
   public class BinaryTree<T>
   {
      public int Length { get; set; }

      /// <summary>
      /// Root node; starting point of the tree.
      /// </summary>
      public Node<T> Root { get; set; }
      public Comparer<T> Comparer = Comparer<T>.Default;

      /// <summary>
      /// Initialize a new binary tree with the given data at the root node.
      /// </summary>
      public BinaryTree(T data)
      {
         Root = new Node<T>(data);
         Length = 1;
      }

      public void AddNode(T data)
      {
         // Get reference to root node
         var node = Root;

         while (true)
         {
            // If data is greater than node data
            if (Comparer.Compare(data, node.Data) > 0)
            {
               // If right child null then add data as right child
               if (node.RightChild == null)
               {
                  node.RightChild = new Node<T>(data);
                  Length++;
                  break;
               }
               else
               {
                  // Follow right child node
                  node = node.RightChild;
               }
            }

            // If data is less than node ndata
            if (Comparer.Compare(data, node.Data) < 0)
            {
               // If left child null then add data as left child
               if (node.LeftChild == null)
               {
                  node.LeftChild = new Node<T>(data);
                  Length++;
                  break;
               }
               else
               {
                  // Follow left child node
                  node = node.LeftChild;
               }
            }

            // Cannot add the same data again 
            if (Comparer.Compare(data, node.Data) == 0)
               break;
         }
      }

      public void Rebalance()
      {
         void RotateLeft()
         {

         }

         void RotateRight()
         {

         }
      }

      public int GetHeight()
      {
         return GetHeight(Root);
      }

      int GetHeight(Node<T> node)
      {
         if (node == null)
            return -1;

         int lefth = GetHeight(node.LeftChild);
         int righth = GetHeight(node.RightChild);

         if (lefth > righth)
         {
            return lefth + 1;
         }
         else
         {
            return righth + 1;
         }
      }
   }
}