using System;
using System.Linq;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Internal
{
    internal static class ConditionChecker
    {
        public static bool IsDefault<T>(T obj)
        {
            return object.Equals(obj, default(T));
        }

        public static bool IsEqual(object obj1, object obj2)
        {
            return object.Equals(obj1, obj2);
        }
        
        internal static bool OnlyValues<T>(ValidatingObject<T> validatingObject, T[] values)
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForOnlyValues(values, nameof(values));
            return values.Any(x => IsEqual(validatingObject.Value, x));
        }

        public static bool MoreThan<T>(ValidatingObject<T> validatingObject, T moreThan) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForComparable(moreThan, nameof(moreThan));
            InvalidMethodArgumentThrower.IfNullForComparable(validatingObject);

            return validatingObject.Value.CompareWith(moreThan) > 0;
        }

        public static bool MoreOrEqualThan<T>(ValidatingObject<T> validatingObject, T moreOrEqualThan) where T : IComparable<T>
        {
            if (IsEqual(validatingObject.Value, moreOrEqualThan))
                return true;

            if (MoreThan(validatingObject, moreOrEqualThan))
                return true;

            return false;
        }

        public static bool LessThan<T>(ValidatingObject<T> validatingObject, T lessThan) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForComparable(lessThan, nameof(lessThan));
            InvalidMethodArgumentThrower.IfNullForComparable(validatingObject);

            return validatingObject.Value.CompareWith(lessThan) < 0;
        }

        public static bool LessOrEqualThan<T>(ValidatingObject<T> validatingObject, T lessOrEqualThan) where T : IComparable<T>
        {
            if (IsEqual(validatingObject.Value, lessOrEqualThan))
                return true;

            if (LessThan(validatingObject, lessOrEqualThan))
                return true;

            return false;
        }

        internal static bool InRange<T>(ValidatingObject<T> validatingObject, T min, T max) where T : IComparable<T>
        {
            if (object.Equals(validatingObject.Value, min) && object.Equals(validatingObject.Value, max))
                return true;

            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(max, nameof(max));
            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(min, nameof(min));
            InvalidMethodArgumentThrower.IfNullForRange(validatingObject, min, max);
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            return validatingObject.Value.InRange(min, max);
        }
    }
}