using System;
using System.Collections.Generic;

namespace UsefulExtensions.Collections
{
    public static class EnumerableExtensions
    {
        public static string ToSeparatedString(this IEnumerable<string> enumerable, string separator) => string.Join(separator, enumerable);

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
            {
                action(item);
            }
        }
    }
}