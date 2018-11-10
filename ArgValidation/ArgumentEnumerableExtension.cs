using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    public static class ArgumentEnumerableExtension
    {
        public static Argument<TEnumerable> CountEqual<TEnumerable>(this Argument<TEnumerable> argument, int count)
            where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount != count)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> CountNotEqual<TEnumerable>(this Argument<TEnumerable> argument, int count)
            where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount == count)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' not must contains {count} elements");

            return argument;
        }

        public static Argument<TEnumerable> CountMoreThan<TEnumerable>(this Argument<TEnumerable> argument, int count)
            where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount <= count)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains more than {count} elements. Current count elements: {currentCount}");

            return argument;
        }
        
        public static Argument<TEnumerable> CountLessThan<TEnumerable>(this Argument<TEnumerable> argument, int count)
            where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount >= count)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains less than {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        [Obsolete("Use MinCount method")]
        public static Argument<TEnumerable> CountMoreOrEqualThan<TEnumerable>(this Argument<TEnumerable> argument,
            int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount < count)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains more or equal than {count} elements. Current count elements: {currentCount}");

            return argument;
        }
        
        [Obsolete("Use MaxCount method")]
        public static Argument<TEnumerable> CountLessOrEqualThan<TEnumerable>(this Argument<TEnumerable> argument,
            int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount > count)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains less or equal than {count} elements. Current count elements: {currentCount}");

            return argument;
        }
        
        public static Argument<TEnumerable> MinCount<TEnumerable>(this Argument<TEnumerable> argument,
            int minCount) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount < minCount)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains a minimum of {minCount} elements. Current count elements: {currentCount}");

            return argument;
        }
        
        public static Argument<TEnumerable> MaxCount<TEnumerable>(this Argument<TEnumerable> argument,
            int maxCount) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            var currentCount = argument.Value.Count();
            if (currentCount > maxCount)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must contains a maximum of {maxCount} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> Contains<TEnumerable, T>(this Argument<TEnumerable> argument, T elem)
            where TEnumerable : IEnumerable<T>
        {
            InvalidMethodArgumentThrower.IfNullForContains(argument);

            if (!argument.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return argument;
        }

        public static Argument<TEnumerable> NotContains<TEnumerable, T>(this Argument<TEnumerable> argument, T elem)
            where TEnumerable : IEnumerable<T>
        {
            InvalidMethodArgumentThrower.IfNullForNotContains(argument);

            if (argument.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return argument;
        }
        
        public static Argument<TEnumerable> Empty<TEnumerable>(this Argument<TEnumerable> argument)
            where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForEmpty(argument);

            var currentCount = argument.Value.Count();
            if (currentCount > 0)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must be empty");

            return argument;
        }

        public static Argument<TEnumerable> NotEmpty<TEnumerable>(this Argument<TEnumerable> argument)
            where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForNotEmpty(argument);

            var currentCount = argument.Value.Count();
            if (currentCount < 1)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must be not empty");

            return argument;
        }
        
        public static Argument<TEnumerable> NullOrEmpty<TEnumerable>(this Argument<TEnumerable> argument)
            where TEnumerable : IEnumerable
        {
            if (argument.Value == null)
                return argument;

            var currentCount = argument.Value.Count();
            if (currentCount > 0)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must be null or empty");

            return argument;
        }

        public static Argument<TEnumerable> NotNullOrEmpty<TEnumerable>(this Argument<TEnumerable> argument)
            where TEnumerable : IEnumerable
        {
            if (argument.Value == null)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must be null or empty. Current value is null");

            var currentCount = argument.Value.Count();
            if (currentCount < 1)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{argument.Name}' must be null or empty. Current value is empty");

            return argument;
        }
    }
}