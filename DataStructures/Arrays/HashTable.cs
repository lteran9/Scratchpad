using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
   /// <summary>
   /// A hash table is a data structure that maps keys to values for highly efficient lookup (i.e. Dictionary). Features of a hash table:
   /// - stores key/value pairs
   /// - specifies an object to be used as key and a value we want to associate to that key
   ///   - the hashed key is used as an index at which the value is stored in a table
   /// - provides not fail-fast enumeration of values
   ///
   /// </summary>
   public class HashTable<TKey, TValue>
   {
      public Dictionary<TKey, TValue> Table { get; private set; }

      public HashTable()
      {
         Table = new Dictionary<TKey, TValue>();
      }

      public void Add(TKey key, TValue value)
      {
         if (Table.ContainsKey(key))
         {
            Table[key] = value;
         }
         else
         {
            Table.Add(key, value);
         }
      }

      public void Remove(TKey key)
      {
         Table.Remove(key);
      }
   }
}