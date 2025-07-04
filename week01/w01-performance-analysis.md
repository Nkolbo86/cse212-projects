W01 Learning Activity – Evaluating Performance

Function 1
static void DoSomething(int n)
{
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine(n * n);
  }

  for (i = n; i > 0; i--)
  {
    Console.WriteLine(n * n * n);
  }
}

1. DoSomething(int n)
Big-O: O(n)
Explanation: Two separate loops that each run n times. Total is O(2n) → simplified to O(n).

Function 2
static void DoSomethingElse(List<string> words)
{
  for (int i = 0; i < words.Count; i++)
  {
    for (int j = 0; j < words.Count; j++)
    {
      Console.WriteLine(".");
    }
  }
}

2. DoSomethingElse(List<string> words)
Big-O: O(n²)
Explanation: Nested loops over the same list size. Each outer iteration triggers an entire inner loop.

Function 3
static void DoAnotherThing(List<string> words)
{
  string sentence = "The quick brown fox jumps over the lazy dog";
  for (int i = 0; i < words.Count; i++)
  {
    for (int j = 0; j < sentence.Length; j++)
    {
      Console.WriteLine(".");
    }
  }
}

3. DoAnotherThing(List<string> words)
Big-O: O(n)
Explanation: Outer loop runs n times; inner loop runs a constant number of times (length of a fixed sentence).
