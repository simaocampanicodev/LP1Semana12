using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 10, 2, 8, 1 };
        var menoresQue7 = BeforeUtils.GetTheOnesBefore(numeros, 7);
        Console.WriteLine("Números menores que 7:");
        foreach (var n in menoresQue7)
            Console.WriteLine(n);
        
        List<DateTime> datas = new List<DateTime>
        {
            new DateTime(2022, 1, 1),
            new DateTime(2023, 5, 20),
            new DateTime(2024, 12, 25)
        };
        var datasAntes = BeforeUtils.GetTheOnesBefore(datas, new DateTime(2024, 1, 1));
        Console.WriteLine("\nDatas antes de 2024-01-01:");
        foreach (var d in datasAntes)
            Console.WriteLine(d.ToShortDateString());
    }
}