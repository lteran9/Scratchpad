using System;
using DataStructures.Core.Trees;

namespace DataStructures.UseCases.Trees
{
   public class InOrderTraversal : IUseCase<string>
   {
      private readonly TreeNode<int> _head;

      public InOrderTraversal(TreeNode<int> head)
      {
         _head = head;
      }

      public string Execute()
      {
         return Traverse(_head).Trim();
      }

      private string Traverse(TreeNode<int> runner)
      {
         if (runner == null)
            return string.Empty;

         var leftChild = Traverse(runner.LeftChild);
         var rightChild = Traverse(runner.RightChild);

         return
            (!string.IsNullOrEmpty(leftChild) ? leftChild.Trim() + " " : "") + runner.Data + (!string.IsNullOrEmpty(rightChild) ? " " + rightChild + " " : "");
      }
   }
}