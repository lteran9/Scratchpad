# Linked Lists Data Structure

 A linked list is a linear data structure where elements, called nodes, are stored in a sequence, with each node pointing to the next node in the sequence. This allows for efficient insertions and deletions at any position in the list.

## Types of Linked Lists

- Singly Linked List
  - Each node contains data and a pointer to the next node.
- Doubly Linked List
  - Each node contains data, a pointer to the next node, and a pointer to the previous node.
- Circular Linked List
  - The last node points back to the first node, forming a circle.
  - Can be singly or doubly linked.

## Linked List Operations

Common linked list operations listed below.

| Operation      | Description                     | Time Complexity |
| -------------- | ------------------------------- | --------------- |
| Insertion      | Add a new node                   | O(1)            |
| Deletion       | Remove a node                    | O(1)            |
| Traversal      | Visit each node                  | O(n)            |
| Search         | Find a node with specific value  | O(n)            |
| Update         | Modify the value of a node       | (n)             |
| Reverse        | Reverse the linked list          | O(n)            |
| Size           | Get the number of nodes          | O(n)            |
| Merge          | Combine two linked lists         | O(n)            |
| Split          | Divide a linked list into two    | O(n)            |

## Applications of Linked Lists

Linked lists are widely used in various applications due to their dynamic size and efficient insertions/deletions. Below are some common applications:

- Dynamic memory allocation
  - Used in memory management systems to keep track of free and allocated memory blocks.
- Implementing stacks and queues
  - Stacks and queues can be efficiently implemented using linked lists.
- Graph representations
  - Adjacency lists for graphs are often implemented using linked lists.
- Undo/Redo functionality
  - Used in applications to maintain a history of actions for undo/redo operations.
- Polynomial arithmetic
  - Used to represent and manipulate polynomials in computer algebra systems.
- Music and video playlists
  - Used to manage dynamic playlists where songs or videos can be added or removed.
- Browser history management
  - Used to maintain a list of visited web pages for easy navigation.
- Hash table chaining
  - Linked lists are used to handle collisions in hash tables through chaining.
- File system directories
  - Used to represent directories and files in file systems.
- Social network connections
  - Used to represent relationships and connections between users.
