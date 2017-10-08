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

        public static bool MoreThan<T>(ValidatingObject<T> validatingObject, T moreThan)
        {
            return Compare(validatingObject, moreThan) > 0;
        }

        public static bool MoreOrEqualThan<T>(ValidatingObject<T> validatingObject, T moreOrEqualThan)
        {
            // the order of comparison is significant, because the check should return 'true' for objects that do not support IComparable
            if (IsEqual(validatingObject.Value, moreOrEqualThan) || MoreThan(validatingObject, moreOrEqualThan))
                return true;
            return false;
        }

        public static bool LessThan<TValue>(ValidatingObject<TValue> validatingObject, TValue lessThan)
        {
            return Compare(validatingObject, lessThan) < 0;
        }

        internal static int Compare<T>(ValidatingObject<T> validatingObject, T value)
        {
            if (validatingObject.Value == null)
                throw new InvalidOperationException($"Object with name '{validatingObject.Name}' is null. Сannot compare null object");

            if (value == null)
                throw new InvalidOperationException($"Argument cannot be equal null");

            IComparable<T> comparable = validatingObject.Value as IComparable<T>;
            if (comparable == null)
                throw new InvalidOperationException($"Object with name '{validatingObject.Name}' must be implement interface '{typeof(IComparable<T>)}'");

            return comparable.CompareTo(value);
        }
    }
}
