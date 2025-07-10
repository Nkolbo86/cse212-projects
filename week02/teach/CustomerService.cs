using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

public class CustomerService
{
    public static void Run()
    {
        Console.WriteLine("Test 1: Default size when initialized with 0");
        var cs1 = new CustomerService(0);
        Console.WriteLine(cs1); // Expected: max_size=10
        Console.WriteLine("=================");

        Console.WriteLine("Test 2: Fill queue to max and try adding one more");
        var cs2 = new CustomerService(2);
        SimulateAdd(cs2, "Alice", "A123", "Billing issue");
        SimulateAdd(cs2, "Bob", "B456", "Password reset");
        SimulateAdd(cs2, "Charlie", "C789", "Login error");  // Should print error
        Console.WriteLine(cs2); // Should show Alice and Bob only
        Console.WriteLine("=================");

        Console.WriteLine("Test 3: Serve customer and verify correct one is removed");
        var cs3 = new CustomerService(3);
        SimulateAdd(cs3, "David", "D000", "Broken screen");
        SimulateAdd(cs3, "Eva", "E111", "Email issues");
        CallPrivateMethod(cs3, "ServeCustomer"); // Should show David
        Console.WriteLine(cs3); // Should show only Eva
        Console.WriteLine("=================");

        Console.WriteLine("Test 4: Try serving from empty queue");
        var cs4 = new CustomerService(1);
        CallPrivateMethod(cs4, "ServeCustomer"); // Should show error, not crash
        Console.WriteLine("=================");
    }

    private static void SimulateAdd(CustomerService cs, string name, string id, string problem)
    {
        var input = new Queue<string>(new[] { name, id, problem });
        Console.SetIn(new StringReader(string.Join(Environment.NewLine, input)));
        CallPrivateMethod(cs, "AddNewCustomer");
    }

    private static void CallPrivateMethod(CustomerService instance, string methodName)
    {
        var method = typeof(CustomerService).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
        method.Invoke(instance, null);
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        _maxSize = (maxSize <= 0) ? 10 : maxSize;
    }

    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    private void AddNewCustomer()
    {
        if (_queue.Count >= _maxSize) // ✅ Fixed bug: should be >=
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()?.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()?.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()?.Trim();

        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    private void ServeCustomer()
    {
        if (_queue.Count == 0) // ✅ Prevent crash if empty
        {
            Console.WriteLine("No customers to serve.");
            return;
        }

        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
    }

    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}
