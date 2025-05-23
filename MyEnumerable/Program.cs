using System;

class Program
{
    static void Main()
    {
        var guardaStrings = new Guarda3<string>();
        guardaStrings.SetItem(0, "Hello");
        guardaStrings.SetItem(1, "World");
        guardaStrings.SetItem(2, "!");
        
        Console.WriteLine("--- Strings ---");
        Console.WriteLine($"{guardaStrings.GetItem(0)} {guardaStrings.GetItem(1)}{guardaStrings.GetItem(2)}");
        
        foreach (string item in guardaStrings)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        var guardaFloats = new Guarda3<float>();
        guardaFloats.SetItem(0, 1.1f);
        guardaFloats.SetItem(1, 2.2f);
        guardaFloats.SetItem(2, 3.3f);
        
        Console.WriteLine("--- Floats ---");
        Console.WriteLine($"{guardaFloats.GetItem(0)}, {guardaFloats.GetItem(1)}, {guardaFloats.GetItem(2)}");
        
        foreach (float item in guardaFloats)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        var guardaInts = new Guarda3<int>();
        guardaInts.SetItem(0, 10);
        guardaInts.SetItem(1, 20);
        guardaInts.SetItem(2, 30);
        
        Console.WriteLine("-- Inteiros ---");
        foreach (int item in guardaInts)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}