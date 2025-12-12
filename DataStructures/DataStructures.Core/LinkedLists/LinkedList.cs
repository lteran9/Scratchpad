using System;
using System.Text;

namespace DataStructures.Core.LinkedLists
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public int Size { get { return Count(); } }

        public Node<T> Root { get; set; }

        public LinkedList() { }

        public LinkedList(T head)
        {
            Root = new Node<T>(head);
        }

        public LinkedList(Node<T> head)
        {
            Root = head;
        }

        public LinkedList(params T[] values)
        {
            if (values.Length > 0)
            {
                Root = new Node<T>(values[0]);

                if (values.Length > 1)
                {
                    for (int i = 1; i < values.Length; i++)
                    {
                        Add(values[i]);
                    }
                }
            }
        }

        public void Add(T value)
        {
            if (value != null)
            {
                if (Root == null)
                {
                    Root = new Node<T>(value);
                }
                else
                {
                    var runner = Root;

                    while (runner.Next != null)
                    {
                        runner = runner.Next;
                    }

                    runner.Next = new Node<T>(value);
                }
            }
        }

        public void Add(Node<T> node)
        {
            if (node != null)
            {
                if (Size == 0)
                {
                    Root = node;
                }
                else
                {
                    var runner = Root;

                    while (runner.Next != null)
                    {
                        runner = runner.Next;
                    }

                    runner.Next = node;
                }
            }
        }

        /// <summary>
        /// Returns the first instance of a Node with value of T found in the linked list. 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node<T> Find(T data)
        {
            if (Root != null)
            {
                var runner = Root;

                while (runner != null)
                {
                    if (runner.Data.Equals(data))
                    {
                        return runner;
                    }

                    runner = runner.Next;
                }
            }

            return null;
        }

        /// <summary>
        /// Returns the Node at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Node<T> GetAt(int index)
        {
            if (Root != null)
            {
                int loops = 0;
                var runner = Root;
                while (runner != null)
                {
                    if (loops == index)
                    {
                        return runner;
                    }
                    loops++;
                    runner = runner.Next;
                }
            }

            return null;
        }

        /// <summary>
        /// Removes the first instance of T found in the linked list.
        /// </summary>
        /// <param name="value"></param> 
        /// <returns></returns>
        public void Remove(T value)
        {
            // Do not allow the removal of the Head node
            if (Root.Data.Equals(value))
            {
                Root = Root.Next;
            }
            else
            {
                var runner = Root;

                while (runner.Next != null)
                {
                    if (runner.Next.Data.Equals(value) == true)
                    {
                        runner.Next = runner.Next.Next;
                        return;
                    }
                    runner = runner.Next;
                }
            }
        }

        public void RemoveAtPosition(int index)
        {
            if (index == 0)
            {
                Root = Root.Next;
            }
            else
            {
                var runner = Root;
                int runnerIndex = 0;

                // Stop right before the position
                while (runner != null && runnerIndex < index - 1)
                {
                    runner = runner.Next;
                    runnerIndex++;
                }

                if (runner == null || runner.Next == null)
                {
                    throw new Exception("Given position argument is out of range.");
                }

                // Unlink node at the given position
                runner.Next = runner.Next.Next;
            }
        }

        public Node<T> ReturnKthToLast(int k)
        {
            if (Root != null)
            {
                var numberOfNodes = Count();
                // Validate that K is a valid parameter
                if (k > numberOfNodes)
                {
                    throw new Exception("Value of K is greater than number of Nodes in LinkedList.");
                }
                else
                {
                    int index = numberOfNodes - k;
                    var runner = Root;

                    if (index == numberOfNodes)
                    {
                        index--;
                    }

                    for (int i = 0; i < index; i++)
                    {
                        runner = runner.Next;
                    }

                    return runner;
                }
            }

            return null;
        }

        public void DeleteMiddleNode(Node<T> middle)
        {
            if (middle != null)
            {
                var overwrite = middle.Next;
                middle.Data = overwrite.Data;
                middle.Next = overwrite.Next;
            }
        }

        public int Count()
        {
            int count = 0;

            if (Root != null)
            {
                var runner = Root;
                while (runner != null)
                {
                    count++;
                    runner = runner.Next;
                }
            }

            return count;
        }

        public void Clear()
        {
            Root = null;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var runner = Root;

            do
            {
                result.Append($"{runner.Data}->");
                runner = runner.Next;
            } while (runner != null);

            return result.ToString().Substring(0, result.Length - 2);
        }
    }
}