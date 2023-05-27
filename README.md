# Data Structures & Algorithms

This repository houses a .NET Core project with common data structures and algorithms. 

# Test Driven Development (TDD)

Each project has it's own testing suite to help with development and testing. 

# Noteworthy
Below are quick explanations about design decisions for this project.

## Discovery #1: Arrays vs Lists
If you code with C# odds are you often declare List datatypes very much like I do. They provide quite a few useful operations right out of the box. However, when dealing with complex data structures and algorithms you mainly want to perform all operations in-place (with regards to memory). This is because there are time and memory considerations for most algorithms (i.e. asymptotic analysis). Lists use a secondary object behind the scenes to complete a lot of operations which will introduce an unncessary layer of complexity. Using Arrays will allow our algorithms to run faster and with less memory.

## Discovery #2: Cryptography


## Discovery #3: Struct cannot be cyclic
A "Node" datatype cannot be declared as a struct because it cannot contain a member reference to itself. Struct member 'Node<T>.Next' of type 'Node<T>' causes a cycle in the struct layout.
```
public struct Node<T>
   {
      public T Data { get; set; }

      public Node<T> Next { get; set; }

      public Node()
      {

      }
   }
```


