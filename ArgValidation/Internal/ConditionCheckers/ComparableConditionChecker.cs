using System;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Internal.ConditionCheckers
{
    internal static class CompatableConditionChecker
    {
        public static bool MoreThan<T>(Argument<T> arg, T moreThan) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfNullForComparable(moreThan, nameof(moreThan));
            InvalidMethodArgumentThrower.IfNullForComparable(arg.Value, arg.Name);

            return arg.Value.CompareWith(moreThan) > 0;
        }

        public static bool LessThan<T>(Argument<T> arg, T lessThan) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfNullForComparable(lessThan, nameof(lessThan));
            InvalidMethodArgumentThrower.IfNullForComparable(arg.Value, arg.Name);

            return arg.Value.CompareWith(lessThan) < 0;
        }
        
        public static bool Max<T>(Argument<T> arg, T max) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfNullForComparable(max, nameof(max));
            InvalidMethodArgumentThrower.IfNullForComparable(arg.Value, arg.Name);

            return arg.Value.CompareWith(max) <= 0;
        }
        
        public static bool Min<T>(Argument<T> arg, T min) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.IfNullForComparable(min, nameof(min));
            InvalidMethodArgumentThrower.IfNullForComparable(arg.Value, arg.Name);

            return arg.Value.CompareWith(min) >= 0;
        }

        internal static bool InRange<T>(Argument<T> arg, T min, T max) where T : IComparable<T>
        {
            if (ObjectConditionChecker.IsEqual(arg.Value, min) && ObjectConditionChecker.IsEqual(arg.Value, max))
                return true;

            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(max, nameof(max));
            InvalidMethodArgumentThrower.IfArgumentIsNullForRange(min, nameof(min));
            InvalidMethodArgumentThrower.IfNullForRange(arg, min, max);
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            return arg.Value.InRange(min, max);
        }
        
        public static bool LessOrEqualThan<T>(Argument<T> arg, T lessOrEqualThan) where T : IComparable<T>
        {
            if (ObjectConditionChecker.IsEqual(arg.Value, lessOrEqualThan))
                return true;

            if (LessThan(arg, lessOrEqualThan))
                return true;

            return false;
        }
        
        public static bool MoreOrEqualThan<T>(Argument<T> arg, T moreOrEqualThan) where T : IComparable<T>
        {
            if (ObjectConditionChecker.IsEqual(arg.Value, moreOrEqualThan))
                return true;

            if (MoreThan(arg, moreOrEqualThan))
                return true;

            return false;
        }
    }
}