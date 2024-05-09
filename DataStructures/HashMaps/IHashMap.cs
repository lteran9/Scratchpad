using System;

namespace DataStructures.HashMaps
{
   interface IHashMap<TKey, TValue> where TKey : IEquatable<TKey>
   {
      bool ContainsKey(TKey key);

      void Remove(TKey key);
      void Push(TKey key, TValue value);

      TValue Get(TKey key);
   }

}