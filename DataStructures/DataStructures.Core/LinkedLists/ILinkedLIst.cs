using System;

namespace DataStructures.Core.LinkedLists
{
    public interface ILinkedList<T>
    {
        void Add(T item);
        void Remove(T item);

        Node<T> Find(T item);
    }
}