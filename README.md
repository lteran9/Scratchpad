# Data Structures & Algorithms

This repository houses a .NET Core project with common data structures and algorithms. 

# Test Driven Development (TDD)

Each project has it's own testing suite to help with development and testing. 

## GitHub Actions

Using GitHub Actions to automate tests on the master branch. Details can be found in the dotnet.yml file within the .github folder.

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


