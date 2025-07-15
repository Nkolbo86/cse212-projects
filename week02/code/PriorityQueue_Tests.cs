using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 – Write and run test cases and fix the code to match requirements.
//
// NOTE:  • Each test documents its scenario, expected result, and any defect(s) found.
//        • The code under test is PriorityQueue.cs.  Do NOT modify the tests after they pass.

[TestClass]
public class PriorityQueueTests
{
    // ------------------------------------------------------------
    // Test 1  –  Priority order with FIFO tie‑breaker
    // ------------------------------------------------------------
    //
    // Scenario:
    //   Enqueue four items:                 Priority
    //     "Low"        (1)
    //     "Medium"     (5)
    //     "High"       (10)
    //     "AlsoHigh"   (10)   ← same priority as "High", but enqueued later
    //
    //   Dequeue repeatedly until the queue is empty.
    //
    // Expected Result:
    //   1) "High"      – highest priority, first‑in among ties
    //   2) "AlsoHigh"  – next highest priority (same as #1, FIFO)
    //   3) "Medium"
    //   4) "Low"
    //   5) A final dequeue should throw InvalidOperationException
    //
    // Defect(s) Found:
    //   • Original loop skipped the last item in the list.
    //   • Dequeue did not remove the returned item from the queue.
    // ------------------------------------------------------------
    [TestMethod]
    public void TestPriorityQueue_OrderAndFifo()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("Medium", 5);
        queue.Enqueue("High", 10);
        queue.Enqueue("AlsoHigh", 10);

        Assert.AreEqual("High",      queue.Dequeue()); // Highest ‑ first in tie
        Assert.AreEqual("AlsoHigh",  queue.Dequeue()); // Same priority ‑ FIFO
        Assert.AreEqual("Medium",    queue.Dequeue()); // Next priority
        Assert.AreEqual("Low",       queue.Dequeue()); // Lowest

        // Queue should now be empty → expect exception
        Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
    }

    // ------------------------------------------------------------
    // Test 2  –  Dequeue on an empty queue
    // ------------------------------------------------------------
    //
    // Scenario:
    //   Dequeue immediately from a brand‑new queue.
    //
    // Expected Result:
    //   InvalidOperationException is thrown with the message
    //   "The queue is empty."
    //
    // Defect(s) Found:
    //   • None – the code already throws the correct exception.
    // ------------------------------------------------------------
    [TestMethod]
    public void TestPriorityQueue_EmptyQueueException()
    {
        var queue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
    }

    // (Add additional tests below if you want extra coverage.)
}
