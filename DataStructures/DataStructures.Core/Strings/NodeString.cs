using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.Strings
{
   public class NodeString : IString
   {
      public static IString Empty = new NodeString();

      public int Length { get; private set; }

      public char this[int index]
      {
         get
         {
            return new char();
         }
      }

      private Node<char> stringHead;

      public NodeString()
      {
         stringHead = null;
      }

      public NodeString(string value)
      {
         for (int i = 0; i < value.Length; i++)
         {
            if (stringHead == null)
            {
               stringHead = new Node<char>(value[i]);
            }
            else
            {
               var runner = stringHead;
               while (runner.Next != null)
               {
                  runner = runner.Next;
               }
               runner.Next = new Node<char>(value[i]);
            }
            Length++;
         }
      }

      public char[] ToCharArray()
      {
         return new char[0];
      }

      public bool Equals(IString other)
      {
         // Only compare elements if strings match in length
         if (Length == other.Length)
         {
            for (int i = 0; i < Length; i++)
            {
               // If sequence does not match at a given index, strings are not equal
               if (this[i] != other[i])
               {
                  return false;
               }
            }

            return true;
         }

         return false;
      }
   }
}