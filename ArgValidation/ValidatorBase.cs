using System;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;
using ArgValidation.Internal.Reflection;

namespace ArgValidation
{
    public abstract class ValidatorBase<T, TInheritInstance>
    {
        protected Argument<T> Argument { get; }

        protected abstract TInheritInstance CreateInstance();

        internal ValidatorBase(Argument<T> argument)
        {
            if (argument.IsNotInitialized())
                throw new ArgumentException("Argument must be initialized", nameof(argument));

            Argument = argument;
        }

        public TInheritInstance Default()
        {
            if (!ConditionChecker.IsDefault(Argument.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be default value. Current value: '{Argument.Value}'");
            return CreateInstance();
        }

        public TInheritInstance NotDefault()
        {
            if (ConditionChecker.IsDefault(Argument.Value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be not default value");

            return CreateInstance();
        }

        public TInheritInstance Null()
        {
            if (Argument.Value != null)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be null. Current value: '{Argument.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotNull()
        {
            if (Argument.Value == null)
                ValidationErrorExceptionThrower.ArgumentNullException(Argument.Name);

            return CreateInstance();
        }

        public TInheritInstance Equal(T value)
        {
            if (!ConditionChecker.IsEqual(Argument.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be equal '{value}'. Current value: '{Argument.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotEqual(T value)
        {
            if (ConditionChecker.IsEqual(Argument.Value, value))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must be not equal '{value}'");

            return CreateInstance();
        }
        
        
        public TInheritInstance OnlyValues(params T[] values)
        {
            if (!ConditionChecker.OnlyValues(Argument, values))
            {
                string valuesStr = string.Join(", ", values.Select(v => $"'{v}'"));
                ValidationErrorExceptionThrower.ArgumentException(
                    $"Argument '{Argument.Name}' must have only values: {valuesStr}. Current value: '{Argument.Value}'");
            }

            return CreateInstance();
        }
    }
}
