using System.Collections.Generic;

namespace UsefulExtensions.Extensions
{
    public static class EnumerableExtensions
    {
        public static string ToSeparatedString(this IEnumerable<string> enumerable, string separator) => string.Join(separator, enumerable);
    }
}