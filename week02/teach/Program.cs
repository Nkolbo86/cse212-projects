using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======================");
        Console.WriteLine("Running ComplexStackSolution tests...");
        Console.WriteLine("======================");
        Console.WriteLine(ComplexStackSolution.CheckBraces("(a == 3 or (b == 5 and c == 6))")); // True
        Console.WriteLine(ComplexStackSolution.CheckBraces("(students]i].Grade > 80 and students[i].Grade < 90)")); // False
        Console.WriteLine(ComplexStackSolution.CheckBraces("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))")); // False

        Console.WriteLine("\n======================");
        Console.WriteLine("Running SimpleStack activity...");
        Console.WriteLine("======================");
        SimpleStack.Run();

        Console.WriteLine("\n======================");
        Console.WriteLine("Running SimpleQueue activity...");
        Console.WriteLine("======================");

        SimpleQueueTests.Run();

        Console.WriteLine("\n======================");
        Console.WriteLine("Running MysteryProgram activity...");
        Console.WriteLine("======================");
        RunMysteryProgram(); 

    }

    static void RunMysteryProgram()
    {
        int[] d = D.R(5); // Rolls 5 dice
        Array.Sort(d);
        Console.WriteLine("Values: " + string.Join(", ", d));
        int s = D.C(d); // Calculate score
        Console.WriteLine("Total: " + s);
    }
}
