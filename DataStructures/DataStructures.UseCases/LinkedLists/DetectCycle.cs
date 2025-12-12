using System;

namespace DataStructures.UseCases.LinkedLists
{
    public class DetectCycle<T> : IUseCase<bool>
    {
        private readonly Core.LinkedLists.LinkedList<T> _linkedList;

        public DetectCycle(Core.LinkedLists.LinkedList<T> linkedList)
        {
            _linkedList = linkedList ?? throw new ArgumentException("Linked List cannot be null.");
        }

        public bool Execute()
        {
            var slow = _linkedList.Root;
            var fast = _linkedList.Root;

            // Tortoise and Hare algorithm
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}