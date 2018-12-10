using System;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    public static class ArgumentExtension
    {
        public static Argument<T> Default<T>(this Argument<T> arg)
        {
            if (!ObjectConditionChecker.IsDefault(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be default value. Current value: '{arg.Value}'");
            return arg;
        }

        public static Argument<T> NotDefault<T>(this Argument<T> arg)
        {
            if (ObjectConditionChecker.IsDefault(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{arg.Name}' must be not default value");

            return arg;
        }

        public static Argument<T> Null<T>(this Argument<T> arg)
        {
            if (arg.Value != null)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be null. Current value: '{arg.Value}'");

            return arg;
        }

        public static Argument<T> NotNull<T>(this Argument<T> arg)
        {
            if (arg.Value == null)
                ValidationErrorExceptionThrower.ArgumentNullException(arg.Name);

            return arg;
        }

        public static Argument<T> Equal<T>(this Argument<T> arg, T value)
        {
            if (!ObjectConditionChecker.IsEqual(arg.Value, value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be equal '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        public static Argument<T> NotEqual<T>(this Argument<T> arg, T value)
        {
            if (ObjectConditionChecker.IsEqual(arg.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{arg.Name}' must be not equal '{value}'");

            return arg;
        }


        public static Argument<T> OnlyValues<T>(this Argument<T> arg, params T[] values)
        {
            if (!ObjectConditionChecker.OnlyValues(arg, values))
            {
                var valuesStr = string.Join(", ", values.Select(v => $"'{v}'"));
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must have only values: {valuesStr}. Current value: '{arg.Value}'");
            }

            return arg;
        }

        public static Argument<T> FailedIf<T>(this Argument<T> arg, bool condition, string message)
        {
            if (condition)
                ValidationErrorExceptionThrower.ArgumentException(message + Environment.NewLine + $"Argument name: '{arg.Name}'");

            return arg;
        }
    }
}