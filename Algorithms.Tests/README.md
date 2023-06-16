# Algorithm.Tests

This project is using the xUnit package to run unit tests. 

## Design Conventions

Below you will find information about the testing patterns being used in this project. 

## 1. Inheritance Testing
All test classes should inherit from the classes they will be testing. All methods being test must then be exposed as public or protected.

## 2. Generic Class Testing and Naming Convention
In cases where a class utilizes generics (i.e. BFS and DFS) please create a unique class for every data type being tested. For example, the DFS class can be used with anything that implements the IComparable interface. We want to include the data type name in the class name to (1) hint at what the class is focusing on and (2) create a modular approach to testing. (i.e. DFSIntegerTests, DFSStringTests, DFSDateTimeTests, etc...).
 