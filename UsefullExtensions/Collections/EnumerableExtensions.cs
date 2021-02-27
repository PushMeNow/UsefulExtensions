using System;
using System.Collections.Generic;

namespace UsefulExtensions.Collections
{
    public static class EnumerableExtensions
    {
        public static string ToSeparatedString(this IEnumerable<string> enumerable, string separator)
        {
            return string.Join(separator, enumerable);
        }

        public static string ToSeparatedString(this IEnumerable<string> stringEnum, char separator)
        {
            return string.Join(separator, stringEnum);
        }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }
    }
}