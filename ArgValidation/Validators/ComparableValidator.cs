using System;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Validators
{
    public sealed class ComparableValidator<T> : ValidatorBase<T, ComparableValidator<T>>
        where T : IComparable<T>
    {
        internal ComparableValidator(ValidatingObject<T> validatingObject) : base(validatingObject)
        {
        }

        protected override ComparableValidator<T> CreateInstance()
        {
            return this;
        }

        
        public ComparableValidator<T> MoreThan(T value)
        {
            if (!ConditionChecker.MoreThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be more than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<T> MoreOrEqualThan(T value)
        {
            if (!ConditionChecker.MoreOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be more or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<T> LessThan(T value)
        {
            if (!ConditionChecker.LessThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be less than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<T> LessOrEqualThan(T value)
        {
            if (!ConditionChecker.LessOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be less or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<T> InRange(T min, T max)
        {
            if (!ConditionChecker.InRange(ValidatingObject, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be in range from '{min}' to '{max}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

    }
}