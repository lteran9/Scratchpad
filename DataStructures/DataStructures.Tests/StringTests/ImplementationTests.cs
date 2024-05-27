using System;
using Xunit;
using DataStructures.Core.Strings;
using DataStructures.UseCases.Factory;

namespace DataStructures.Tests.StringTests
{
   public class ImplementationTests
   {
      private readonly StringFactory stringFactory = new StringFactory();

      [Fact]
      public void NodeStringEquality()
      {
         var original = "TestValue1";
         var nodeString = stringFactory.CreateNodeString(original);

         Assert.Equal(original.ToCharArray(), nodeString.ToCharArray());

         Assert.True(nodeString.Equals(original));
         Assert.True(nodeString.Equals(nodeString));

         Assert.False(nodeString.Equals(null));
         Assert.False(nodeString.Equals(1.0f));
      }

      [Fact]
      public void NodeStringConcatenation()
      {
         NodeString stringA = new NodeString("abc");
         NodeString stringB = new NodeString("def");

         string result = "abcdef";

         IString stringC = stringA + stringB;

         Assert.Equal(result.ToCharArray(), stringC.ToCharArray());
      }
   }
}