using System;
using DataStructures.Core.LinkedLists;

namespace DataStructures.UseCases.LinkedLists
{
    public class RemoveDuplicates<T> : IUseCase<Core.LinkedLists.LinkedList<T>>
    {
        private readonly Core.LinkedLists.LinkedList<T> _linkedList;

        public RemoveDuplicates(Core.LinkedLists.LinkedList<T> linkedList)
        {
            _linkedList = linkedList;
        }

        public Core.LinkedLists.LinkedList<T> Execute()
        {
            var head = _linkedList.Root;

            RemoveDuplicateValues(head);

            return _linkedList;
        }

        /// <summary>
        /// Remove all instances of value from the list.
        /// </summary>
        /// <param name="runner"></param>
        /// <param name="value"></param>
        private void RemoveDuplicateValues(Node<T>? head)
        {
            if (head == null) return;

            var seen = new HashSet<T>();
            seen.Add(head.Data);

            var runner = head;
            while (runner.Next != null)
            {
                if (seen.Contains(runner.Next.Data))
                {
                    // Skip due to duplicate node
                    runner.Next = runner.Next.Next;
                }
                else
                {
                    // Add to seen list
                    seen.Add(runner.Next.Data);
                    runner = runner.Next;
                }
            }
        }

    }
}