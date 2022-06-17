using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Strings
{
   /// <summary>
   /// Be careful with this class because it hides the .NET framework String.cs implementation.
   /// </summary>
   public class String
   {
      public static bool HasAllUniqueCharacters(string value)
      {
         try
         {
            // Validate passed in value is not empty
            if (string.IsNullOrEmpty(value) == false)
            {
               // Only account for ASCII characters which have a maximum range of 128
               var seenCharacters = new List<char>();
               // Loop through string characters once
               foreach (var character in value.ToCharArray())
               {
                  if (seenCharacters.Contains(character) == false)
                  {
                     seenCharacters.Add(character);
                  }
                  else
                  {
                     // We've seen this character before so return false
                     return false;
                  }
               }
               // All characters in value are unique
               return true;
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }

         return false;
      }

      public static bool HasAllUniqueCharacters_Linq(string value)
      {
         try
         {
            // Validate passed in value is not empty
            if (string.IsNullOrEmpty(value) == false)
            {
               // Group characters, select first, and compare length of original string
               return value.ToCharArray().GroupBy(x => x).Select(x => x.First()).Count() == value.Length;
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine(ex.Message);
         }

         return false;
      }
   }
}