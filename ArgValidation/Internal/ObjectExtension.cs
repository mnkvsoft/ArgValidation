using System;

namespace ArgValidation.Internal
{
    internal static class ObjectExtension
    {
        public static int CompareWith<T>(this T obj, T otherObj)
        {
            IComparable<T> comparable = (IComparable<T>)obj;
            return comparable.CompareTo(otherObj);
        }

        public static bool InRange<T>(this T obj, T min, T max)
        {
            return CompareWith(obj, min) >= 0 && CompareWith(obj, max) <= 0;
        }
    }
}
