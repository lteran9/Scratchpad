using System;

namespace DataStructures.Core.HashMaps
{
    /// <summary>
    /// Core properties of a good hash function:
    /// - Uniform distribution
    /// - Deterministic
    /// - Fast
    /// - Low collision rate
    /// - Appropriate output size
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HashFunction<T>
    {
        public int GetHashCode(T key, int capacity)
        {
            // Perform bitwise and to guarantee non-negative number
            return (key.GetHashCode() & int.MaxValue) % capacity;
        }

        public int CompositeHashCode(T key, int capacity)
        {
            // Perform bitwise and to guarantee non-negative number
            return (HashCode.Combine(key) & int.MaxValue) % capacity;
        }
    }
}
