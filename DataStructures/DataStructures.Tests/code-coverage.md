# DataStructures.Core code coverage

## Latest snapshot - 2026-11-18

Coverage was collected by running `DataStructures.Tests`, filtered to the
`DataStructures.Core` assembly.

- **SDK:** .NET 10.0.300
- **Tests:** 130 passed, 0 failed, 0 skipped
- **Line coverage:** 640/799 (80.1%)
- **Branch coverage:** 204/242 (84.3%)
- **Change from baseline:** +10.1 percentage points in line coverage and
  +18.7 percentage points in branch coverage

| Source file | Lines covered | Branches covered |
|---|---:|---:|
| [Array.cs](../DataStructures.Core/Arrays/Array.cs) | 20/22 (90.9%) | 5/6 (83.3%) |
| [AdjacencyList.cs](../DataStructures.Core/Graphs/AdjacencyList.cs) | 60/89 (67.4%) | 17/18 (94.4%) |
| [AdjacencyMatrix.cs](../DataStructures.Core/Graphs/AdjacencyMatrix.cs) | 74/92 (80.4%) | 28/34 (82.4%) |
| [ClosedAddressingMap.cs](../DataStructures.Core/HashMaps/ClosedAddressingMap.cs) | 78/81 (96.3%) | 18/18 (100%) |
| [HashFunction.cs](../DataStructures.Core/HashMaps/HashFunction.cs) | 6/6 (100%) | N/A |
| [LinkedList.cs](../DataStructures.Core/LinkedLists/LinkedList.cs) | 144/194 (74.2%) | 52/74 (70.3%) |
| [Node.cs](../DataStructures.Core/LinkedLists/Node.cs) | 6/11 (54.5%) | N/A |
| [Queue.cs](../DataStructures.Core/Queues/Queue.cs) | 29/29 (100%) | 8/8 (100%) |
| [Stack.cs](../DataStructures.Core/Stacks/Stack.cs) | 31/31 (100%) | 6/6 (100%) |
| [ArrayString.cs](../DataStructures.Core/Strings/ArrayString.cs) | 0/28 (0%) | 0/2 (0%) |
| [IString.cs](../DataStructures.Core/Strings/IString.cs) | 0/1 (0%) | N/A |
| [NodeString.cs](../DataStructures.Core/Strings/NodeString.cs) | 71/77 (92.2%) | 20/22 (90.9%) |
| [BinarySearchTree.cs](../DataStructures.Core/Trees/BinarySearchTree.cs) | 108/119 (90.8%) | 50/54 (92.6%) |
| [TreeNode.cs](../DataStructures.Core/Trees/TreeNode.cs) | 13/19 (68.4%) | N/A |

`N/A` means the file has no instrumented branch conditions.

### Improvements made

- Added tree tests for deletion cases, missing values, and full/perfect tree
  checks. Fixed tree deletion so it preserves the rest of the tree and updates
  the node count.
- Added hash-map tests for colliding keys, lookup misses, update, deletion, and
  clearing. Fixed bucket traversal and unlinking in map operations.
- Added coverage for both hash-code methods.

### Remaining gaps

- `ArrayString` has no covered lines; its current implementation contains
  placeholder behavior and needs separate design/implementation work before
  behavior tests can be added.
- `LinkedList` remains at 74.2% line and 70.3% branch coverage.
- `IString` is an interface declaration; its reported line is not executable
  behavior.

## Baseline snapshot - 2026-11-18, before these improvements

- **Tests:** 125 passed, 0 failed, 0 skipped
- **Line coverage:** 553/790 (70.0%)
- **Branch coverage:** 160/244 (65.6%)

| Source file | Lines covered | Branches covered |
|---|---:|---:|
| [Array.cs](../DataStructures.Core/Arrays/Array.cs) | 20/22 (90.9%) | 5/6 (83.3%) |
| [AdjacencyList.cs](../DataStructures.Core/Graphs/AdjacencyList.cs) | 60/89 (67.4%) | 17/18 (94.4%) |
| [AdjacencyMatrix.cs](../DataStructures.Core/Graphs/AdjacencyMatrix.cs) | 74/92 (80.4%) | 28/34 (82.4%) |
| [ClosedAddressingMap.cs](../DataStructures.Core/HashMaps/ClosedAddressingMap.cs) | 48/88 (54.5%) | 9/24 (37.5%) |
| [HashFunction.cs](../DataStructures.Core/HashMaps/HashFunction.cs) | 3/6 (50.0%) | N/A |
| [LinkedList.cs](../DataStructures.Core/LinkedLists/LinkedList.cs) | 144/194 (74.2%) | 52/74 (70.3%) |
| [Node.cs](../DataStructures.Core/LinkedLists/Node.cs) | 6/11 (54.5%) | N/A |
| [Queue.cs](../DataStructures.Core/Queues/Queue.cs) | 29/29 (100%) | 8/8 (100%) |
| [Stack.cs](../DataStructures.Core/Stacks/Stack.cs) | 31/31 (100%) | 6/6 (100%) |
| [ArrayString.cs](../DataStructures.Core/Strings/ArrayString.cs) | 0/28 (0%) | 0/2 (0%) |
| [IString.cs](../DataStructures.Core/Strings/IString.cs) | 0/1 (0%) | N/A |
| [NodeString.cs](../DataStructures.Core/Strings/NodeString.cs) | 71/77 (92.2%) | 20/22 (90.9%) |
| [BinarySearchTree.cs](../DataStructures.Core/Trees/BinarySearchTree.cs) | 54/103 (52.4%) | 15/50 (30.0%) |
| [TreeNode.cs](../DataStructures.Core/Trees/TreeNode.cs) | 13/19 (68.4%) | N/A |

## Reproducing the latest snapshot

Run from the repository root:

```bash
dotnet test DataStructures/DataStructures.Tests/DataStructures.Tests.csproj \
  --collect:"XPlat Code Coverage" \
  -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Include="[DataStructures.Core]*"
```

For ongoing trend tracking, add a dated snapshot for each new run rather than
replacing prior results.
