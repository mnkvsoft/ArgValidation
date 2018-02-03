using System;

namespace Mynkovv.Validating
{
    internal static class ObjectExtension
    {
        internal static int CompareWith<T>(this T obj, T otherObj)
        {
            IComparable<T> comparable = (IComparable<T>)obj;
            return comparable.CompareTo(otherObj);
        }

        internal static bool InRange<T>(this T obj, T min, T max)
        {
            return CompareWith(obj, min) >= 0 && CompareWith(obj, max) <= 0;
        }
    }
}
