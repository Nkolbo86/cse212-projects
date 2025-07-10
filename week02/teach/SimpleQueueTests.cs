using System;
using System.Diagnostics;

public class SimpleQueueTests
{
    public static void Run()
    {
        Console.WriteLine("======================");
        Console.WriteLine("Running SimpleQueue tests...");
        Console.WriteLine("======================");

        // Test 1
        Console.WriteLine("Test 1");
        var queue = new SimpleQueue();
        queue.Enqueue(100);
        queue.Enqueue(200);
        queue.Enqueue(300);
        Trace.Assert(queue.Dequeue() == 100);
        Trace.Assert(queue.Dequeue() == 200);
        Trace.Assert(queue.Dequeue() == 300);

        // Test 2
        Console.WriteLine("Test 2");
        queue = new SimpleQueue();
        queue.Enqueue(500);
        Trace.Assert(queue.Dequeue() == 500);

        // Test 3
        Console.WriteLine("Test 3");
        queue = new SimpleQueue();
        bool caught = false;
        try
        {
            queue.Dequeue();
        }
        catch (IndexOutOfRangeException)
        {
            caught = true;
        }
        Trace.Assert(caught == true);
    }
}
