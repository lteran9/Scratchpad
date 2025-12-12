using System;
using System.Collections.Generic;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.Trees
{
    /// <summary>
    /// Binary tree used to represent data in a hierarchical format; every node has two children (at most)
    /// and is either a a branch or a leaf.
    ///
    /// https://www.programiz.com/dsa/trees
    /// </summary>
    public class BinarySearchTree<T>
    {
        public int Length { get; set; }

        /// <summary>
        /// Root node; starting point of the tree.
        /// </summary>
        public TreeNode<T> Root { get; private set; }
        public Comparer<T> Comparer = Comparer<T>.Default;

        /// <summary>
        /// Initialize a new binary tree with the given data at the root node.
        /// </summary>
        public BinarySearchTree(T data)
        {
            Root = new TreeNode<T>(data);
            Length = 1;
        }

        public void AddNode(T data)
        {
            Root = AddNode(Root, data);
        }

        private TreeNode<T> AddNode(TreeNode<T> root, T data)
        {
            if (root == null)
            {
                Length++;
                return new TreeNode<T>(data);
            }

            if (Comparer.Compare(data, root.Data) < 0)
            {
                root.AddLeftChild(AddNode(root.LeftChild, data));
            }

            if (Comparer.Compare(data, root.Data) > 0)
            {
                root.AddRightChild(AddNode(root.RightChild, data));
            }

            return root;
        }

        public void DeleteNode(T data)
        {
            Root = DeleteNode(Root, data);
        }

        private TreeNode<T> DeleteNode(TreeNode<T> root, T data)
        {
            if (root == null)
            {
                return null;
            }

            if (Comparer.Compare(data, root.Data) < 0)
            {
                return DeleteNode(root.LeftChild, data);
            }
            else if (Comparer.Compare(data, root.Data) > 0)
            {
                return DeleteNode(root.RightChild, data);
            }
            else
            {
                // We found the node

                // CASE 1: There is no left child
                if (root.LeftChild == null)
                {
                    return root.RightChild;
                }

                // CASE 2: There is no right child
                if (root.RightChild == null)
                {
                    return root.LeftChild;
                }

                // CASE 3: There are two children
                // Find inorder successor (smallest value in right subtree)

            }

            return root;
        }

        public bool HasNode(T data)
        {
            return Search(Root, data);
        }

        private bool Search(TreeNode<T> root, T data)
        {
            if (root == null)
            {
                return false;
            }
            else if (Comparer.Compare(data, root.Data) < 0)
            {
                return Search(root.LeftChild, data);
            }
            else if (Comparer.Compare(data, root.Data) > 0)
            {
                return Search(root.RightChild, data);
            }

            return true;
        }

        public void Rebalance()
        {

        }

        public int GetHeight()
        {
            return GetHeight(Root);
        }

        /// <summary> 
        /// A full binary tree is a special type of binary tree in which every parent node and child node has either two or no children.<br/>
        ///
        /// Theorem:<br/> Let i = number of internal nodes, n = number of nodes, l = number of leaves, a = number of levels <br/>
        ///   - The number of leaves is `i + 1`<br/>
        ///   - The number of total nodes is `2i + 1`<br/>
        ///   - The number of internal nodes is `(n - 1) / 2`<br/>
        ///   - The number of leaves is `(n + 1) / 2`<br/>
        ///   - The total number of nodes is `2l - 1`<br/>
        ///   - The number of internal nodes is `l - 1`<br/>
        ///   - The number of leaves is at most `2^(a - 1)`
        /// </summary>
        public bool IsFullBinaryTree(TreeNode<T> node)
        {
            if (node == null)
                return true;

            if (node.LeftChild == null && node.RightChild == null)
                return true;

            if ((node.LeftChild != null) && (node.RightChild != null))
                return IsFullBinaryTree(node.LeftChild) && IsFullBinaryTree(node.RightChild);

            return false;
        }

        /// <summary>
        /// A perfect binary tree is a type of binary tree in which every internal node has exactly two child nodes and all the leaf nodes are at the same level.<br/>
        ///
        /// Theorem:<br/>
        ///   - If a single node has no children, it is a perfect binary tree of height `h = 0`<br/>
        ///   - If a node has `h > 0`, it is a perfect binary tree if both of its subtrees are of height `h - 1` and are non-overlapping.
        /// </summary>
        public bool IsPerfectBinaryTree(TreeNode<T> root, int depth, int level = 0)
        {
            if (root == null)
                return true;

            if (root.LeftChild == null && root.RightChild == null)
                return depth == (level + 1);

            if (root.LeftChild == null || root.RightChild == null)
                return false;

            return IsPerfectBinaryTree(root.LeftChild, depth, level + 1) && IsPerfectBinaryTree(root.RightChild, depth, level + 1);
        }

        /// <summary>
        /// A complete binary tree...
        /// </summary>
        public bool IsCompleteBinaryTree()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A balanced binary tree...
        /// </summary>
        public bool IsBalancedBinaryTree()
        {
            throw new NotImplementedException();
        }

        private int GetHeight(TreeNode<T> node)
        {
            if (node == null)
            {
                return -1;
            }

            int leftH = GetHeight(node.LeftChild);
            int rightH = GetHeight(node.RightChild);

            if (leftH > rightH)
            {
                return leftH + 1;
            }
            else
            {
                return rightH + 1;
            }
        }
    }
}