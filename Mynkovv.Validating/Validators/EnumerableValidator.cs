using System;
using System.Collections.Generic;

namespace Mynkovv.Validating.Validators
{
    public class EnumerableValidator<T> : ValidatorBase<IEnumerable<T>, EnumerableValidator<T>>
    {
        internal EnumerableValidator(ValidatingObject<IEnumerable<T>> validatingObject) : base(validatingObject)
        {
        }

        protected override EnumerableValidator<T> CreateInstance()
        {
            return this;
        }

        public EnumerableValidator<T> CountEqual(int count)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public EnumerableValidator<T> CountNotEqual(int count)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public EnumerableValidator<T> CountMoreThan(int count)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public EnumerableValidator<T> CountMoreOrEqualThan(int count)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public EnumerableValidator<T> CountLessThan(int count)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public EnumerableValidator<T> CountLessOrEqualThan(int count)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }
    }
}
