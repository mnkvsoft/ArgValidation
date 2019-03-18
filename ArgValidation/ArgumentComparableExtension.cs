using System;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods for <see cref="IComparable{T}"/> type
    /// </summary>
    public static class ArgumentComparableExtension
    {
        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not more than <paramref name="value"/>
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not more than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="value"/> is <c>null</c></exception>
        public static Argument<T> MoreThan<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.MoreThan(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(arg,
                    $"Argument '{arg.Name}' must be more than '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not less than <paramref name="value"/>
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not less than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="value"/> is <c>null</c></exception>
        public static Argument<T> LessThan<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.LessThan(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(arg,
                    $"Argument '{arg.Name}' must be less than '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than <paramref name="value"/>
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="value"/> is <c>null</c></exception>
        public static Argument<T> Max<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.Max(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(arg,
                    $"The maximum value for the argument '{arg.Name}' is '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is less than <paramref name="value"/>
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is less than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="value"/> is <c>null</c></exception>
        public static Argument<T> Min<T>(this Argument<T> arg, T value) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.Min(arg, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(arg,
                    $"The minimum value for the argument '{arg.Name}' is '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not in range <paramref name="min"/> - <paramref name="max"/>
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not in range <paramref name="min"/> - <paramref name="max"/></exception>
        /// <exception cref="ArgValidationException">
        /// <para>Throws in the following cases:</para>
        /// <para>- argument is <c>null</c></para>
        /// <para>- <paramref name="min"/> is <c>null</c></para>
        /// <para>- <paramref name="max"/> is <c>null</c></para>
        /// <para>- <paramref name="min"/> - <paramref name="max"/> is not range</para>
        /// </exception>
        public static Argument<T> InRange<T>(this Argument<T> arg, T min, T max) where T : IComparable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!CompatableConditionChecker.InRange(arg, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(arg,
                    $"Argument '{arg.Name}' must be in range from '{min}' to '{max}'. Current value: '{arg.Value}'");

            return arg;
        }
    }
}