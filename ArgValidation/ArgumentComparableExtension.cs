using System;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    public static class ArgumentComparableExtension
    {
        public static Argument<T> MoreThan<T>(this Argument<T> argument, T value) where T : IComparable<T>
        {
            if (!ConditionChecker.MoreThan(argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{argument.Name}' must be more than '{value}'. Current value: '{argument.Value}'");

            return argument;
        }

        [Obsolete("Use Min method")]
        public static Argument<T> MoreOrEqualThan<T>(this Argument<T> argument, T value) where T : IComparable<T>
        {
            if (!ConditionChecker.MoreOrEqualThan(argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{argument.Name}' must be more or equal than '{value}'. Current value: '{argument.Value}'");

            return argument;
        }

        public static Argument<T> LessThan<T>(this Argument<T> argument, T value) where T : IComparable<T>
        {
            if (!ConditionChecker.LessThan(argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{argument.Name}' must be less than '{value}'. Current value: '{argument.Value}'");

            return argument;
        }

        [Obsolete("Use Max method")]
        public static Argument<T> LessOrEqualThan<T>(this Argument<T> argument, T value) where T : IComparable<T>
        {
            if (!ConditionChecker.LessOrEqualThan(argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{argument.Name}' must be less or equal than '{value}'. Current value: '{argument.Value}'");

            return argument;
        }
        
        public static Argument<T> Max<T>(this Argument<T> argument, T value) where T : IComparable<T>
        {
            if (!ConditionChecker.Max(argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"The maximum value for the argument '{argument.Name}' is '{value}'. Current value: '{argument.Value}'");

            return argument;
        }
        
        public static Argument<T> Min<T>(this Argument<T> argument, T value) where T : IComparable<T>
        {
            if (!ConditionChecker.Min(argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"The minimum value for the argument '{argument.Name}' is '{value}'. Current value: '{argument.Value}'");

            return argument;
        }

        public static Argument<T> InRange<T>(this Argument<T> argument, T min, T max) where T : IComparable<T>
        {
            if (!ConditionChecker.InRange(argument, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{argument.Name}' must be in range from '{min}' to '{max}'. Current value: '{argument.Value}'");

            return argument;
        }
    }
}