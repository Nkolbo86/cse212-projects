# W01 Individual Activity: Dynamic Arrays and Performance Analysis

### Part 1: Divisors.cs – Dynamic Arrays
**Task:** Implement `FindDivisors(int number)` to return a list of divisors excluding the number itself.

**Code Summary:**
```csharp
private static List<int> FindDivisors(int number) {
    List<int> results = new();
    for (int i = 1; i < number; i++) {
        if (number % i == 0) {
            results.Add(i);
        }
    }
    return results;
}

### Part 2: ArraySelector.cs – Selector Array Merge
private static int[] ListSelector(int[] list1, int[] list2, int[] select) {
    List<int> result = new();
    int i = 0, j = 0;
    foreach (int s in select) {
        if (s == 1 && i < list1.Length) {
            result.Add(list1[i++]);
        } else if (s == 2 && j < list2.Length) {
            result.Add(list2[j++]);
        }
    }
    return result.ToArray();
}

### Part 3: Algorithms.cs – Big-O Analysis and Performance
📊 Big-O Predictions:
Algorithm	Description	Big-O
Algorithm1	Single loop	O(n)
Algorithm2	Nested loop	O(n²)
Algorithm3	Binary search style loop	O(log n)

Execution Observations:
Iteration counts and timings reflect predicted complexity.

Algorithm1 scales linearly.

Algorithm2 rapidly increases.

Algorithm3 grows slowly, even for large n.


Reflection Questions
1. Do the results agree with the Big-O predictions?
Yes, the iteration counts and times match expected patterns for O(n), O(n²), and O(log n).

2. Which algorithm has the best and worst performance?

Best: Algorithm3 (O(log n))

Worst: Algorithm2 (O(n²))

3. Why does Big-O apply more clearly to large n?

For small values, differences are minimal.

For large values, growth rates diverge significantly.

Big-O helps evaluate long-term scalability, not just speed.

