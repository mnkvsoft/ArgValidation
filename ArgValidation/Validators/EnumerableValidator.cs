using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Validators
{
    public static class EnumerableValidator
    {
        public static Argument<TEnumerable> CountEqual<TEnumerable>(this Argument<TEnumerable> argument, int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            int currentCount = argument.Value.Count();
            if (currentCount != count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' must contains {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> CountNotEqual<TEnumerable>(this Argument<TEnumerable> argument,int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            int currentCount = argument.Value.Count();
            if (currentCount == count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' not must contains {count} elements");

            return argument;
        }

        public static Argument<TEnumerable> CountMoreThan<TEnumerable>(this Argument<TEnumerable> argument,int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            int currentCount = argument.Value.Count();
            if (currentCount <= count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' must contains more than {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> CountMoreOrEqualThan<TEnumerable>(this Argument<TEnumerable> argument,int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            int currentCount = argument.Value.Count();
            if (currentCount < count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' must contains more or equal than {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> CountLessThan<TEnumerable>(this Argument<TEnumerable> argument,int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            int currentCount = argument.Value.Count();
            if (currentCount >= count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' must contains less than {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> CountLessOrEqualThan<TEnumerable>(this Argument<TEnumerable> argument,int count) where TEnumerable : IEnumerable
        {
            InvalidMethodArgumentThrower.IfNullForCount(argument);

            int currentCount = argument.Value.Count();
            if (currentCount > count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' must contains less or equal than {count} elements. Current count elements: {currentCount}");

            return argument;
        }

        public static Argument<TEnumerable> Contains<TEnumerable, T>(this Argument<TEnumerable> argument, T elem) where TEnumerable :IEnumerable<T>
        {
            InvalidMethodArgumentThrower.IfNullForContains(argument);

            if (!argument.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return argument;
        }

        public static Argument<TEnumerable> NotContains<TEnumerable, T>(this Argument<TEnumerable> argument, T elem) where TEnumerable :IEnumerable<T>
        {
            InvalidMethodArgumentThrower.IfNullForNotContains(argument);

            if (argument.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{argument.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return argument;
        }
    }
}

