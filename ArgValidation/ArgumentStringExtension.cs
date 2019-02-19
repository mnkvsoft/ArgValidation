using System;
using ArgValidation.Internal;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal.Utils;

namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods for <see cref="string"/> type
    /// </summary>
    public static class ArgumentStringExtension
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or length is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or length is more than 0</exception>
        public static Argument<string> NullOrEmpty(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!string.IsNullOrEmpty(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or length is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or length is equals 0</exception>
        public static Argument<string> NotNullOrEmpty(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (string.IsNullOrEmpty(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' cannot be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or argument is not contains only whitespaces
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or argument is not contains only whitespaces</exception>
        public static Argument<string> NullOrWhitespace(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!string.IsNullOrWhiteSpace(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or argument is contains only whitespaces
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or argument is contains only whitespaces</exception>
        public static Argument<string> NotNullOrWhitespace(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (string.IsNullOrWhiteSpace(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' cannot be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if length is not equals <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if length is not equals <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> LengthEqual(this Argument<string> arg, int value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(LengthEqual));

            if (arg.Value.Length != value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if length is not more than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if length is not more than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> LengthMoreThan(this Argument<string> arg, int value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(LengthMoreThan));

            if (arg.Value.Length <= value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length more than {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if length is not less than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if length is not less than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> LengthLessThan(this Argument<string> arg, int value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(LengthLessThan));

            if (arg.Value.Length >= value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length less than {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if length is more than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if length is more than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> MaxLength(this Argument<string> arg, int value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(MaxLength));

            if (arg.Value.Length > value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' has a maximum length of {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if length is less than <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if length is less than <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> MinLength(this Argument<string> arg, int value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(MinLength));

            if (arg.Value.Length < value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' has a minimum length of {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if length is not in range from <paramref name="min"/> to <paramref name="max"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if length is not in range from <paramref name="min"/> to <paramref name="max"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="min"/> - <paramref name="max"/> is not range</exception>
        public static Argument<string> LengthInRange(this Argument<string> arg, int min, int max)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(LengthInRange));
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            if (!arg.Value.Length.InRange(min, max))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length in range {min} - {max}. Current length: {GetLengthValueForMessage(arg.Value)}");


            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not contains <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not contains <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> Contains(this Argument<string> arg, string value)
        {
            return Contains(arg, value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not contains <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not contains <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> Contains(this Argument<string> arg, string value, StringComparison comparisonType)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ContainsPrivate(arg, value, comparisonType, methodName: nameof(Contains)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is contains <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is contains <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> NotContains(this Argument<string> arg, string value)
        {
            return NotContains(arg, value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is contains <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is contains <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> NotContains(this Argument<string> arg, string value, StringComparison comparisonType)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ContainsPrivate(arg, value, comparisonType, methodName: nameof(NotContains)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must not contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not starts with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not starts with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> StartsWith(this Argument<string> arg, string value)
        {
            return StartsWith(arg, value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not starts with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not starts with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> StartsWith(this Argument<string> arg, string value, StringComparison comparisonType)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!StartsWithPrivate(arg, value, comparisonType, methodName: nameof(StartsWith)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must starts with {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is starts with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is starts with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> NotStartsWith(this Argument<string> arg, string value)
        {
            return NotStartsWith(arg, value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is starts with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is starts with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> NotStartsWith(this Argument<string> arg, string value, StringComparison comparisonType)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (StartsWithPrivate(arg, value, comparisonType, methodName: nameof(NotStartsWith)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must not starts with {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not ends with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not ends with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> EndsWith(this Argument<string> arg, string value)
        {
            return EndsWith(arg, value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not ends with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not ends with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> EndsWith(this Argument<string> arg, string value, StringComparison comparisonType)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!EndsWithPrivate(arg, value, comparisonType, methodName: nameof(EndsWith)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must ends with {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is ends with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is ends with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> NotEndsWith(this Argument<string> arg, string value)
        {
            return NotEndsWith(arg, value, StringComparison.CurrentCulture);
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is ends with <paramref name="value"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is ends with <paramref name="value"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static Argument<string> NotEndsWith(this Argument<string> arg, string value, StringComparison comparisonType)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (EndsWithPrivate(arg, value, comparisonType, methodName: nameof(NotEndsWith)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must not ends with {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not match <paramref name="pattern"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not match <paramref name="pattern"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="pattern"/> is <c>null</c></exception>
        public static Argument<string> Match(this Argument<string> arg, string pattern)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(Match));
            InvalidMethodArgumentThrower.IfArgumentOfMethodIsNull(arg: pattern, argName: nameof(pattern), methodName: nameof(Match));

            if (!StringConditionChecker.Match(arg, pattern))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be match with pattern '{pattern}'. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is match <paramref name="pattern"/>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is match <paramref name="pattern"/></exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c> or <paramref name="pattern"/> is <c>null</c></exception>
        public static Argument<string> NotMatch(this Argument<string> arg, string pattern)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName: nameof(NotMatch));
            InvalidMethodArgumentThrower.IfArgumentOfMethodIsNull(arg: pattern, argName: nameof(pattern), methodName: nameof(NotMatch));

            if (StringConditionChecker.Match(arg, pattern))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' not must be match with pattern '{pattern}'. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        // todo: NotMatch(this Argument<string> arg, Regex regex)
        // todo: Char(5).IsDigit()

        private static bool ContainsPrivate(Argument<string> arg, string value, StringComparison comparisonType, string methodName)
        {
            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName);
            InvalidMethodArgumentThrower.IfArgumentOfMethodIsNull(value, nameof(value), methodName);

            return arg.Value.IndexOf(value, comparisonType) >= 0;
        }

        private static bool StartsWithPrivate(Argument<string> arg, string value, StringComparison comparisonType, string methodName)
        {
            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName);
            InvalidMethodArgumentThrower.IfArgumentOfMethodIsNull(value, nameof(value), methodName);

            return arg.Value.StartsWith(value, comparisonType);
        }

        private static bool EndsWithPrivate(Argument<string> arg, string value, StringComparison comparisonType, string methodName)
        {
            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName);
            InvalidMethodArgumentThrower.IfArgumentOfMethodIsNull(value, nameof(value), methodName);

            return arg.Value.EndsWith(value, comparisonType);
        }

        private static string GetLengthValueForMessage(string value)
        {
            if (value == null)
                return "unknown (string is null)";

            return value.Length.ToString();
        }
    }
}