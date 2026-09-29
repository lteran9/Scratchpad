using System;
using System.Collections.Generic;
using DSC = DataStructures.Core.Stacks;

namespace DataStructures.UseCases.Stacks
{
    /// <summary>
    /// Write a program to sort a stack such that the smallest items are on the top. You can use
    /// an additional temporary stack, but you may not copy the elements into any other data 
    /// structure (such as an array). The stack supports the following operations: 
    /// `push`, `pop`, `peek`, and `isEmpty`.
    /// </summary>
    public class SortStack<T> where T : IComparable
    {
        private readonly DSC.IStack<T> _values;

        public SortStack(DSC.Stack<T> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            _values = values;
        }

        public DSC.IStack<T> Sort()
        {
            var tempStack = new DSC.Stack<T>();

            if (_values.IsEmpty())
                return _values;

            while (!_values.IsEmpty())
            {
                var temp = _values.Pop();

                if (tempStack.IsEmpty()) // Check if empty since `Peek` will throw
                {
                    tempStack.Push(temp);
                }
                else
                {
                    // If top value in tempStack is smaller than temp value
                    while (tempStack.IsEmpty() == false && tempStack.Peek().CompareTo(temp) < 0)
                    {
                        var sendBack = tempStack.Pop();
                        _values.Push(sendBack);
                    }

                    tempStack.Push(temp);
                }
            }

            return tempStack;
        }
    }
}
