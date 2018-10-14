using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Validators
{
    public sealed class StringValidator : ValidatorBase<string, StringValidator>
    {
        internal StringValidator(Argument<string> argument) : base(argument)
        {
        }

        protected override StringValidator CreateInstance()
        {
            return this;
        }

        public StringValidator NullOrEmpty()
        {
            if (!string.IsNullOrEmpty(Argument.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator NotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(Argument.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' cannot be empty or null. Current value: {ExceptionMessageHelper.GetStringValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator NullOrWhitespace()
        {
            if (!string.IsNullOrWhiteSpace(Argument.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator NotNullOrWhitespace()
        {
            if (string.IsNullOrWhiteSpace(Argument.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' cannot be empty or whitespace. Current value: {ExceptionMessageHelper.GetStringValueForMessage(Argument.Value)}");

            return this;
        }

        // todo: add string value with message
        public StringValidator LengthEqual(int value)
        {
            if (Argument.Value == null || Argument.Value.Length != value)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be length {value}. Current length: {GetLengthValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator LengthMoreThan(int value)
        {
            if (Argument.Value == null || Argument.Value.Length <= value)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be length more than {value}. Current length: {GetLengthValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator LengthMoreOrEqualThan(int value)
        {
            if (Argument.Value == null || Argument.Value.Length < value)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be length more or equals than {value}. Current length: {GetLengthValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator LengthLessThan(int value)
        {
            if (Argument.Value == null || Argument.Value.Length >= value)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be length less than {value}. Current length: {GetLengthValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator LengthLessOrEqualThan(int value)
        {
            if (Argument.Value == null || Argument.Value.Length > value)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be length less or equals than {value}. Current length: {GetLengthValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator LengthInRange(int min, int max)
        {
            InvalidMethodArgumentThrower.IfNotRange(min, max);

            if (Argument.Value == null || !Argument.Value.Length.InRange(min, max))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be length in range {min} - {max}. Current length: {GetLengthValueForMessage(Argument.Value)}");


            return this;
        }

        public StringValidator Contains(string value)
        {
            if (!Contains(Argument, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(Argument.Value)}");

            return this;
        }

        public StringValidator NotContains(string value)
        {
            if (Contains(Argument, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must not contains {ExceptionMessageHelper.GetStringValueForMessage(value)}. Current value: {ExceptionMessageHelper.GetStringValueForMessage(Argument.Value)}");

            return this;
        }

        private static bool Contains(Argument<string> argument, string value)
        {
            if (argument.Value != null)
            {
                if (value == null)
                    return false;

                return argument.Value.Contains(value);
            }

            return value == null;
        }

        private static string GetLengthValueForMessage(string value)
        {
            if (value == null)
                return "unknown (string is null)";

            return value.Length.ToString();
        }
    }
}
