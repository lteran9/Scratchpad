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
         queue.Push(1234);

         Assert.Equal(1234, queue.Peek());
      }

      [Fact]
      public void StackTest_02()
      {
         var queue = new Stack<int>();
         queue.Push(1234);

         Assert.Equal(1234, queue.Pop());
      }

      [Fact]
      public void StackTest_03()
      {
         var queue = new Stack<int>();
         // Exception is raised when there are no items in the queue
         Assert.Throws<InvalidOperationException>(() => queue.Peek());
         Assert.Throws<InvalidOperationException>(() => queue.Pop());
      }

      [Fact]
      public void StackTest_04()
      {
         var sentence = "The quick brown fox jumped over the lazy dog.".Split(" ");

         var queue = new Stack<string>();
         queue.Push("The");
         queue.Push("quick");
         queue.Push("brown");
         queue.Push("fox");
         queue.Push("jumped");
         queue.Push("over");
         queue.Push("the");
         queue.Push("lazy");
         queue.Push("dog.");

         for (int i = sentence.Length - 1; i >= 0; i--)
         {
            Assert.Equal(sentence[i], queue.Pop());
         }
      }
   }
}