using System;
using DataStructures.LinkedLists;

namespace DataStructures.HashMaps
{
   public class HashMap<TKey, TValue> : IHashMap<TKey, TValue> where TKey : IEquatable<TKey>
   {
      private readonly int _initialArraySize = 10;
      private readonly HashFunction<TKey> _hashFunction;

      private Node<TValue>[] array;

      public HashMap()
      {
         _hashFunction = new HashFunction<TKey>();
         array = new Node<TValue>[_initialArraySize];
      }

      public bool ContainsKey(TKey key)
      {
         return false;
      }

      public void Push(TKey key, TValue value)
      {

      }

      public void Remove(TKey key)
      {

      }

      public TValue Get(TKey key)
      {
         return default(TValue);
      }
   }
}