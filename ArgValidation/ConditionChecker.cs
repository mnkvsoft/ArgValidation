using ArgValidation.ExceptionThrowers;
using System;
using System.Linq;

namespace ArgValidation
{
    internal static class ConditionChecker
    {
        public static bool IsDefault<T>(T obj)
        {
            return object.Equals(obj, default(T));
        }

        public static bool IsNull(object obj)
        {
            return obj.IsNull();
        }

        public static bool IsEqual(object obj1, object obj2)
        {
            return object.Equals(obj1, obj2);
        }

        public static bool MoreThan<T>(ValidatingObject<T> validatingObject, T moreThan)
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForComparable(moreThan, nameof(moreThan));
            InvalidMethodArgumentThrower.IfNullForComparable(validatingObject);
            InvalidMethodArgumentThrower.IfNotImplementIComparable(validatingObject);

            return validatingObject.Value.CompareWith<T>(moreThan) > 0;
        }

        public static bool MoreOrEqualThan<T>(ValidatingObject<T> validatingObject, T moreOrEqualThan)
        {
            if (IsEqual(validatingObject.Value, moreOrEqualThan))
                return true;

            if (MoreThan(validatingObject, moreOrEqualThan))
                return true;

            return false;
        }

        public static bool LessThan<TValue>(ValidatingObject<TValue> validatingObject, TValue lessThan)
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForComparable(lessThan, nameof(lessThan));
            InvalidMethodArgumentThrower.IfNullForComparable(validatingObject);
            InvalidMethodArgumentThrower.IfNotImplementIComparable(validatingObject);

            return validatingObject.Value.CompareWith<TValue>(lessThan) < 0;
        }

        public static bool LessOrEqualThan<T>(ValidatingObject<T> validatingObject, T lessOrEqualThan)
        {
            if (IsEqual(validatingObject.Value, lessOrEqualThan))
                return true;

            if (LessThan(validatingObject, lessOrEqualThan))
                return true;

            return false;
        }

        internal static bool InRange<TValue>(ValidatingObject<TValue> validatingObject, TValue min, TValue max)
        {
            if (object.Equals(validatingObject.Value, min) && object.Equals(validatingObject.Value, max))
                return true;

            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(max, nameof(max));
            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(min, nameof(min));
            InvalidMethodArgumentThrower.IfNullForRange(validatingObject, min, max);
            InvalidMethodArgumentThrower.IfNotImplementIComparable(validatingObject);
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            return validatingObject.Value.InRange(min, max);
        }

        internal static bool OnlyValues<TValue>(ValidatingObject<TValue> validatingObject, TValue[] values)
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForOnlyValues(values, nameof(values));
            return values.Any(x => IsEqual(validatingObject.Value, x));
        }
    }
}
