using System;
using DataStructures.Core.Arrays;
using Xunit;

namespace DataStructures.Tests.ArrayTests
{
   public class ImplementationTests
   {
      [Fact]
      public void ArrayTest_01()
      {
         var arr = new Array<int>();

         Assert.Equal(0, arr.Length);
         Assert.Throws<NullReferenceException>(() => arr[0]);
      }

      [Fact]
      public void ArrayTest_02()
      {
         var length = 20;
         var arr = new Array<int>(length);

         Assert.Equal(20, arr.Length);
         // All values initialized to default int value (0)
         for (int i = 0; i < length; i++)
         {
            Assert.Equal(0, arr[i]);
         }

         arr[length - 1] = 1000;
         Assert.Equal(1000, arr[length - 1]);
      }
   }
}