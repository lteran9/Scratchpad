using System;
using Xunit;
using DataStructures.Core.Stacks;


namespace DataStructures.Tests.StackTests
{
   public class ImplementationTests
   {
      [Fact]
      public void StackTest_01()
      {
         var queue = new Stack<int>();
         queue.Add(1234);

         Assert.Equal(1234, queue.Peek());
      }

      [Fact]
      public void StackTest_02()
      {
         var queue = new Stack<int>();
         queue.Add(1234);

         Assert.Equal(1234, queue.Pop());
      }

      [Fact]
      public void StackTest_03()
      {
         var queue = new Stack<int>();
         // Exception is raised when there are no items in the queue
         Assert.Throws<Exception>(() => queue.Peek());
         Assert.Throws<Exception>(() => queue.Pop());
      }

      [Fact]
      public void StackTest_04()
      {
         var sentence = "The quick brown fox jumped over the lazy dog.".Split(" ");

         var queue = new Stack<string>();
         queue.Add("The");
         queue.Add("quick");
         queue.Add("brown");
         queue.Add("fox");
         queue.Add("jumped");
         queue.Add("over");
         queue.Add("the");
         queue.Add("lazy");
         queue.Add("dog.");

         for (int i = sentence.Length - 1; i >= 0; i--)
         {
            Assert.Equal(sentence[i], queue.Pop());
         }
      }
   }
}