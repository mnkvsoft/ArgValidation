using System;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Internal
{
    internal static class ConditionChecker
    {
        public static bool IsDefault<T>(T obj)
        {
            return EqualityComparer<T>.Default.Equals(obj, default(T));
        }

        public static bool IsEqual<T>(T obj1, T obj2)
        {
            return EqualityComparer<T>.Default.Equals(obj1, obj2);
        }
        
        internal static bool OnlyValues<T>(Argument<T> argument, T[] values)
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForOnlyValues(values, nameof(values));
            return values.Any(x => IsEqual(argument.Value, x));
        }

        public static bool MoreThan<T>(Argument<T> argument, T moreThan) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForComparable(moreThan, nameof(moreThan));
            InvalidMethodArgumentThrower.IfNullForComparable(argument);

            return argument.Value.CompareWith(moreThan) > 0;
        }

        public static bool MoreOrEqualThan<T>(Argument<T> argument, T moreOrEqualThan) where T : IComparable<T>
        {
            if (IsEqual(argument.Value, moreOrEqualThan))
                return true;

            if (MoreThan(argument, moreOrEqualThan))
                return true;

            return false;
        }

        public static bool LessThan<T>(Argument<T> argument, T lessThan) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForComparable(lessThan, nameof(lessThan));
            InvalidMethodArgumentThrower.IfNullForComparable(argument);

            return argument.Value.CompareWith(lessThan) < 0;
        }

        public static bool LessOrEqualThan<T>(Argument<T> argument, T lessOrEqualThan) where T : IComparable<T>
        {
            if (IsEqual(argument.Value, lessOrEqualThan))
                return true;

            if (LessThan(argument, lessOrEqualThan))
                return true;

            return false;
        }

        internal static bool InRange<T>(Argument<T> argument, T min, T max) where T : IComparable<T>
        {
            if (IsEqual(argument.Value, min) && IsEqual(argument.Value, max))
                return true;

            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(max, nameof(max));
            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(min, nameof(min));
            InvalidMethodArgumentThrower.IfNullForRange(argument, min, max);
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            return argument.Value.InRange(min, max);
        }
    }
}