using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    public abstract class ValidatorBase<TValue, TInheritInstance>
    {
        private ValidatingObject<TValue> ValidatingObject { get; }

        //protected TValue Value => ValidatingObject.Value;
        //protected string Name => ValidatingObject.Name;
        private ExceptionMessage<TValue> ExceptionMessage { get; }

        public abstract TInheritInstance CreateInstance();

        public ValidatorBase(ValidatingObject<TValue> validatingObject)
        {
            if (validatingObject == null)
                throw new ArgumentNullException(nameof(validatingObject));

            ValidatingObject = validatingObject;
            ExceptionMessage = new ExceptionMessage<TValue>
            {
                ValidatingObject = validatingObject
            };
        }

        public TInheritInstance Default()
        {
            if (!object.Equals(ValidatingObject.Value, default(TValue)))
                ThrowArgumentException(ExceptionMessage.Default());

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
                ThrowArgumentException(ExceptionMessage.Null());

            return CreateInstance();
        }

        public TInheritInstance Equal(TValue value)
        {
            if (ValidatingObject.Value != null)
            {
                if (!ValidatingObject.Value.Equals(value))
                    ThrowArgumentException(ExceptionMessage.Equal(value));
            }
            else
            {
                if(value != null)
                    ThrowArgumentException(ExceptionMessage.Equal(value));
            }

            return CreateInstance();
        }

        public TInheritInstance MoreThan(TValue value)
        {
            if (ValidatingObject.Value == null)
                throw new InvalidOperationException(string.Format(InvalidOperation.CannotCompareNullArgument, ValidatingObject.Name));

            if(value == null)
                throw new InvalidOperationException(string.Format(InvalidOperation.CannotCompareNullValue, ValidatingObject.Name));

            IComparable<TValue> comparable = ValidatingObject.Value as IComparable<TValue>;
            if (comparable == null)
                throw new InvalidOperationException(string.Format(InvalidOperation.ArgumentMustBeImplementInterface, typeof(IComparable<TValue>)));

            if (comparable.CompareTo(value) <= 0)
                ThrowArgumentException(ExceptionMessage.MoreThan(value));

            return CreateInstance();
        }

        private void ThrowArgumentException(string message = "")
        {
            throw new ArgumentException(message);
        }
    }
}
