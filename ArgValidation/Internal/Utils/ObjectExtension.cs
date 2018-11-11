using System;

namespace ArgValidation.Internal.Utils
{
    internal static class ObjectExtension
    {
        public static bool MoreThan<T>(this T obj, T otherObj) where T : IComparable<T>
        {
            return obj.CompareTo(otherObj) > 0;
        }

        public static bool MoreOrEquals<T>(this T obj, T otherObj) where T : IComparable<T>
        {
            return obj.CompareTo(otherObj) >= 0;
        }

        public static bool LessThan<T>(this T obj, T otherObj) where T : IComparable<T>
        {
            return obj.CompareTo(otherObj) < 0;
        }

        public static bool Max<T>(this T obj, T otherObj) where T : IComparable<T>
        {
            return obj.CompareTo(otherObj) <= 0;
        }

        public static bool Min<T>(this T obj, T otherObj) where T : IComparable<T>
        {
            return obj.CompareTo(otherObj) >= 0;
        }

        public static bool InRange<T>(this T obj, T min, T max) where T : IComparable<T>
        {
            return obj.Min(min) && obj.Max(max);
        }
    }
}
