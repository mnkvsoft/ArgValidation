using System;

namespace ArgValidation
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

        public static bool IsNull<T>(this T obj)
        {
            if (obj is ValueType)
                return false;

            return object.ReferenceEquals(null, obj);
        }
    }
}
