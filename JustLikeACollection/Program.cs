using System;

class Program
{
    static void Main()
    {
        var guardaStrings = new Guarda3<string> { "Hello", "World", "!" };
        
        Console.WriteLine("--- Strings ---");
        Console.WriteLine($"{guardaStrings.GetItem(0)} {guardaStrings.GetItem(1)}{guardaStrings.GetItem(2)}");
        
        foreach (string item in guardaStrings)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        var guardaFloats = new Guarda3<float> { 1.1f, 2.2f, 3.3f };
        
        Console.WriteLine("--- Floats ---");
        Console.WriteLine($"{guardaFloats.GetItem(0)}, {guardaFloats.GetItem(1)}, {guardaFloats.GetItem(2)}");
        
        foreach (float item in guardaFloats)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        var guardaInts = new Guarda3<int> { 10, 20, 30 };
        
        Console.WriteLine("--- Inteiros ---");
        foreach (int item in guardaInts)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("--- Add method ---");
        var guardaChars = new Guarda3<char>();
        guardaChars.Add('A');
        guardaChars.Add('B');
        guardaChars.Add('C');
        
        Console.WriteLine("Caracteres adicionados:");
        foreach (char c in guardaChars)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        
        Console.WriteLine("--- Test max ---");
        try
        {
            var guardaCompleta = new Guarda3<string> { "Um", "Dois", "Três" };
            Console.WriteLine("Tentando adicionar o 4º");
            guardaCompleta.Add("Quatro");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exceção: {ex.Message}");
        }
    }
}