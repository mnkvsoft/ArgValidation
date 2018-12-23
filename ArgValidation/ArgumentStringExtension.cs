using System;
using System.Text.RegularExpressions;
using ArgValidation.Internal;
using ArgValidation.Internal.ConditionCheckers;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal.Utils;

namespace ArgValidation
{
    public static class ArgumentStringExtension
    {
        public static Argument<string> NullOrEmpty(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg; 

            if (!string.IsNullOrEmpty(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NotNullOrEmpty(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (string.IsNullOrEmpty(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' cannot be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NullOrWhitespace(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!string.IsNullOrWhiteSpace(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NotNullOrWhitespace(this Argument<string> arg)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (string.IsNullOrWhiteSpace(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' cannot be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

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

        public static Argument<string> Contains(this Argument<string> arg, string value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!ContainsPrivate(arg, value, methodName: nameof(Contains)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NotContains(this Argument<string> arg, string value)
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (ContainsPrivate(arg, value, methodName: nameof(NotContains)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must not contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

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

        private static bool ContainsPrivate(Argument<string> arg, string value, string methodName)
        {
            InvalidMethodArgumentThrower.IfArgumentValueIsNull(arg, methodName);

            if (value == null)
                return false;

            return arg.Value.Contains(value);
        }

        private static string GetLengthValueForMessage(string value)
        {
            if (value == null)
                return "unknown (string is null)";

            return value.Length.ToString();
        }
    }
}