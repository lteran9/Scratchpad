using System;
using DataStructures.Core.Strings;
using DataStructures.UseCases;
using Xunit;

namespace DataStructures.Tests.StringTests
{
   public class ImplementationTests
   {
      private readonly StringManipulation stringFactory = new StringManipulation();

      [Fact]
      public void CreateNodeString()
      {
         var original = "TestValue1";
         var nodeString = stringFactory.CreateNodeString(original);

         Assert.Equal(original.ToCharArray(), nodeString.ToCharArray());
         Assert.True(nodeString.Equals(original));
      }
   }
}