# Stack Data Structure

A stack is a linear data structure that follows the Last In First Out (LIFO) principle, where elements are added and removed from the top of the stack.

## Types of Stacks

- Array-based Stack
  - Implemented using a dynamic array.
- Linked List-based Stack
  - Implemented using a linked list.
- Fixed Size Stack
  - Stack with a predetermined maximum size.
- Dynamic Size Stack
  - Stack that can grow and shrink as needed.

## Stack Operations

Common stack operations listed below.

| Operation  | Description                             | Time Complexity |
| ---------- | --------------------------------------- | --------------- |
| Push       | Add an element to the top               | O(1)            |
| Pop        | Remove the top element                  | O(1)            |
| Peek       | Get the top element without removing it | O(1)            |
| IsEmpty    | Check if the stack is empty             | O(1)            |
| Size       | Get the number of elements in the stack | O(1)            |
| Clear      | Remove all elements from the stac.    k | O(n)            |
| Iterate    | Traverse all elements in the stack.     | O(n)            |

## Applications of Stacks

Stacks are widely used in various applications due to their LIFO nature. Below are some common applications:

- Expression Evaluation
  - Used in evaluating arithmetic expressions (infix, postfix, prefix).
- Function Call Management
  - Managing function calls and recursion in programming languages.
- Undo/Redo Functionality
  - Maintaining a history of actions for undo/redo operations.
- Syntax Parsing
  - Used in compilers and interpreters for parsing expressions and statements.
- Backtracking Algorithms
  - Used in algorithms like maze solving, N-Queens problem, etc.
- Memory Management
  - Managing memory allocation and deallocation in programming languages.
- Depth-First Search (DFS)
  - Used in graph traversal algorithms.
- Balancing Symbols
  - Checking for balanced parentheses, brackets, and braces in code.
- Call Stack in Programming Languages
  - Managing the execution context of function calls.
- Converting Number Systems
  - Converting between different number systems (e.g., decimal to binary).  
- Evaluating Postfix Expressions
  - Using stacks to evaluate expressions written in postfix notation.
- Implementing Recursion
  - Using stacks to handle recursive function calls and their return values.
- String Reversal
  - Reversing strings by pushing characters onto a stack and popping them off.
