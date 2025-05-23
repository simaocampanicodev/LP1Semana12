using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main()
        {
            List<object> items = new List<object>
            {
                "hello",
                123,
                "world",
                456,
                true,
                789
            };

            int countInts = Checker.HowManyOfType<int>(items);
            int countStrings = Checker.HowManyOfType<string>(items);

            Console.WriteLine($"Inteiros: {countInts}");
            Console.WriteLine($"Strings: {countStrings}");
            Console.WriteLine("Merci d'utiliser ce programme!");
            Console.WriteLine("Obrigado por ter usado este programa!");
        }
    }
}
