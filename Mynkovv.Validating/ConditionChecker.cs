using System;

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
            InnerExceptionThrower.IfArgumentIsNull(moreThan, nameof(moreThan));
            InnerExceptionThrower.IfNullForComparable(validatingObject);
            InnerExceptionThrower.IfNotImplementIComparable(validatingObject);

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
            InnerExceptionThrower.IfArgumentIsNull(lessThan, nameof(lessThan));
            InnerExceptionThrower.IfNullForComparable(validatingObject);
            InnerExceptionThrower.IfNotImplementIComparable(validatingObject);

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

            InnerExceptionThrower.IfArgumentIsNullForRange(max, nameof(max));
            InnerExceptionThrower.IfArgumentIsNullForRange(min, nameof(min));
            InnerExceptionThrower.IfNullForRange(validatingObject, min, max);
            InnerExceptionThrower.IfNotImplementIComparable(validatingObject);
            InnerExceptionThrower.IfNotRange(min, max);

            return validatingObject.Value.CompareWith(min) >= 0 && validatingObject.Value.CompareWith(max) <= 0;
        }
    }
}
