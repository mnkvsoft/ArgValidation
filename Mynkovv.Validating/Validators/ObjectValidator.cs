using Mynkovv.Validating.ExceptionThrowers;
using System.Linq;

namespace Mynkovv.Validating.Validators
{
    public sealed class ObjectValidator<TValue> : ValidatorBase<TValue, ObjectValidator<TValue>>
    {
        internal ObjectValidator(ValidatingObject<TValue> validatingObject) : base(validatingObject)
        {
        }

        protected override ObjectValidator<TValue> CreateInstance()
        {
            return this;
        }


        public ObjectValidator<TValue> MoreThan(TValue value)
        {
            if (!ConditionChecker.MoreThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be more than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public ObjectValidator<TValue> MoreOrEqualThan(TValue value)
        {
            if (!ConditionChecker.MoreOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be more or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public ObjectValidator<TValue> LessThan(TValue value)
        {
            if (!ConditionChecker.LessThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be less than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public ObjectValidator<TValue> LessOrEqualThan(TValue value)
        {
            if (!ConditionChecker.LessOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be less or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public ObjectValidator<TValue> InRange(TValue min, TValue max)
        {
            if (!ConditionChecker.InRange(ValidatingObject, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be in range from '{min}' to '{max}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public ObjectValidator<TValue> OnlyValues(params TValue[] values)
        {
            if (!ConditionChecker.OnlyValues(ValidatingObject, values))
            {
                string valuesStr = string.Join(", ", values.Select(v => $"'{v}'"));
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must have only values: {valuesStr}. Current value: '{ValidatingObject.Value}'");
            }

            return CreateInstance();
        }
    }
}
