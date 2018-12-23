using System;
using System.Linq;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal;

namespace ArgValidation
{
    public static class ArgumentExtension
    {
        public static Argument<T> Default<T>(this Argument<T> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ObjectConditionChecker.IsDefault(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be default value. Current value: '{arg.Value}'");
            return arg;
        }

        public static Argument<T> NotDefault<T>(this Argument<T> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ObjectConditionChecker.IsDefault(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{arg.Name}' must be not default value");

            return arg;
        }

        public static void Null<T>(this Argument<T> arg) where T : class
        {
            if (arg.ValidationIsDisabled())
                return;

            if (arg.Value != null)
                ValidationErrorExceptionThrower.ArgumentException(GetMessageFotNullValidation(arg));
        }

        public static void Null<T>(this Argument<T?> arg) where T : struct
        {
            if (arg.ValidationIsDisabled())
                return;

            if (arg.Value != null)
                ValidationErrorExceptionThrower.ArgumentException(GetMessageFotNullValidation(arg));
        }

        /// <summary>
        /// If <paramref name="arg"/> is null then throw <see cref="ArgumentNullException"/>.
        /// 
        /// Overload for the <see cref="Nullable{T}"/> type is specifically not defined, because this type is used specifically 
        /// when the argument should be able to have the value null
        /// </summary>
        public static Argument<T> NotNull<T>(this Argument<T> arg) where T : class
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value == null)
                ValidationErrorExceptionThrower.ArgumentNullException(arg.Name);

            return arg;
        }

        public static Argument<T> Equal<T>(this Argument<T> arg, T value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ObjectConditionChecker.IsEqual(arg.Value, value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be equal '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        public static Argument<T> NotEqual<T>(this Argument<T> arg, T value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ObjectConditionChecker.IsEqual(arg.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{arg.Name}' must be not equal '{value}'");

            return arg;
        }

        public static Argument<T> In<T>(this Argument<T> arg, params T[] values)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ObjectConditionChecker.In(arg, values))
            {
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' can only have the following values: {values.JoinForMessage()}. Current value: '{arg.Value}'");
            }

            return arg;
        }

        public static Argument<T> NotIn<T>(this Argument<T> arg, params T[] values)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ObjectConditionChecker.In(arg, values))
            {
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' can not have the following values: {values.JoinForMessage()}. Current value: {arg.Value.GetStringValueForMessage()}");
            }

            return arg;
        }

        /// <summary>
        /// Throw <see cref="ArgumentException"/> with message <see cref="message"/> if <see cref="condition"/> is true
        /// </summary>
        public static Argument<T> FailedIf<T>(this Argument<T> arg, bool condition, string message)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (condition)
                ValidationErrorExceptionThrower.ArgumentException(message + Environment.NewLine + $"Argument name: '{arg.Name}'");

            return arg;
        }

        [Obsolete("Use In method")]
        public static Argument<T> OnlyValues<T>(this Argument<T> arg, params T[] values)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ObjectConditionChecker.In(arg, values))
            {
                var valuesStr = string.Join(", ", values.Select(v => $"'{v}'"));
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must have only values: {valuesStr}. Current value: '{arg.Value}'");
            }

            return arg;
        }


        private static string GetMessageFotNullValidation<T>(Argument<T> arg)
        {
            return $"Argument '{arg.Name}' must be null. Current value: '{arg.Value}'";
        }
    }
}