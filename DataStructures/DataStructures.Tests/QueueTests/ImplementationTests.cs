using System;
using Xunit;
using DataStructures.Core.Queues;

namespace DataStructures.Tests.QueueTests
{
   public class ImplementationTests 
   {
      [Fact]
      public void QueueTest_01() 
      {
         var queue = new Queue<int>();
         queue.Add(1234);

         Assert.Equal(1234, queue.Peek());
      }

      [Fact]
      public void QueueTest_02() 
      {
         var queue = new Queue<int>();
         queue.Add(1234);

         Assert.Equal(1234, queue.Pop());
      }

      [Fact]
      public void QueueTest_03() 
      {
         var queue = new Queue<int>();
         // Exception is raised when there are no items in the queue
         Assert.Throws<Exception>(() => queue.Peek());
         Assert.Throws<Exception>(() => queue.Pop());
      }

      [Fact]
      public void QueueTest_04() 
      {
         var sentence = "The quick brown fox jumped over the lazy dog.".Split(" ");

         var queue = new Queue<string>();
         queue.Add("The");
         queue.Add("quick");
         queue.Add("brown");
         queue.Add("fox");
         queue.Add("jumped");
         queue.Add("over");
         queue.Add("the");
         queue.Add("lazy");
         queue.Add("dog.");

         for (int i = 0; i < sentence.Length; i++) 
         {
            Assert.Equal(sentence[i], queue.Pop());
         }
      }
   }
}