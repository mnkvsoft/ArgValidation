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
    }
}
