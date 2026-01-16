using System;

namespace DataStructures.Core.HashMaps
{
    public class HashFunction<T>
    {
        public int GetHashCode(T key, int size)
        {
            return key.GetHashCode() % size;
        }
    }
}
