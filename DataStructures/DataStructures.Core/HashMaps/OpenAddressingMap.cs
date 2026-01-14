using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DataStructures.Core.LinkedLists;

namespace DataStructures.Core.HashMaps
{
    public class OpenAddressingMap<TKey, TValue> : IHashMap<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private readonly HashFunction<TKey> _hashFunction;

        private int count;
        private int addressSpace;
        private Node<(TKey, TValue)>[] array;

        public OpenAddressingMap(int size = 10)
        {
            _hashFunction = new HashFunction<TKey>();

            count = 0;
            addressSpace = size;
            array = new Node<(TKey, TValue)>[addressSpace];
        }

        public int Size()
        {
            return count;
        }

        public void Clear()
        {
            array = new Node<(TKey, TValue)>[addressSpace];
        }

        public void Rehash()
        {
            // Increase address space by a factor of 3
            addressSpace = count * 3;
        }

        public void Delete(TKey key)
        {
            var node = array[_hashFunction.GetHashCode(key, addressSpace)];
            if (node != null)
            {
                var runner = node;
                while (runner != null)
                {
                    if (runner.Data.Item1.Equals(key))
                    {
                        runner = runner.Next;
                        count--;
                    }
                }
            }
        }

        public void Insert(TKey key, TValue value)
        {
            var node = array[_hashFunction.GetHashCode(key, addressSpace)];
            if (node == null)
            {
                array[_hashFunction.GetHashCode(key, addressSpace)] = new Node<(TKey, TValue)>((key, value));
            }
            else
            {
                var runner = array[_hashFunction.GetHashCode(key, addressSpace)];
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
            if (array[_hashFunction.GetHashCode(key, addressSpace)] != null)
            {
                var runner = array[_hashFunction.GetHashCode(key, addressSpace)];
                while (runner != null)
                {
                    if (runner.Data.Item1.Equals(key))
                    {
                        var temp = runner.Next;
                        runner = new Node<(TKey, TValue)>((key, value));
                        runner.Next = temp;
                    }
                }
            }
        }

        public bool Contains(TKey key)
        {
            return Lookup(key, out TValue _);
        }

        public bool Lookup(TKey key, out TValue value)
        {
            if (array[_hashFunction.GetHashCode(key, addressSpace)] != null)
            {
                var runner = array[_hashFunction.GetHashCode(key, addressSpace)];
                while (runner != null)
                {
                    if (runner.Data.Item1.Equals(key))
                    {
                        value = runner.Data.Item2;
                        return true;
                    }
                }
            }

            value = default;
            return false;
        }
    }
}
