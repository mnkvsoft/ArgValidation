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
            if (!object.Equals(ValidatingObject.Value, default(TValue)))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be default value. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance NotNull()
        {
            if (object.ReferenceEquals(ValidatingObject.Value, null))
                throw new ArgumentNullException(ValidatingObject.Name);

            return CreateInstance();
        }

        public TInheritInstance Null()
        {
            if (!object.ReferenceEquals(ValidatingObject.Value, null))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be null. Current value: '{ValidatingObject.Value}'");

            return CreateInstance();
        }

        public TInheritInstance Equal(TValue value)
        {
            if (!object.Equals(ValidatingObject.Value, value))
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be equal '{value}'");

            return CreateInstance();
        }

        public TInheritInstance MoreThan(TValue value)
        {
            if (ValidatingObject.Value == null)
                throw new InvalidOperationException("Сannot compare null argument");

            if(value == null)
                throw new InvalidOperationException("Сannot compare with null value");

            IComparable<TValue> comparable = ValidatingObject.Value as IComparable<TValue>;
            if (comparable == null)
                throw new InvalidOperationException($"Argument must be implement interface '{typeof(IComparable<TValue>)}'");

            if (comparable.CompareTo(value) <= 0)
                throw new ArgumentException($"Object with name '{ValidatingObject.Name}' must be more than '{value}'");

            return CreateInstance();
        }
    }
}
