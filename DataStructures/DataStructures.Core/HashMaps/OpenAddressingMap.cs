using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.HashMaps
{
    public class OpenAddressingMap<TKey, TValue> : IHashMap<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private readonly int _initialSize;
        private readonly HashFunction<TKey> _hashFunction;

        private int count;
        private Node<TValue>[] array;

        public OpenAddressingMap(int size = 10)
        {
            _initialSize = size;
            _hashFunction = new HashFunction<TKey>();

            array = new Node<TValue>[_initialSize];
        }

        public int Size()
        {
            return count;
        }

        public void Clear()
        {
            array = new Node<TValue>[_initialSize];
        }

        public void Rehash()
        {

        }

        public void Delete(TKey key)
        {
            if (Lookup(key) != null)
            {

            }
        }

        public void Insert(TKey key, TValue value)
        {
            var llist = array[_hashFunction.GetHashCode(key)];
            if (llist == null)
            {
                array[_hashFunction.GetHashCode(key)] = new Node<TValue>(value);
            }
            else
            {
                array[_hashFunction.GetHashCode(key)].Next = new Node<TValue>(value);
            }
        }

        public void Update(TKey key, TValue value)
        {

        }

        public bool Contains(TKey key)
        {
            return array[_hashFunction.GetHashCode(key)] != null;
        }

        public TValue Lookup(TKey key)
        {
            return default(TValue);
        }
    }
}
