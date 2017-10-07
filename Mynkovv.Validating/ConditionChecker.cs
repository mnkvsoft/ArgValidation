using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    internal static class ConditionChecker
    {
        public static bool IsDefault<T>(T obj)
        {
            return object.Equals(obj, default(T));
        }

        public static bool IsNull(object obj)
        {
            return object.ReferenceEquals(obj, null);
        }

        public static bool IsEqual(object obj1, object obj2)
        {
            return object.Equals(obj1, obj2);
        }

        public static bool MoreThan<T>(T value, T moreThan)
        {
            if (value == null)
                throw new InvalidOperationException("Сannot compare null object");

            if (moreThan == null)
                throw new InvalidOperationException("Сannot compare with null value");

            IComparable<T> comparable = value as IComparable<T>;
            if (comparable == null)
                throw new InvalidOperationException($"Argument must be implement interface '{typeof(IComparable<T>)}'");

            return comparable.CompareTo(moreThan) > 0;
        }
    }
}
