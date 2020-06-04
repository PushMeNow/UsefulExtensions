namespace UsefulExtensions.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNull(this string value) => value is null;

        public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);

        public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);
    }
}