using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.Strings
{
   public class NodeString : IString
   {
      public static IString Empty = new NodeString();
      public static IString operator +(NodeString a, NodeString b)
      {
         // Join both linked list nodes
         a.stringTail = b.stringHead;
         // Return first string
         return a;
      }

      public int Length { get; private set; }

      public char this[int index]
      {
         get
         {
            if (index < Length)
            {
               var runner = stringHead;
               for (int i = 0; i < index; i++)
               {
                  runner = runner.Next;
               }

               return runner.Data;
            }

            throw new Exception("Index out of range.");
         }
      }

      private Node<char> stringHead;
      private Node<char> stringTail;

      public NodeString()
      {
         stringHead = null;
         stringTail = null;
      }

      public NodeString(string value)
      {
         for (int i = 0; i < value.Length; i++)
         {
            if (stringHead == null)
            {
               stringHead = stringTail = new Node<char>(value[i]);
               stringHead.Next = stringTail;
            }
            else
            {
               stringTail.Next = new Node<char>(value[i]);
               stringTail = stringTail.Next;
            }
            Length++;
         }
      }

      public char[] ToCharArray()
      {
         if (Length > 0)
         {
            var result = new char[Length];
            var runner = stringHead;
            int index = 0;
            while (runner != null)
            {
               result[index] = runner.Data;
               runner = runner.Next;
               index++;
            }

            return result;
         }

         return new char[0];
      }

      public bool Equals(IString other)
      {
         // Only compare elements if strings match in length
         if (Length == other?.Length)
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

      /// <summary>
      /// 
      /// </summary>
      /// <param name="other"></param>
      /// <returns></returns>
      public override bool Equals(object other)
      {
         if (other is string)
         {
            var otherString = new NodeString((string)other);

            return Equals(otherString);
         }

         return false;
      }

      public override int GetHashCode()
      {
         return base.GetHashCode();
      }
   }
}