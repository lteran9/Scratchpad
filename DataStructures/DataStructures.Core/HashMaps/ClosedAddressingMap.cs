using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.HashMaps
{
    /// <summary>
    /// Closed addressing implementation. Collisions are handled by linked list in each bucket.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class ClosedAddressingMap<TKey, TValue> : IHashMap<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private readonly HashFunction<TKey> _hashFunction;

        private int count;
        private int addressSpace;
        private Node<(TKey, TValue)>[] array;

        public ClosedAddressingMap(int size = 10)
        {
            _hashFunction = new HashFunction<TKey>();

            addressSpace = size;
            Clear();
        }

        public int Size()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
            array = new Node<(TKey, TValue)>[addressSpace];
        }

        public void Rehash()
        {
            // Increase address space by a factor of 3
            addressSpace = count * 3;

            throw new NotImplementedException("Still need to implement method.");
        }

        public void Delete(TKey key)
        {
            var index = _hashFunction.GetHashCode(key, addressSpace);
            var current = array[index];
            Node<(TKey, TValue)> previous = null;

            while (current != null)
            {
                if (current.Data.Item1.Equals(key))
                {
                    if (previous == null)
                    {
                        array[index] = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    count--;
                    return;
                }

                previous = current;
                current = current.Next;
            }
        }

        public void Insert(TKey key, TValue value)
        {
            var index = _hashFunction.GetHashCode(key, addressSpace);
            var node = array[index];
            if (node == null)
            {
                array[index] = new Node<(TKey, TValue)>((key, value));
            }
            else
            {
                var runner = node;
                while (runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = new Node<(TKey, TValue)>((key, value));
            }
            count++;
        }

        public void Update(TKey key, TValue value)
        {
            var runner = array[_hashFunction.GetHashCode(key, addressSpace)];
            while (runner != null)
            {
                if (runner.Data.Item1.Equals(key))
                {
                    runner.Data = (key, value);
                    return;
                }

                runner = runner.Next;
            }
        }

        public bool Contains(TKey key)
        {
            return Lookup(key, out TValue _);
        }

        public bool Lookup(TKey key, out TValue value)
        {
            var runner = array[_hashFunction.GetHashCode(key, addressSpace)];
            while (runner != null)
            {
                if (runner.Data.Item1.Equals(key))
                {
                    value = runner.Data.Item2;
                    return true;
                }

                runner = runner.Next;
            }

            value = default;
            return false;
        }
    }
}
