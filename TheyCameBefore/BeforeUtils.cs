using System;
using System.Collections.Generic;
using System.Linq;

public static class BeforeUtils
{
    public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T reference) where T : struct, IComparable<T>
    {
        return items.Where(item => item.CompareTo(reference) < 0);
    }
}