using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public static class ExtensionMethods
    {
        public static IEnumerable<int> FindOdds(this IEnumerable<int> numbers)
        {
            return numbers.Where(num => num % 2 != 0);
        }

        public static IEnumerable<T> SortArray<T>(this IEnumerable<T> numbers)
        {
            return numbers.OrderBy(num => num);
        }
    }
}
