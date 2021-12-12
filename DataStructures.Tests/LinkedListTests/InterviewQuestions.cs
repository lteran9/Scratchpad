using System;
using System.Collections.Generic;
using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.LinkedListTests
{
   /// Common Interview Questions for Linked Lists
   public class InterviewQuestions
   {
      private LinkedList SinglyLinkedList
      {
         get
         {
            #region Set Up
            var linkedList = new LinkedList();
            linkedList.Add("Child1");
            linkedList.Add("Child2");
            linkedList.Add("Child3");
            linkedList.Add("Child4");
            linkedList.Add("Child5");
            #endregion

            return linkedList;
         }
      }

      /// <summary>
      /// Remove duplicates from an unsorted linked list.
      /// </summary>
      [Fact]
      public void RemoveDuplicates()
      {
         var linkedList = new LinkedList();
         linkedList.Add("Child1");
         linkedList.Add("Child2");
         linkedList.Add("Child3");
         linkedList.Add("Child4");

         linkedList.RemoveDuplicates();

         Assert.Equal(4, linkedList.Size);

         linkedList.Add("Child2");
         linkedList.Add("Child5");
         linkedList.Add("Child3");

         linkedList.RemoveDuplicates();

         Assert.Equal(5, linkedList.Size);
      }

      /// <summary> 
      /// Return the Kth to Last:
      /// Implement an algorithm to find the kth to last element of a singly linked list.
      /// </summary>
      [Fact]
      public void ReturnKthToLast()
      {
         int k = 3;

         var local = SinglyLinkedList.Root;
         var stack = new Stack<Node<string>>();

         while (local != null)
         {
            stack.Push(local);
            local = local.Next;
         }

         Node<string> result = null;

         while (k > 0)
         {
            result = stack.Pop();
            k--;
         }

         Assert.Equal("Child3", result.Data);
      }

      /// <summary>
      /// Delete Middle Node:
      /// Implement an algorithm to delete a node in the middle of a singly linked list, given only access to that node.
      /// </summary>
      [Fact]
      public void DeleteMiddleNode()
      {
         //
      }

      /// <summary>
      /// Partition:
      /// Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes grater than or equal to x. If x is contained within the list, the values of x only need to be after the elements less than x (see below).
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
      public void SumLists()
      {
         //
      }

      /// <summary>
      /// Palindrome:
      /// Implement a function to check if a linked list is a palindrome.
      /// </summary>
      [Fact]
      public void Palindrome()
      {
         //
      }

      /// <summary>
      /// Intersection:
      /// Given two (singly) linked lists, determine if the two lists intersect. Return th eintersecting node. Note that the intersection is defined based on reference, not value. That is, if the kth node of the first linked list is the exact same node (by reference) as the jth node of the second linked list, then they are intersecting.
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
   }
}