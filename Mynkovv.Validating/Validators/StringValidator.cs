using Mynkovv.Validating.ExceptionThrowers;
using System;

namespace Mynkovv.Validating.Validators
{
    public sealed class StringValidator : ValidatorBase<string, StringValidator>
    {
        internal StringValidator(ValidatingObject<string> validatingObject) : base(validatingObject)
        {
        }

        protected override StringValidator CreateInstance()
        {
            return this;
        }

        public StringValidator NullOrEmpty()
        {
            if (!string.IsNullOrEmpty(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be empty or null. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator NotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' cannot be empty or null. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator NullOrWhitespace()
        {
            if (!string.IsNullOrWhiteSpace(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be empty or whitespace. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator NotNullOrWhitespace()
        {
            if (string.IsNullOrWhiteSpace(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' cannot be empty or whitespace. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator LengthEqual(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length != value)
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be length {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator LengthMoreThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length <= value)
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be length more than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator LengthMoreOrEqualThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length < value)
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be length more or equals than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator LengthLessThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length >= value)
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be length less than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator LengthLessOrEqualThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length > value)
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be length less or equals than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator LengthInRange(int min, int max)
        {
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            if (ValidatingObject.Value == null || !ValidatingObject.Value.Length.InRange(min, max))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must be length in range {min} - {max}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");


            return this;
        }

        public StringValidator Contains(string value)
        {
            if (!Contains(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must contains {GetStringValueForMessage(value)}. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        public StringValidator NotContains(string value)
        {
            if (Contains(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentException($"String with name '{ValidatingObject.Name}' must not contains {GetStringValueForMessage(value)}. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return this;
        }

        private static bool Contains(ValidatingObject<string> validatingObject, string value)
        {
            if (validatingObject.Value != null)
            {
                if (value == null)
                    return false;

                return validatingObject.Value.Contains(value);
            }

            return value == null;
        }

        private static string GetStringValueForMessage(string str)
        {
            if (str == null)
                return "null";

            return $"'{str}'";
        }

        private static string GetLengthValueForMessage(string value)
        {
            if (value == null)
                return "unknown (string is null)";

            return value.Length.ToString();
        }
    }
}
