using System;
using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.Tests.LinkedListTests
{
   public class LinkedListTests
   {
      [Fact]
      public void DefaultTest()
      {
         var list = new LinkedList<string>("HEAD");

         Assert.Equal(1, list.Size);

         list.Add("Child1");
         list.Add("Child2");
         list.Add("Child3");

         //Assert.Equal("HEAD->Child1->Child2->Child3", list.Get());
         Assert.Equal(4, list.Size);

         list.Remove("Child2");
         //Assert.Equal("HEAD->Child1->Child3", list.Get());
         Assert.Equal(3, list.Size);
      }

      [Fact]
      public void AddTest_1()
      {
         var list = new LinkedList<string>("HEAD");
         list.Add("A");
         list.Add("B");
         list.Add("C");
         list.Add("D");
         list.Add("E");
         list.Add("F");
         list.Add("G");
         list.Add("H");
         list.Add("I");

         //Assert.Equal("HEAD->A->B->C->D->E->F->G->H->I", list.Get());
      }

      [Fact]
      public void RemoveTest_1()
      {
         var list = new LinkedList<string>("HEAD");

         list.Remove("");
         Assert.Equal(1, list.Size);

         list.Remove("HEAD");
         Assert.Equal(1, list.Size);
      }

      [Fact]
      public void RemoveTest_2()
      {
         var list = new LinkedList<string>("HEAD");
         list.Add("A");
         list.Add("B");
         list.Add("C");

         list.Remove("C");
         list.Remove("B");
         list.Remove("A");

         //Assert.Equal("HEAD", list.Get());
         Assert.Equal(1, list.Size);
      }
   }
}