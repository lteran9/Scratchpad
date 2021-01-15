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
         var node = Root;

         if (Comparer.Compare(data, node.Data) == 0)
         {

         }
         
         if (Comparer.Compare(data, node.Data) > 0)
         {

         }

         if (Comparer.Compare(data, node.Data) < 0)
         {

         }
      }
   }
}