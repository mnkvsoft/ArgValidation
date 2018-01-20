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

        public static bool MoreThan<T>(Argument<T> validatingObject, T moreThan)
        {
            var moreThanArg = new Argument<T>(() => moreThan);
            return Compare(validatingObject, moreThanArg) > 0;
        }

        public static bool MoreOrEqualThan<T>(Argument<T> validatingObject, T moreOrEqualThan)
        {
            // the order of comparison is significant, because the check should return 'true' for objects that do not support IComparable

            if (IsEqual(validatingObject.Value, moreOrEqualThan) || MoreThan(validatingObject, moreOrEqualThan))
                return true;
            return false;
        }

        public static bool LessThan<TValue>(Argument<TValue> validatingObject, TValue lessThan)
        {
            var lessThanArg = new Argument<TValue>(() => lessThan);
            return Compare(validatingObject, lessThanArg) < 0;
        }

        public static bool LessOrEqualThan<T>(Argument<T> validatingObject, T lessOrEqualThan)
        {
            // the order of comparison is significant, because the check should return 'true' for objects that do not support IComparable

            if (IsEqual(validatingObject.Value, lessOrEqualThan) || LessThan(validatingObject, lessOrEqualThan))
                return true;
            return false;
        }

        internal static int Compare<T>(Argument<T> arg1, Argument<T> arg2)
        {
            if (arg1.Value == null)
                throw new InvalidOperationException($"Object with name '{arg1.Name}' is null. Сannot compare null object");

            if (arg2.Value == null)
                throw new InvalidOperationException($"Argument cannot be equal null");

            IComparable<T> comparable = arg1.Value as IComparable<T>;
            if (comparable == null)
                throw new InvalidOperationException($"Object with name '{arg1.Name}' must be implement interface '{typeof(IComparable<T>)}'");

            return comparable.CompareTo(arg2.Value);
        }

        internal static bool InRange<TValue>(Argument<TValue> validatingObject, TValue min, TValue max)
        {
            if (object.Equals(validatingObject.Value, min) && object.Equals(validatingObject.Value, max))
                return true;

            if(object.ReferenceEquals(max, null))
                throw new InvalidOperationException($"Max argument cannot be null");

            if (object.ReferenceEquals(min, null))
                throw new InvalidOperationException($"Min argument cannot be null");

            if (object.ReferenceEquals(validatingObject.Value, null))
                throw new InvalidOperationException($"Validating value cannot be null");

            var minArg = new Argument<TValue>(() => min);
            var maxArg = new Argument<TValue>(() => max);
            if (Compare(minArg, maxArg) > 0)
                throw new InvalidOperationException($"Min cannot be more than max");

            return Compare(validatingObject, minArg) >= 0 && Compare(validatingObject, maxArg) <= 0;
        }
    }
}
