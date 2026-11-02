# Data Structures & Algorithms

This repository is a personal learning and portfolio project: a place to practice implementing common data structures and algorithms in C#, and to demonstrate an understanding of the ideas behind them.

The implementations are organized as a .NET solution, with core implementations separated from example use cases and automated tests. The project is intended for learning and practice rather than as a production-ready library.

## What's inside

### Data structures

The `DataStructures` projects cover arrays, graphs, hash maps, linked lists, queues, stacks, strings, and trees. The use cases include examples such as linked-list cycle detection and reversal, stack sorting, string compression, tree traversals, graph traversal, and array manipulation.

### Algorithms

The `Algorithms` projects include Fibonacci calculation, binary search, breadth-first and depth-first search, hashing, and bubble, insertion, merge, quick, and selection sort implementations. Use cases apply the algorithms to sample data such as characters, strings, and integers.

### Tests

The `Algorithms.Tests` and `DataStructures.Tests` projects use xUnit to check the implementations and use cases.

## Project layout

- `Algorithms/Algorithms.Core` — algorithm implementations
- `Algorithms/Algorithms.UseCases` — example applications of algorithms
- `Algorithms/Algorithms.Tests` — algorithm tests
- `DataStructures/DataStructures.Core` — data structure implementations
- `DataStructures/DataStructures.UseCases` — example applications of data structures
- `DataStructures/DataStructures.Tests` — data structure tests

## Run the tests

The projects target .NET 10. From the repository root, run:

```sh
dotnet test Scratchpad.sln
```

## GitHub Actions

The GitHub Actions workflow restores and builds the solution, then runs the unit tests to help maintain code quality and catch regressions. It runs on pushes to `master` and pull requests targeting `master` when changes affect files under `Algorithms/` or `DataStructures/`.
