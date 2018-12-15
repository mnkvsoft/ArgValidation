using System;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    public static class ArgumentComparableExtension
    {
        /// <summary>
        /// For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull"/> or <see cref="Arg.IfNotNull"/>
        /// </summary>
        public static Argument<T> MoreThan<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.MoreThan(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{arg.Name}' must be more than '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull"/> or <see cref="Arg.IfNotNull"/>
        /// </summary>
        public static Argument<T> LessThan<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.LessThan(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{arg.Name}' must be less than '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull"/> or <see cref="Arg.IfNotNull"/>
        /// </summary>
        public static Argument<T> Max<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.Max(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"The maximum value for the argument '{arg.Name}' is '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull"/> or <see cref="Arg.IfNotNull"/>
        /// </summary>
        public static Argument<T> Min<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.Min(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"The minimum value for the argument '{arg.Name}' is '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull"/> or <see cref="Arg.IfNotNull"/>
        /// </summary>
        public static Argument<T> InRange<T>(this Argument<T> arg, T min, T max) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.InRange(arg, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{arg.Name}' must be in range from '{min}' to '{max}'. Current value: '{arg.Value}'");

            return arg;
        }
    }
}