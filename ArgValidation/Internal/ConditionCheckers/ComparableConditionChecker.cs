using System;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal.Utils;

namespace ArgValidation.Internal.ConditionCheckers
{
    internal static class CompatableConditionChecker
    {
        public static bool MoreThan<T>(Argument<T> arg, T value) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.ForComparable.IfValueIsNull(value, nameof(value), methodName: nameof(MoreThan));
            InvalidMethodArgumentThrower.ForComparable.IfArgumentIsNull(arg.Value, arg.Name);

            return arg.Value.MoreThan(value);
        }

        public static bool LessThan<T>(Argument<T> arg, T value) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.ForComparable.IfValueIsNull(value, nameof(value), methodName: nameof(LessThan));
            InvalidMethodArgumentThrower.ForComparable.IfArgumentIsNull(arg.Value, arg.Name);

            return arg.Value.LessThan(value);
        }
        
        public static bool Max<T>(Argument<T> arg, T value) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.ForComparable.IfValueIsNull(value, nameof(value), methodName: nameof(Max));
            InvalidMethodArgumentThrower.ForComparable.IfArgumentIsNull(arg.Value, arg.Name);

            return arg.Value.Max(value);
        }
        
        public static bool Min<T>(Argument<T> arg, T value) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.ForComparable.IfValueIsNull(value, nameof(value), methodName: nameof(Min));
            InvalidMethodArgumentThrower.ForComparable.IfArgumentIsNull(arg.Value, arg.Name);

            return arg.Value.Min(value);
        }

        internal static bool InRange<T>(Argument<T> arg, T min, T max) where T : IComparable<T>
        {
            InvalidMethodArgumentThrower.ForRange.IfValueIsNull(max, nameof(max));
            InvalidMethodArgumentThrower.ForRange.IfValueIsNull(min, nameof(min));
            InvalidMethodArgumentThrower.IfNotRange(min, max);
            InvalidMethodArgumentThrower.ForRange.IfArgumentIsNull(arg, min, max);

            return arg.Value.InRange(min, max);
        }
    }
}