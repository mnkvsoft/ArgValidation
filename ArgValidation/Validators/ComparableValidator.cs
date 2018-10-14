using System;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Validators
{
    public sealed class ComparableValidator<T> : ValidatorBase<T, ComparableValidator<T>>
        where T : IComparable<T>
    {
        internal ComparableValidator(Argument<T> argument) : base(argument)
        {
        }

        protected override ComparableValidator<T> CreateInstance()
        {
            return this;
        }

        
        public ComparableValidator<T> MoreThan(T value)
        {
            if (!ConditionChecker.MoreThan(Argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{Argument.Name}' must be more than '{value}'. Current value: '{Argument.Value}'");

            return this;
        }

        public ComparableValidator<T> MoreOrEqualThan(T value)
        {
            if (!ConditionChecker.MoreOrEqualThan(Argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{Argument.Name}' must be more or equal than '{value}'. Current value: '{Argument.Value}'");

            return this;
        }

        public ComparableValidator<T> LessThan(T value)
        {
            if (!ConditionChecker.LessThan(Argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{Argument.Name}' must be less than '{value}'. Current value: '{Argument.Value}'");

            return this;
        }

        public ComparableValidator<T> LessOrEqualThan(T value)
        {
            if (!ConditionChecker.LessOrEqualThan(Argument, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{Argument.Name}' must be less or equal than '{value}'. Current value: '{Argument.Value}'");

            return this;
        }

        public ComparableValidator<T> InRange(T min, T max)
        {
            if (!ConditionChecker.InRange(Argument, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Argument '{Argument.Name}' must be in range from '{min}' to '{max}'. Current value: '{Argument.Value}'");

            return this;
        }

    }
}