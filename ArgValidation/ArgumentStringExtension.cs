﻿using System;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    public static class ArgumentStringExtension
    {
        public static Argument<string> NullOrEmpty(this Argument<string> arg)
        {
            if (!string.IsNullOrEmpty(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NotNullOrEmpty(this Argument<string> arg)
        {
            if (string.IsNullOrEmpty(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' cannot be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NullOrWhitespace(this Argument<string> arg)
        {
            if (!string.IsNullOrWhiteSpace(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NotNullOrWhitespace(this Argument<string> arg)
        {
            if (string.IsNullOrWhiteSpace(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' cannot be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> LengthEqual(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(LengthEqual));

            if (arg.Value.Length != value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> LengthMoreThan(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(LengthMoreThan));

            if (arg.Value.Length <= value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length more than {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> LengthLessThan(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(LengthLessThan));

            if (arg.Value.Length >= value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length less than {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> MaxLength(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(MaxLength));

            if (arg.Value.Length > value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' has a maximum length of {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> MinLength(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(MinLength));

            if (arg.Value.Length < value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' has a minimum length of {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> LengthInRange(this Argument<string> arg, int min, int max)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(LengthInRange));
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            if (!arg.Value.Length.InRange(min, max))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length in range {min} - {max}. Current length: {GetLengthValueForMessage(arg.Value)}");


            return arg;
        }

        public static Argument<string> Contains(this Argument<string> arg, string value)
        {
            if (!ContainsPrivate(arg, value, nameof(Contains)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }

        public static Argument<string> NotContains(this Argument<string> arg, string value)
        {
            if (ContainsPrivate(arg, value, nameof(NotContains)))
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must not contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(arg.Value)}");

            return arg;
        }


        [Obsolete("Use MinLength method")]
        public static Argument<string> LengthMoreOrEqualThan(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(LengthMoreOrEqualThan));
            
            if (arg.Value.Length < value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length more or equals than {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }

        [Obsolete("Use MaxLength method")]
        public static Argument<string> LengthLessOrEqualThan(this Argument<string> arg, int value)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, nameof(LengthLessOrEqualThan));
            
            if (arg.Value.Length > value)
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{arg.Name}' must be length less or equals than {value}. Current length: {GetLengthValueForMessage(arg.Value)}");

            return arg;
        }


        //todo Match

        private static bool ContainsPrivate(Argument<string> arg, string value, string operationName)
        {
            InvalidMethodArgumentThrower.IfNullForLength(arg, operationName);

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