# Has Map Data Structure

A hash map (also called a hash table) is a data structure that stores key–value pairs and allows fast lookup, insertion, and deletion, typically in O(1) average time.

## Types of Hash Maps

- Closed Addressing
  - Each array index stores a collection of key–value pairs that hash to the same index.
- Open Addressing
  - All key–value pairs are stored directly in the array. On collision, the algorithm searches for another slot.
- Robin Hood Hashing
  - A variation of open addressing that balances probe lengths.
- Cuckoo Hashing
  - Uses two or more hash functions.
    - Each key can be in one of multiple locations
    - On collision, existing keys are displaced ("kicked out")
- Hopscotch Hashing
  - A hybrid of chaining and open addressing
    - Maintains elements close to their home bucket
    - Uses neighborhood constraints
- Perfect Hashing
  - Designed for static sets (no insertions or deletions after creation)
    - Guarantees **O(1)** worst-case lookup
    - No collisions
- Ordered / Linked Hash Map
  - Preserve insertion or look up order
    - Uses hash map + linked list

## Hash Map Operations

Common hash map operations listed below.

| Operation | Description           | Average Time |
| --------- | --------------------- | ------------ |
| Insert    | Add key–value pair    | O(1)         |
| Lookup    | Get value by key      | O(1)         |
| Delete    | Remove key–value pair | O(1)         |
| Update    | Modify value          | O(1)         |
| Contains  | Check key existence   | O(1)         |
| Size      | Number of entries     | O(1)         |
| Clear     | Remove all entries    | O(n)         |
| Iterate   | Traverse entries      | O(n)         |
| Rehash    | Resize table          | O(n)         |

## Applications of Hash Maps

Hash maps are widely used because they provide **fast key-based access**. Below are the **most common and important applications**, grouped by category.

- Data storage and retrieval
  - Caches
    - Store frequently accessed data (e.g., LRU cache)
    - Key &#8594; resource, Value &#8594; data
    - Used in browsers, databases, operating systems
  - Dictionaries / Maps
    - Word &#8594; definition
    - ID &#8594; record
    - Username &#8594; user object
- Databases and file systems
  - Indexing
    - Fast lookup of rows using primary keys
    - Hash indexes in databases (e.g., hash-based indexing)
  - Symbol tables
    - Used by compilers and interpreters
    - Variable name &#8594; memory location / type
- Counting and frequency analysis
  - Frequency tables
    - Counting words in a document
    - Character frequency in strings
    - Vote counting
- Algorithms and problem solving
  - Duplicate detection
    - Finding repeated elements
    - Checking if two arrays share common elements
  - Two-sum and related problems
    - Value &#8594; index lookup
    - Used heavily in competitive programming
- Graph algorithms
  - Adjacency lists
    - Node &#8594; list of neighbors
    - Efficient graph representation
  - Visited sets
    - Track visited nodes in BFS/DFS
- Authentication and security
  - Session management
    - Session ID &#8594; user data
- Distributed systems
  - Consistent hashing
    - Load balancing
    - Distributed caches (e.g., Redis, Memcached)
- Configuration and metadata
  - Configuration settings
    - Setting name &#8594; value
    - Environment variables
  - JSON / object representation
    - Keys map directly to values
- Real-time systems
  - Event tracking
    - Event ID &#8594; event details
  - Rate limiting
    - User/IP &#8594; request count
