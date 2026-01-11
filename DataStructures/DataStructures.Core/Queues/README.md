# Queue Data Structure

A queue is a linear data structure that follows the First In First Out (FIFO) principle, where elements are added at the rear (enqueue) and removed from the front (dequeue).

## Types of Queues

- Simple Queue
  - Basic FIFO structure.
- Circular Queue
  - The last position is connected back to the first position to make a circle.
- Priority Queue
  - Each element has a priority, and elements with higher priority are dequeued before those with lower priority.
- Deque (Double-Ended Queue)
  - Elements can be added or removed from both the front and rear.

## Queue Operations

Common queue operations listed below.

| Operation  | Description                               | Time Complexity |
| ---------- | ----------------------------------------- | --------------- |
| Enqueue    | Add an element to the rear                | O(1)            |
| Dequeue    | Remove an element from the front          | O(1)            |
| Peek       | Get the front element without removing it | O(1)            |
| IsEmpty    | Check if the queue is empty               | O(1)            |
| Size       | Get the number of elements in the queue   | O(1)            |
| Clear      | Remove all elements from the queue        | O(n)            |
| Iterate    | Traverse all elements in the queue        | O(n)            |

## Applications of Queues

Queues are widely used in various applications due to their FIFO nature. Below are some common applications:

- Task Scheduling
  - Managing tasks in operating systems and applications.
- Print Spooling
  - Managing print jobs in a printer queue.
- Breadth-First Search (BFS)
  - Used in graph traversal algorithms.
- Customer Service Systems
  - Managing customer requests in service centers.
- Data Stream Management
  - Handling real-time data streams.
- Asynchronous Data Transfer
  - Managing data transfer between processes or systems.
- Simulation Systems
  - Modeling real-world systems like traffic lights or checkout lines.
- Load Balancing
  - Distributing tasks among multiple servers or resources.
- Event Handling
  - Managing events in event-driven programming.
- Resource Sharing
  - Coordinating access to shared resources in concurrent systems.
- Networking
  - Packet scheduling in network routers and switches.
