using System;

namespace DataStructures.UseCases.LinkedLists
{
    public class ReverseSinglyLinkedList<T> : IUseCase<Core.LinkedLists.LinkedList<T>>
    {
        private readonly Core.LinkedLists.LinkedList<T> _linkedList;

        public ReverseSinglyLinkedList(Core.LinkedLists.LinkedList<T> linkedList)
        {
            _linkedList = linkedList ?? throw new ArgumentException("Linked List cannot be null.");
        }

        public Core.LinkedLists.LinkedList<T> Execute()
        {
            Core.LinkedLists.Node<T>? prev = null;
            var runner = _linkedList.Root;

            while (runner != null)
            {
                var temp = runner.Next;
                runner.Next = prev;
                prev = runner;
                runner = temp;
            }

            return new Core.LinkedLists.LinkedList<T>(prev);
        }
    }
}
