using System;
using DataStructures.Core.Trees;

namespace DataStructures.UseCases.Trees
{
   public class PostOrderTraversal : IUseCase<string>
   {
      private readonly TreeNode<int> _root;

      public PostOrderTraversal(TreeNode<int> root)
      {
         _root = root;
      }

      public string Execute()
      {
         return Traverse(_root).TrimStart().TrimEnd();
      }

      private string Traverse(TreeNode<int> runner)
      {
         var output = string.Empty;

         if (runner.LeftChild != null)
         {
            var leftChild = Traverse(runner.LeftChild);
            output += leftChild;
         }

         if (runner.RightChild != null)
         {
            var rightChild = Traverse(runner.RightChild);
            output += !string.IsNullOrEmpty(output) ? " " + rightChild : rightChild;
         }

         return !string.IsNullOrEmpty(output) ? output + " " + runner.Data.ToString() : runner.Data.ToString();
      }
   }
}