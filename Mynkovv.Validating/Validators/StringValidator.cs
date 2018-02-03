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
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be empty or null. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator NotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(ValidatingObject.Value))
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' cannot be empty or null. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator NullOrWhitespace()
        {
            if (!string.IsNullOrWhiteSpace(ValidatingObject.Value))
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be empty or whitespace. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator NotNullOrWhitespace()
        {
            if (string.IsNullOrWhiteSpace(ValidatingObject.Value))
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' cannot be empty or whitespace. Current value: {GetStringValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator LengthEqual(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length != value)
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be length {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator LengthMoreThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length <= value)
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be length more than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator LengthMoreOrEqualThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length < value)
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be length more or equals than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator LengthLessThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length >= value)
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be length less than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator LengthLessOrEqualThan(int value)
        {
            if (ValidatingObject.Value == null || ValidatingObject.Value.Length > value)
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be length less or equals than {value}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");

            return CreateInstance();
        }

        public StringValidator LengthInRange(int min, int max)
        {
            InnerExceptionThrower.IfNotRange(min, max);

            if (ValidatingObject.Value == null || !ValidatingObject.Value.Length.InRange(min, max))
                throw new ArgumentException($"String with name '{ValidatingObject.Name}' must be length in range {min} - {max}. Current length: {GetLengthValueForMessage(ValidatingObject.Value)}");


            return CreateInstance();
        }

        public StringValidator Contains(string value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator NotContains(string value)
        {
            throw new NotImplementedException();

            return CreateInstance();
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
