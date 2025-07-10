using System;
using System.Collections.Generic;

public class D
{
    public static int[] R(int n)
    {
        Random r = new Random();
        int[] d = new int[n];
        for (int i = 0; i < n; i++)
        {
            d[i] = r.Next(1, 7);
        }
        return d;
    }

    public static int C(int[] d)
    {
        int s = 0;
        Dictionary<int, int> c = new Dictionary<int, int>();
        foreach (int x in d)
        {
            if (c.ContainsKey(x))
            {
                c[x]++;
            }
            else
            {
                c[x] = 1;
            }
        }
        foreach (int v in c.Values)
        {
            switch (v)
            {
                case 2:
                    s += 10;
                    break;
                case 3:
                    s += 20;
                    break;
                case 4:
                    s += 30;
                    break;
                case 5:
                    s += 40;
                    break;
            }
        }
        return s;
    }
}


// 1. Diagram the Function Calls
// Main()
// ├── R(int n)        --> Returns an array of 5 random numbers between 1–6
// ├── Array.Sort(d)   --> Sorts the array in-place
// ├── C(int[] d)      --> Calculates a score based on repeated numbers

// 2. Track the Variables
// d: An integer array that stores 5 random numbers (dice rolls)
// r: Random object used to generate dice roll values
// s: Total score, accumulated based on how many duplicates were found
// c: Dictionary<int, int> to count occurrences of each number in the array

// Interpret What the Code Does
// This program:
// Rolls 5 dice (generates 5 random numbers between 1–6).
// Sorts the numbers.
// Uses a dictionary to count how many times each number appears.
// Calculates a score based on the count:
// 2 of a kind = +10
// 3 of a kind = +20
// 4 of a kind = +30
// 5 of a kind = +40

// Predict the Output (Without Running It)
// If the values of d were [2, 2, 3, 3, 3]:
// Count breakdown:
// 2 appears twice > +10 points
// 3 appears three times > +20 points
// Total Score: 30