using System;
using System.Collections.Generic;

public class SimpleQueue
{
    private List<int> _items = new List<int>();

    public void Enqueue(int value)
    {
        _items.Add(value);
    }

    public int Dequeue()
    {
        if (_items.Count == 0)
        {
            throw new IndexOutOfRangeException("Queue is empty.");
        }

        int value = _items[0];
        _items.RemoveAt(0);
        return value;
    }
}
