using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal.Utils;

namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods for <see cref="IEnumerable"/> type
    /// </summary>
    public static class ArgumentEnumerableExtension
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is not equals <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is not equals <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> CountEqual<TEnumerable>(this Argument<TEnumerable> arg, int value)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (!arg.Value.CountEquals(value))
                ValidationErrorExceptionThrower.ArgumentException(arg,
                    $"Argument '{arg.Name}' must contains {value} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is equals <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is equals <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> CountNotEqual<TEnumerable>(this Argument<TEnumerable> arg, int value)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (arg.Value.CountEquals(value))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' not must contains {arg.Value.Count()} elements");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is not more than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is not more than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> CountMoreThan<TEnumerable>(this Argument<TEnumerable> arg, int value)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (!arg.Value.CountMoreThan(value))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must contains more than {value} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is not less than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is not less than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> CountLessThan<TEnumerable>(this Argument<TEnumerable> arg, int value)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (!arg.Value.CountLessThan(value))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must contains less than {value} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is less than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is less than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> MinCount<TEnumerable>(this Argument<TEnumerable> arg,
            int value) where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (arg.Value.CountLessThan(value))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must contains a minimum of {value} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is more than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is more than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> MaxCount<TEnumerable>(this Argument<TEnumerable> arg,
            int value) where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (arg.Value.CountMoreThan(value))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must contains a maximum of {value} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not contains <paramref name="elem"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not contains <paramref name="elem"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> Contains<TEnumerable, T>(this Argument<TEnumerable> arg, T elem)
            where TEnumerable : IEnumerable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(Contains));

            if (!arg.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");
            // todo: current values

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is contains <paramref name="elem"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is contains <paramref name="elem"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> NotContains<TEnumerable, T>(this Argument<TEnumerable> arg, T elem)
            where TEnumerable : IEnumerable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(NotContains));

            if (arg.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");
            // todo: current values

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is more than 0</exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> Empty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(Empty));

            var currentCount = arg.Value.Count();
            if (currentCount > 0)
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must be empty");
            // todo: current values

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is equals 0</exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<TEnumerable> NotEmpty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(NotEmpty));

            var currentCount = arg.Value.Count();
            if (currentCount < 1)
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must be not empty");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or elements count is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or elements count is more than 0</exception>
        public static Argument<TEnumerable> NullOrEmpty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value == null)
                return arg;

            var currentCount = arg.Value.Count();
            if (currentCount > 0)
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must be null or empty");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or elements count is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or elements count is equals 0</exception>
        public static Argument<TEnumerable> NotNullOrEmpty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value == null)
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must be null or empty. Current value is null");

            var currentCount = arg.Value.Count();
            if (currentCount < 1)
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must be null or empty. Current value is empty");

            return arg;
        }

        // todo: count in range
    }
}