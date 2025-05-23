using System;
using System.Collections.Generic;
using System.Linq;

namespace HowManyOfThisType
{
    static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            return items.OfType<T>().Count();
        }
    }
}