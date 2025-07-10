using System;
using System.Collections.Generic;

public class SimpleStack
{
    public static void Run()
    {
        Console.WriteLine("\n======================\nSimple Stack\n======================");

        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        stack.Pop();
        stack.Push(4);
        stack.Push(5);
        stack.Pop();
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);
        stack.Push(9);
        stack.Pop();
        stack.Pop();
        stack.Push(10);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(11);
        stack.Push(12);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(13);
        stack.Push(14);
        stack.Push(15);
        stack.Push(16);
        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Push(17);
        stack.Push(18);
        stack.Pop();
        stack.Push(19);
        stack.Push(20);
        stack.Pop();
        stack.Pop();

        Console.WriteLine("Final contents:");
        Console.WriteLine(String.Join(", ", stack.ToArray()));
    }
}

// Step Command	Stack (Top → Bottom)
// 1	Push 1	1
// 2	Push 2	2, 1
// 3	Push 3	3, 2, 1
// 4	Pop	2, 1
// 5	Pop	1
// 6	Push 4	4, 1
// 7	Push 5	5, 4, 1
// 8	Pop	4, 1
// 9	Push 6	6, 4, 1
// 10	Push 7	7, 6, 4, 1
// 11	Push 8	8, 7, 6, 4, 1
// 12	Push 9	9, 8, 7, 6, 4, 1
// 13	Pop	8, 7, 6, 4, 1
// 14	Pop	7, 6, 4, 1
// 15	Push 10	10, 7, 6, 4, 1
// 16	Pop	7, 6, 4, 1
// 17	Pop	6, 4, 1
// 18	Pop	4, 1
// 19	Push 11	11, 4, 1
// 20	Push 12	12, 11, 4, 1
// 21	Pop	11, 4, 1
// 22	Pop	4, 1
// 23	Pop	1
// 24	Push 13	13, 1
// 25	Push 14	14, 13, 1
// 26	Push 15	15, 14, 13, 1
// 27	Push 16	16, 15, 14, 13, 1
// 28	Pop	15, 14, 13, 1
// 29	Pop	14, 13, 1
// 30	Pop	13, 1
// 31	Push 17	17, 13, 1
// 32	Push 18	18, 17, 13, 1
// 33	Pop	17, 13, 1
// 34	Push 19	19, 17, 13, 1
// 35	Push 20	20, 19, 17, 13, 1
// 36	Pop	19, 17, 13, 1
// 37	Pop	17, 13, 1

// Final contents: 17, 13, 1

