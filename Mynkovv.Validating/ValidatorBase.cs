using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    public abstract class ValidatorBase<TValue, TInheritInstance>
    {
        protected ValidatingObject<TValue> ValidatingObject { get; }

        public abstract TInheritInstance CreateInstance();

        public ValidatorBase(ValidatingObject<TValue> validatingObject)
        {
            if (validatingObject == null)
                throw new ArgumentNullException(nameof(validatingObject));

            ValidatingObject = validatingObject;
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
                throw new ArgumentException(string.Format(ExceptionMessage.Argument.Null, ValidatingObject.Name));

            return CreateInstance();
        }

        public TInheritInstance Equal(TValue value)
        {
            if (ValidatingObject.Value != null)
            {
                if (!ValidatingObject.Value.Equals(value))
                    throw new ArgumentException(string.Format(ExceptionMessage.Argument.Equal, ValidatingObject.Name, value));
            }
            else
            {
                if(value != null)
                    throw new ArgumentException(string.Format(ExceptionMessage.Argument.Equal, ValidatingObject.Name, value));
            }

            return CreateInstance();
        }

        public TInheritInstance MoreThan(TValue value)
        {
            if (ValidatingObject.Value == null)
                throw new InvalidOperationException(string.Format(ExceptionMessage.Argument.InvalidOperation.CannotCompareNullArgument, ValidatingObject.Name));

            if(value == null)
                throw new InvalidOperationException(string.Format(ExceptionMessage.Argument.InvalidOperation.CannotCompareNullValue, ValidatingObject.Name));

            IComparable<TValue> comparable = ValidatingObject.Value as IComparable<TValue>;
            if (comparable == null)
                throw new InvalidOperationException(string.Format(ExceptionMessage.Argument.InvalidOperation.ArgumentMustBeImplementInterface, typeof(IComparable<TValue>)));

            if(comparable.CompareTo(value) <= 0)
                throw new ArgumentException(string.Format(ExceptionMessage.Argument.MoreThan, ValidatingObject.Name, value));

            return CreateInstance();
        }
    }
}
