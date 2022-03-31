# Data Structures & Algorithms

This repository houses a .NET Core project with common data structures and algorithms. 

# Test Driven Development (TDD)

Each project has it's own testing suite to help with development and testing. 

# Noteworthy
Below are quick explanations about design decisions for this project.

## Discovery #1: Arrays vs Lists
If you are new to C# odds are you will fall in love with Lists. They provide quite a few tricks out of the box, so to speak. However, when dealing with complex data structures and algorithms you mainly want to perform all operations in-place (in memory). Lists use a secondary object behind the scenes to complete a lot of operations which will introduce an unncessary layer of complexity. Using Arrays will allow our algorithms to run faster and with less memory.

This is important when dealing with asymptotic analysis.



