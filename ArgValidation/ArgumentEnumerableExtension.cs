using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal.Utils;

namespace ArgValidation
{
    public static class ArgumentEnumerableExtension
    {
        public static Argument<TEnumerable> CountEqual<TEnumerable>(this Argument<TEnumerable> arg, int count)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (!arg.Value.CountEquals(count))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains {count} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        public static Argument<TEnumerable> CountNotEqual<TEnumerable>(this Argument<TEnumerable> arg, int count)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (arg.Value.CountEquals(count))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' not must contains {arg.Value.Count()} elements");

            return arg;
        }

        public static Argument<TEnumerable> CountMoreThan<TEnumerable>(this Argument<TEnumerable> arg, int count)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (!arg.Value.CountMoreThan(count))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains more than {count} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        public static Argument<TEnumerable> CountLessThan<TEnumerable>(this Argument<TEnumerable> arg, int count)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (!arg.Value.CountLessThan(count))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains less than {count} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        public static Argument<TEnumerable> MinCount<TEnumerable>(this Argument<TEnumerable> arg,
            int count) where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (arg.Value.CountLessThan(count))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains a minimum of {count} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        public static Argument<TEnumerable> MaxCount<TEnumerable>(this Argument<TEnumerable> arg,
            int count) where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentIsNullForCount(arg);

            if (arg.Value.CountMoreThan(count))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains a maximum of {count} elements. Current count elements: {arg.Value.Count()}");

            return arg;
        }

        public static Argument<TEnumerable> Contains<TEnumerable, T>(this Argument<TEnumerable> arg, T elem)
            where TEnumerable : IEnumerable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(Contains));

            if (!arg.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return arg;
        }

        public static Argument<TEnumerable> NotContains<TEnumerable, T>(this Argument<TEnumerable> arg, T elem)
            where TEnumerable : IEnumerable<T>
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(NotContains));

            if (arg.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return arg;
        }

        public static Argument<TEnumerable> Empty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(Empty));

            var currentCount = arg.Value.Count();
            if (currentCount > 0)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty");

            return arg;
        }

        public static Argument<TEnumerable> NotEmpty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(NotEmpty));

            var currentCount = arg.Value.Count();
            if (currentCount < 1)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be not empty");

            return arg;
        }

        public static Argument<TEnumerable> NullOrEmpty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value == null)
                return arg;

            var currentCount = arg.Value.Count();
            if (currentCount > 0)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be null or empty");

            return arg;
        }

        public static Argument<TEnumerable> NotNullOrEmpty<TEnumerable>(this Argument<TEnumerable> arg)
            where TEnumerable : IEnumerable
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value == null)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be null or empty. Current value is null");

            var currentCount = arg.Value.Count();
            if (currentCount < 1)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be null or empty. Current value is empty");

            return arg;
        }
    }
}