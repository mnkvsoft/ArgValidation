using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    public abstract class ValidatorBase<TValue, TInheritInstance>
    {
        private ValidatingObject<TValue> ValidatingObject { get; }

        protected abstract TInheritInstance CreateInstance();

        public ValidatorBase(ValidatingObject<TValue> validatingObject)
        {
            ValidatingObject = validatingObject ?? throw new ArgumentNullException(nameof(validatingObject));
        }

        public TInheritInstance Default()
        {
            if (!ConditionChecker.IsDefault(ValidatingObject.Value))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be default value. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotDefault()
        {
            throw new NotImplementedException();
        }

        public TInheritInstance Null()
        {
            if (!ConditionChecker.IsNull(ValidatingObject.Value))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be null. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotNull()
        {
            if (ConditionChecker.IsNull(ValidatingObject.Value))
                throw new ArgumentNullException(ValidatingObject.Name);

            return CreateInstance();
        }

        public TInheritInstance Equal(TValue value)
        {
            if (!ConditionChecker.IsEqual(ValidatingObject.Value, value))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be equal '{value}'");

            return CreateInstance();
        }

        public TInheritInstance NotEqual()
        {
            throw new NotImplementedException();
        }

        public TInheritInstance MoreThan(TValue value)
        {
            if (!ConditionChecker.MoreThan(ValidatingObject.Value, value))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be more than '{value}'");

            return CreateInstance();
        }

        public TInheritInstance MoreOrEqualThan()
        {
            throw new NotImplementedException();
        }

        public TInheritInstance LessThan()
        {
            throw new NotImplementedException();
        }

        public TInheritInstance LessOrEqualThan()
        {
            throw new NotImplementedException();
        }

        public TInheritInstance InRange()
        {
            throw new NotImplementedException();
        }
    }
}
