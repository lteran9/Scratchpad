using System;

namespace DataStructures.Core.Stacks
{
    public interface IStack<T> where T : IComparable
    {
        bool IsEmpty();

        void Push(T item);

        T Peek();
        T Pop();
    }
}