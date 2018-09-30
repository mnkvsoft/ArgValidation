using System;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Validators
{
    public sealed class ComparableValidator<TValue> : ValidatorBase<TValue, ComparableValidator<TValue>>
        where TValue : IComparable<TValue>
    {
        internal ComparableValidator(ValidatingObject<TValue> validatingObject) : base(validatingObject)
        {
        }

        protected override ComparableValidator<TValue> CreateInstance()
        {
            return this;
        }

        
        public ComparableValidator<TValue> MoreThan(TValue value)
        {
            if (!ConditionChecker.MoreThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be more than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<TValue> MoreOrEqualThan(TValue value)
        {
            if (!ConditionChecker.MoreOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be more or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<TValue> LessThan(TValue value)
        {
            if (!ConditionChecker.LessThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be less than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<TValue> LessOrEqualThan(TValue value)
        {
            if (!ConditionChecker.LessOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be less or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

        public ComparableValidator<TValue> InRange(TValue min, TValue max)
        {
            if (!ConditionChecker.InRange(ValidatingObject, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException(
                    $"Object with name '{ValidatingObject.Name}' must be in range from '{min}' to '{max}'. Current value: '{ValidatingObject.Value}'");

            return this;
        }

    }
}