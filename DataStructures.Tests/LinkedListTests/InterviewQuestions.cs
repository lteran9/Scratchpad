using System;
using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.LinkedListTests
{
   public class InterviewQuestions
   {
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

         Assert.Equal(5, linkedList.Size);

         linkedList.Add("Child2");
         linkedList.Add("Child5");
         linkedList.Add("Child3");

         linkedList.RemoveDuplicates();

         Assert.Equal(6, linkedList.Size);
      }

      /// <summary> 
      /// Return the Kth to last element in the linked list.
      /// </summary>
      [Fact]
      public void ReturnKthToLast()
      {
         //
      }
   }
}