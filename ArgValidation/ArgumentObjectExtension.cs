using System;
using System.Linq;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal;

namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods common to all types
    /// </summary>
    public static class ArgumentObjectExtension
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not default value
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not default value</exception>
        public static Argument<T> Default<T>(this Argument<T> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ObjectConditionChecker.IsDefault(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be default value. Current value: '{arg.Value}'");
            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is default value
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is default value</exception>
        public static Argument<T> NotDefault<T>(this Argument<T> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ObjectConditionChecker.IsDefault(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{arg.Name}' must be not default value");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not <c>null</c>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not <c>null</c></exception>
        public static void Null<T>(this Argument<T> arg) where T : class
        {
            if (arg.ValidationIsDisabled())
                return;

            if (arg.Value != null)
                ValidationErrorExceptionThrower.ArgumentException(GetMessageFotNullValidation(arg));
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not <c>null</c>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not <c>null</c></exception>
        public static void Null<T>(this Argument<T?> arg) where T : struct
        {
            if (arg.ValidationIsDisabled())
                return;

            if (arg.Value != null)
                ValidationErrorExceptionThrower.ArgumentException(GetMessageFotNullValidation(arg));
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentNullException"/> if the argument is <c>null</c>
        /// </para>
        /// <para>
        /// Overload for the <see cref="Nullable{T}"/> type is specifically not defined, because this type is used specifically 
        /// when the argument should be able to have the value null
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is <c>null</c></exception>
        public static Argument<T> NotNull<T>(this Argument<T> arg) where T : class
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value == null)
                ValidationErrorExceptionThrower.ArgumentNullException(arg.Name);

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not equals <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not equals <paramref name="value"/></exception>
        public static Argument<T> Equal<T>(this Argument<T> arg, T value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ObjectConditionChecker.IsEqual(arg.Value, value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be equal '{value}'. Current value: '{arg.Value}'");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is equals <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is equals <paramref name="value"/></exception>
        public static Argument<T> NotEqual<T>(this Argument<T> arg, T value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ObjectConditionChecker.IsEqual(arg.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{arg.Name}' must be not equal '{value}'");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not contained in <paramref name="values"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not contained in <paramref name="values"/></exception>
        /// <exception cref="ArgValidationException">Throws if <paramref name="values"/> is <c>null</c></exception>
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

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is contained in <paramref name="values"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is contained in <paramref name="values"/></exception>
        /// <exception cref="ArgValidationException">Throws if <paramref name="values"/> is <c>null</c></exception>
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
        /// Throw <see cref="ArgumentException"/> with message <paramref name="message"/> if <paramref name="condition"/> is <c>true</c>
        /// </summary>
        /// <exception cref="ArgumentException">If <paramref name="condition"/> is <c>true</c></exception>
        public static Argument<T> FailedIf<T>(this Argument<T> arg, bool condition, string message)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (condition)
                ValidationErrorExceptionThrower.ArgumentException(message + Environment.NewLine + $"Argument name: '{arg.Name}'");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not contained in <paramref name="values"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not contained in <paramref name="values"/></exception>
        /// <exception cref="ArgValidationException">Throws if <paramref name="values"/> is <c>null</c></exception>
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