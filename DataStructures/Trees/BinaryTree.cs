using System;
using System.Collections.Generic;

namespace Trees
{
   public class BinaryTree<T>
   {
      public Comparer<T> Comparer = Comparer<T>.Default;
      public Node<T> Root { get; set; }

      public BinaryTree(T data)
      {
         Root = new Node<T>(data);
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
                  break;
               }
               else
               {
                  // Follow left child node
                  node = node.LeftChild;
               }
            }
         }
      }
   }
}