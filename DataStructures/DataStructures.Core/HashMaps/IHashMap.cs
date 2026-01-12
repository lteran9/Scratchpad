using System;

namespace DataStructures.Core.HashMaps
{
    interface IHashMap<TKey, TValue> where TKey : IEquatable<TKey>
    {
        int Size();

        void Clear();
        void Rehash();
        void Delete(TKey key);
        void Insert(TKey key, TValue value);
        void Update(TKey key, TValue value);

        bool Contains(TKey key);

        TValue Lookup(TKey key);
    }
}
