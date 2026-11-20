using System;
using DataStructures.Core.Trees;
using Xunit;

namespace DataStructures.Tests.TreeTests
{
    /// <summary>
    /// Tests binary tree operations.
    /// </summary>
    public class BinaryTreeTests
    {
        [Fact]
        public void TreeHeightTests()
        {
            var tree = new BinarySearchTree<int>(2);

            Assert.Equal(0, tree.GetHeight());

            tree.AddNode(1);
            tree.AddNode(3);

            Assert.Equal(1, tree.GetHeight());
        }

        [Fact]
        public void SimpleAddTest()
        {
            var tree = new BinarySearchTree<int>(10);

            tree.AddNode(7);
            tree.AddNode(12);
            tree.AddNode(3);
            tree.AddNode(15);

            Assert.Equal(10, tree.Root.Data);
            Assert.Equal(7, tree.Root.LeftChild.Data);
            Assert.Equal(12, tree.Root.RightChild.Data);
            Assert.Equal(5, tree.Length);
        }

        [Fact]
        public void PreventDuplicatesTest()
        {
            var tree = new BinarySearchTree<int>(5);

            tree.AddNode(5);
            tree.AddNode(6);
            tree.AddNode(5);
            tree.AddNode(5);
            tree.AddNode(6);
            tree.AddNode(5);

            Assert.Equal(2, tree.Length);
        }

        [Fact]
        public void SearchForValue()
        {
            var tree = new BinarySearchTree<int>(7);
            tree.AddNode(4);
            tree.AddNode(9);
            tree.AddNode(8);
            tree.AddNode(1);

            Assert.True(tree.HasNode(1));
            Assert.True(tree.HasNode(8));
            Assert.False(tree.HasNode(0));
        }

        [Fact]
        public void DeleteNode()
        {
            var tree = new BinarySearchTree<int>(7);
            tree.AddNode(4);
            tree.AddNode(9);
            tree.AddNode(8);
            tree.AddNode(1);

            tree.DeleteNode(1);
            Assert.False(tree.HasNode(1));
            Assert.Equal(4, tree.Length);
            Assert.Equal(7, tree.Root.Data);

            tree.DeleteNode(9);
            Assert.False(tree.HasNode(9));
            Assert.Equal(8, tree.Root.RightChild.Data);
            Assert.Equal(3, tree.Length);

            tree.DeleteNode(7);
            Assert.Equal(8, tree.Root.Data);
            Assert.True(tree.HasNode(4));
            Assert.True(tree.HasNode(8));
            Assert.Equal(2, tree.Length);

            tree.DeleteNode(99);
            Assert.Equal(2, tree.Length);

            var rightChildTree = new BinarySearchTree<int>(7);
            rightChildTree.AddNode(9);
            rightChildTree.AddNode(10);
            rightChildTree.DeleteNode(9);
            Assert.Equal(10, rightChildTree.Root.RightChild.Data);
            Assert.Equal(2, rightChildTree.Length);
        }

        [Fact]
        public void GivenTwoChildNodeWithDeeperSuccessor_WhenDeleted_ThenPreservesSuccessorRightChild()
        {
            var tree = new BinarySearchTree<int>(7);
            tree.AddNode(4);
            tree.AddNode(10);
            tree.AddNode(8);
            tree.AddNode(9);

            tree.DeleteNode(7);

            Assert.Equal(8, tree.Root.Data);
            Assert.Equal(10, tree.Root.RightChild.Data);
            Assert.Equal(9, tree.Root.RightChild.LeftChild.Data);
            Assert.False(tree.HasNode(7));
            foreach (var value in new[] { 4, 8, 9, 10 })
            {
                Assert.True(tree.HasNode(value));
            }
            Assert.Equal(4, tree.Length);
        }
    }
}