using System;
using DataStructures.Core.LinkedLists;
using DataStructures.UseCases.LinkedLists;
using DataStructures.UseCases.Factory;
using Xunit;
using System.Collections.Generic;

namespace DataStructures.Tests.LinkedListTests
{
    /// Common Interview Questions for Linked Lists
    public class InterviewQuestions
    {
        private readonly LinkedListManipulation _linkedListManipulation = new LinkedListManipulation();

        /// <summary>
        /// Remove duplicates from an unsorted singly linked list.
        /// </summary>
        [Fact]
        public void RemoveDuplicates_Easy()
        {
            var linkedList = LinkedListFactory.CreateSinglyLinkedList(3);
            linkedList.Add(1);
            linkedList.Add(7);
            linkedList.Add(5);
            linkedList.Add(3);
            linkedList.Add(11);
            linkedList.Add(1);

            Assert.Equal(7, linkedList.Count());
            var removeDuplicates = new RemoveDuplicates<int>(linkedList);
            linkedList = removeDuplicates.Execute();
            Assert.Equal(5, linkedList.Count());
        }

        [Fact]
        public void RemoveDuplicates_Medium()
        {
            var linkedList = LinkedListFactory.CreateSinglyLinkedList(1);
            linkedList.Add(1);
            linkedList.Add(1);
            linkedList.Add(1);
            linkedList.Add(1);
            linkedList.Add(1);
            linkedList.Add(1);
            linkedList.Add(1);
            linkedList.Add(1);

            Assert.Equal(9, linkedList.Size);
            var removeDuplicates = new RemoveDuplicates<int>(linkedList);
            linkedList = removeDuplicates.Execute();
            Assert.Equal(1, linkedList.Size);
        }

        [Fact]
        public void RemoveDuplicates_Hard()
        {
            var linkedList = LinkedListFactory.CreateSinglyLinkedList(0);
            linkedList.Add(0);
            linkedList.Add(27);
            linkedList.Add(19);
            linkedList.Add(5);
            linkedList.Add(7);
            linkedList.Add(7);
            linkedList.Add(0);

            Assert.Equal(8, linkedList.Size);
            var removeDuplicates = new RemoveDuplicates<int>(linkedList);
            linkedList = removeDuplicates.Execute();
            Assert.Equal(5, linkedList.Size);
        }

        /// <summary> 
        /// Return the Kth to Last:
        /// Implement an algorithm to find the kth to last element of a singly linked list.
        /// </summary>
        [Fact]
        public void ReturnKthToLast_Easy()
        {
            int k = 3;
            var linkedList = LinkedListFactory.CreateSinglyLinkedList(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(6);

            var kthToLast = linkedList.ReturnKthToLast(k);
            Assert.Equal(3, kthToLast.Data);
        }

        [Fact]
        public void ReturnKthToLast_Medium()
        {
            // First element, k is the size of the LinkedList
            int k = 7;
            var linkedList = LinkedListFactory.CreateSinglyLinkedList(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);

            var kthToLast = linkedList.ReturnKthToLast(k);
            Assert.Equal(0, kthToLast.Data);
        }

        [Fact]
        public void ReturnKthToLast_Hard()
        {
            // Last element, k is 0
            int k = 0;
            var linkedList = LinkedListFactory.CreateSinglyLinkedList(0);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);

            var kthToLast = linkedList.ReturnKthToLast(k);
            Assert.Equal(6, kthToLast.Data);
        }

        /// <summary>
        /// Delete Middle Node:
        /// Implement an algorithm to delete a node in the middle of a singly linked list, given only access to that node.
        /// </summary>
        [Fact]
        public void DeleteMiddleNode()
        {
            var linkedList = LinkedListFactory.CreateSinglyLinkedList('a');
            var bNode = new Node<char>('b');
            linkedList.Add(bNode);
            var cNode = new Node<char>('c');
            linkedList.Add(cNode);
            var dNode = new Node<char>('d');
            linkedList.Add(dNode);

            Assert.Equal(4, linkedList.Size);
            linkedList.DeleteMiddleNode(cNode);
            Assert.Equal(3, linkedList.Size);
        }

        /// <summary>
        /// Partition: 
        /// Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes grater than or equal to x. If x is contained within the list, the values of x only need to be after the elements less than x.
        /// </summary>
        [Fact]
        public void Partition()
        {
            //
        }

        /// <summary>
        /// Sum Lists:
        /// You have two numbers represented by a linked list, where each node contains a single digit. The digits are stored in reverse order, such that the 1's digit is at the head of the list. Write a function that adds the two numbers and returns the sum as a linked list.
        /// </summary>
        [Fact]
        public void SumLists_Easy()
        {
            // Single digit numbers

            var firstNumber = LinkedListFactory.CreateSinglyLinkedList(9);
            var secondNumber = LinkedListFactory.CreateSinglyLinkedList(1);

            var addition = _linkedListManipulation.SumLists(firstNumber, secondNumber);
            Assert.Equal(2, addition.Count());
            Assert.Equal(0, addition.Root.Data);
            Assert.Equal(1, addition.Root.Next.Data);
        }

        [Fact]
        public void SumLists_Medium()
        {
            // Same length lists 

            // 617
            var firstNumber = LinkedListFactory.CreateSinglyLinkedList(7);
            firstNumber.Add(1);
            firstNumber.Add(6);

            // 295
            var secondNumber = LinkedListFactory.CreateSinglyLinkedList(5);
            secondNumber.Add(9);
            secondNumber.Add(2);

            var addition = _linkedListManipulation.SumLists(firstNumber, secondNumber);
            // 912
            Assert.Equal(3, addition.Count());
            Assert.Equal(2, addition.Root.Data);
            Assert.Equal(1, addition.Root.Next.Data);
            Assert.Equal(9, addition.Root.Next.Next.Data);
        }

        [Fact]
        public void SumLists_Hard()
        {
            // Different length lists

            // 1024
            var firstNumber = LinkedListFactory.CreateSinglyLinkedList(4);
            firstNumber.Add(2);
            firstNumber.Add(0);
            firstNumber.Add(1);

            // 57
            var secondNumber = LinkedListFactory.CreateSinglyLinkedList(7);
            secondNumber.Add(5);

            var addition = _linkedListManipulation.SumLists(firstNumber, secondNumber);
            // 1081
            Assert.Equal(4, addition.Count());
            Assert.Equal(1, addition.Root.Data);
            Assert.Equal(8, addition.Root.Next.Data);
            Assert.Equal(0, addition.Root.Next.Next.Data);
            Assert.Equal(1, addition.Root.Next.Next.Next.Data);
        }

        /// <summary>
        /// Implement a function to check if a linked list is a <a href="https://en.wikipedia.org/wiki/Palindrome">Palindrome</a>.
        /// </summary>
        [Fact]
        public void Palindrome()
        {
            //
        }

        /// <summary>
        /// Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting 
        /// node. Note that the intersection is defined based on reference, not value. That is, if the kth 
        /// node of the first linked list is the exact same node (by reference) as the jth node of the second 
        /// linked list, then they are intersecting.
        /// </summary>
        [Fact]
        public void Intersection()
        {
            //
        }

        /// <summary>
        /// Loop Detection:
        /// Given a circular linked list, implement an algorithm that returns the node at the beginning of the loop. 
        ///
        /// Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so as to make a loop in the linked list.
        /// </summary>
        [Fact]
        public void LoopDetection()
        {
            //
        }

        /// <summary>
        /// Merge two sorted linked lists so that the resulting linked list is also sorted.
        /// </summary>
        [Theory]
        [MemberData(nameof(SortedLinkedLists))]
        public void JoinTwoSortedLists(Core.LinkedLists.LinkedList<int> aLinkedList, Core.LinkedLists.LinkedList<int> bLinkedList)
        {
            var sorted = _linkedListManipulation.SortTwoLists(aLinkedList, bLinkedList);

            Assert.True(sorted.Root != null);
        }

        [Fact]
        public void GivenASignlyLinkedList_WhenReversed_ThenReversed()
        {
            // Given
            var linkedList = new Core.LinkedLists.LinkedList<string>("HEAD");
            linkedList.Add("First");
            linkedList.Add("Second");
            linkedList.Add("Third");

            // When
            var reverseList = new ReverseSinglyLinkedList<string>(linkedList);
            var result = reverseList.Execute();

            // Then
            Assert.Equal(4, result.Count());
            Assert.Equal("Third", result.Root.Data);
            Assert.Equal("Second", result.Root.Next.Data);
            Assert.Equal("First", result.Root.Next.Next.Data);
            Assert.Equal("HEAD", result.Root.Next.Next.Next.Data);
        }

        public static IEnumerable<object[]> SortedLinkedLists =>
          new List<object[]>
          {
            new object[] { new Core.LinkedLists.LinkedList<int>(3, 7, 15, 18), new Core.LinkedLists.LinkedList<int>(2, 5, 21) },
            new object[] { new Core.LinkedLists.LinkedList<int>(3, 7, 15, 18), new Core.LinkedLists.LinkedList<int>(2, 5, 21, 26, 34) },
            new object[] { new Core.LinkedLists.LinkedList<int>(0, 2, 3, 5), new Core.LinkedLists.LinkedList<int>(0, 1, 4, 6) },
            new object[] { new Core.LinkedLists.LinkedList<int>(10, 20, 30, 40), new Core.LinkedLists.LinkedList<int>(11, 21, 31, 40) }
          };
    }
}