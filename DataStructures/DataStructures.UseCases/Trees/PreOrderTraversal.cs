using System;
using System.Resources;
using System.Text;
using DataStructures.Core.Trees;

namespace DataStructures.UseCases.Trees
{
   public class PreOrderTraversal : IUseCase<string>
   {
      private readonly TreeNode<int> _root;

      public PreOrderTraversal(TreeNode<int> root)
      {
         _root = root;
      }

      public string Execute()
      {
         return Traverse(_root).Trim();
      }

      private string Traverse(TreeNode<int> runner)
      {
         if (runner == null)
            return string.Empty;

         return runner.Data + " " + Traverse(runner.LeftChild) + Traverse(runner.RightChild);
      }
   }
}