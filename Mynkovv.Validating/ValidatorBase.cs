using Mynkovv.Validating.ExceptionThrowers;
using Mynkovv.Validating.Reflection;
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
                throw new ArgumentNullException(nameof(validatingObject));

            ValidatingObject = validatingObject;
        }

        # region Default

        public TInheritInstance Default()
        {
            return Default(() => 
                new ArgumentException($"Object with name '{ValidatingObject.Name}' must be default value. Current value: '{ValidatingObject.Value}'"));
        }

        public TInheritInstance Default<TException>(string message) where TException : Exception
        {
            return Default(() => ReflectionObjectCreator.InvokeConstructor<TException>(
                    new ConstructorParameter(
                        name: "message",
                        value: message,
                        parameterType: typeof(string))
                    ));
        }

        public TInheritInstance Default<TException>(Func<TException> createExceptionFunc) where TException : Exception
        {
            if (!ConditionChecker.IsDefault(ValidatingObject.Value))
                throw createExceptionFunc();

            return CreateInstance();
        }

        # endregion

        public TInheritInstance NotDefault()
        {
            if (ConditionChecker.IsDefault(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be not default value");

            return CreateInstance();
        }

        public TInheritInstance Null()
        {
            if (!ConditionChecker.IsNull(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be null. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotNull()
        {
            if (ConditionChecker.IsNull(ValidatingObject.Value))
                ValidationErrorExceptionThrower.ArgumentNullException(ValidatingObject.Name);

            return CreateInstance();
        }

        public TInheritInstance Equal(TValue value)
        {
            if (!ConditionChecker.IsEqual(ValidatingObject.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be equal '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotEqual(TValue value)
        {
            if (ConditionChecker.IsEqual(ValidatingObject.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must be not equal '{value}'");

            return CreateInstance();
        }

        public TInheritInstance MoreThan(TValue value)
        {
            if (!ConditionChecker.MoreThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be more than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance MoreOrEqualThan(TValue value)
        {
            if (!ConditionChecker.MoreOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be more or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance LessThan(TValue value)
        {
            if (!ConditionChecker.LessThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be less than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance LessOrEqualThan(TValue value)
        {
            if (!ConditionChecker.LessOrEqualThan(ValidatingObject, value))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be less or equal than '{value}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance InRange(TValue min, TValue max)
        {
            if (!ConditionChecker.InRange(ValidatingObject, min, max))
                ValidationErrorExceptionThrower.ArgumentOutOfRangeException($"Object with name '{ValidatingObject.Name}' must be in range from '{min}' to '{max}'. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance OnlyValues(params TValue[] values)
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
