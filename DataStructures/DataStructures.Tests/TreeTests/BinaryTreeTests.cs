using System;
using DataStructures.Core.Trees;
using Xunit;

namespace DataStructures.Tests.TreeTests
{
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

            //tree.DeleteNode(1);

            //Assert.Equal(4, tree.Length);
        }
    }
}