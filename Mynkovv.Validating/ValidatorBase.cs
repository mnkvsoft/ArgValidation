using Mynkovv.Validating.ExceptionThrowers;
using System;
using System.Linq;

namespace Mynkovv.Validating
{
    public abstract class ValidatorBase<TValue, TInheritInstance>
    {
        protected ValidatingObject<TValue> ValidatingObject { get; }

        protected abstract TInheritInstance CreateInstance();

        internal ValidatorBase(ValidatingObject<TValue> validatingObject)
        {
            if (validatingObject == null)
                FrameworkErrorThrower.ArgumentNullException(nameof(validatingObject));

            ValidatingObject = validatingObject;
        }

        public TInheritInstance Default()
        {
            if (!ConditionChecker.IsDefault(ValidatingObject.Value))
                ValidationErrorThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be default value. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotDefault()
        {
            if (ConditionChecker.IsDefault(ValidatingObject.Value))
                ValidationErrorThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be not default value");

            return CreateInstance();
        }

        public TInheritInstance Null()
        {
            if (!ConditionChecker.IsNull(ValidatingObject.Value))
                ValidationErrorThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be null. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotNull()
        {
            if (ConditionChecker.IsNull(ValidatingObject.Value))
                ValidationErrorThrower.ArgumentNullException(ValidatingObject.Name);

            return CreateInstance();
        }

        public TInheritInstance Equal(TValue value)
        {
            if (!ConditionChecker.IsEqual(ValidatingObject.Value, value))
                ValidationErrorThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be equal '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotEqual(TValue value)
        {
            if (ConditionChecker.IsEqual(ValidatingObject.Value, value))
                ValidationErrorThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be not equal '{value}'");

            return CreateInstance();
        }

        public TInheritInstance MoreThan(TValue value)
        {
            if (!ConditionChecker.MoreThan(ValidatingObject, value))
                ValidationErrorThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be more than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance MoreOrEqualThan(TValue value)
        {
            if (!ConditionChecker.MoreOrEqualThan(ValidatingObject, value))
                ValidationErrorThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be more or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance LessThan(TValue value)
        {
            if (!ConditionChecker.LessThan(ValidatingObject, value))
                ValidationErrorThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be less than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance LessOrEqualThan(TValue value)
        {
            if (!ConditionChecker.LessOrEqualThan(ValidatingObject, value))
                ValidationErrorThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be less or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance InRange(TValue min, TValue max)
        {
            if (!ConditionChecker.InRange(ValidatingObject, min, max))
                ValidationErrorThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be in range from '{min}' to '{max}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance OnlyValues(params TValue[] values)
        {
            if (!ConditionChecker.OnlyValues(ValidatingObject, values))
            {
                string valuesStr = string.Join(", ", values.Select(v => $"'{v}'"));
                ValidationErrorThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must have only values: {valuesStr}. Current value: '{ValidatingObject.Value}'");
            }

            return CreateInstance();
        }
    }
}
