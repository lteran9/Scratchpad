using System;
using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.Tests.LinkedListTests
{
   /// Common Interview Questions for Linked Lists
   public class InterviewQuestions
   {
      /// <summary>
      /// Remove duplicates from an unsorted singly linked list.
      /// </summary>
      [Fact]
      public void RemoveDuplicates_Easy()
      {
         var linkedList = new LinkedList<int>(3);
         linkedList.Add(1);
         linkedList.Add(7);
         linkedList.Add(5);
         linkedList.Add(3);
         linkedList.Add(11);
         linkedList.Add(1);

         Assert.Equal(7, linkedList.Count());
         linkedList.RemoveDuplicates();
         Assert.Equal(5, linkedList.Count());
      }

      [Fact]
      public void RemoveDuplicates_Medium()
      {
         var linkedList = new LinkedList<int>(1);
         linkedList.Add(1);
         linkedList.Add(1);
         linkedList.Add(1);
         linkedList.Add(1);
         linkedList.Add(1);
         linkedList.Add(1);
         linkedList.Add(1);
         linkedList.Add(1);

         Assert.Equal(9, linkedList.Size);
         linkedList.RemoveDuplicates();
         Assert.Equal(1, linkedList.Size);
      }

      [Fact]
      public void RemoveDuplicates_Hard()
      {
         var linkedList = new LinkedList<int>(0);
         linkedList.Add(0);
         linkedList.Add(27);
         linkedList.Add(19);
         linkedList.Add(5);
         linkedList.Add(7);
         linkedList.Add(7);
         linkedList.Add(0);

         Assert.Equal(8, linkedList.Size);
         linkedList.RemoveDuplicates();
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
         var linkedList = new LinkedList<int>(0);
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
         var linkedList = new LinkedList<int>(0);
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
         var linkedList = new LinkedList<int>(0);
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