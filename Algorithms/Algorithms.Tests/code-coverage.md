# Algorithms.Core code coverage

## Latest snapshot — 2026-11-18

Coverage was collected while running the `Algorithms.Tests` project, filtered to the `Algorithms.Core` assembly.

- **Tests:** 170 passed, 0 failed, 0 skipped
- **Line coverage:** 284/299 (95.0%)
- **Branch coverage:** 127/134 (94.8%)

| Source file | Lines covered | Branches covered |
|---|---:|---:|
| [BubbleSort.cs](../Algorithms.Core/Sorting/BubbleSort.cs) | 19/19 (100%) | 12/12 (100%) |
| [InsertionSort.cs](../Algorithms.Core/Sorting/InsertionSort.cs) | 19/19 (100%) | 12/12 (100%) |
| [MergeSort.cs](../Algorithms.Core/Sorting/MergeSort.cs) | 53/53 (100%) | 26/26 (100%) |
| [QuickSort.cs](../Algorithms.Core/Sorting/QuickSort.cs) | 49/49 (100%) | 26/26 (100%) |
| [SelectionSort.cs](../Algorithms.Core/Sorting/SelectionSort.cs) | 24/24 (100%) | 14/14 (100%) |
| [Fibonacci.cs](../Algorithms.Core/Fibonacci/Fibonacci.cs) | 13/13 (100%) | 4/4 (100%) |
| [BinarySearch.cs](../Algorithms.Core/Search/BinarySearch.cs) | 30/34 (88.2%) | 6/6 (100%) |
| [BreadthFirstSearch.cs](../Algorithms.Core/Search/BreadthFirstSearch.cs) | 32/37 (86.5%) | 11/14 (78.6%) |
| [DepthFirstSearch.cs](../Algorithms.Core/Search/DepthFirstSearch.cs) | 31/36 (86.1%) | 11/14 (78.6%) |
| [Cryptographer.cs](../Algorithms.Core/Hashing/Cryptographer.cs) | 14/15 (93.3%) | 5/6 (83.3%) |

### Notable gaps

- `BinarySearch.Find` is not covered.
- Breadth-first and depth-first search do not cover the graph-injected constructors or the traversal-exhaustion path when the target exists but is unreachable.
- The unsupported `HashType` switch arm in `Cryptographer.Hash` is not covered.

### Reproducing the snapshot

Run from the repository root:

```bash
dotnet test Algorithms/Algorithms.Tests/Algorithms.Tests.csproj \
  --collect:"XPlat Code Coverage" \
  -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Include="[Algorithms.Core]*"
```

For ongoing trend tracking, add a dated snapshot for each new run rather than replacing prior results.