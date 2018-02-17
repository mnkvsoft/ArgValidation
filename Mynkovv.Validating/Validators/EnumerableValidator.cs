using Mynkovv.Validating.ExceptionThrowers;
using System;
using System.Collections.Generic;
using System.Linq;

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
            InvalidMethodArgumentThrower.IfNullForCount(ValidatingObject);

            int currentCount = ValidatingObject.Value.Count();
            if (!(currentCount == count))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must contains {count} elements. Current count elements: {currentCount}");

            return CreateInstance();
        }

        public EnumerableValidator<T> CountNotEqual(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(ValidatingObject);

            int currentCount = ValidatingObject.Value.Count();
            if (!(currentCount != count))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' not must contains {count} elements");

            return this;
        }

        public EnumerableValidator<T> CountMoreThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(ValidatingObject);

            int currentCount = ValidatingObject.Value.Count();
            if (!(currentCount > count))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must contains more than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> CountMoreOrEqualThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(ValidatingObject);

            int currentCount = ValidatingObject.Value.Count();
            if (!(currentCount >= count))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must contains more or equal than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> CountLessThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(ValidatingObject);

            int currentCount = ValidatingObject.Value.Count();
            if (!(currentCount < count))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must contains less than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> CountLessOrEqualThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(ValidatingObject);

            int currentCount = ValidatingObject.Value.Count();
            if (!(currentCount <= count))
                ValidationErrorExceptionThrower.ArgumentException($"Object with name '{ValidatingObject.Name}' must contains less or equal than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> Contains(int count)
        {
            return this;
        }

        public EnumerableValidator<T> NotContains(int count)
        {
            return this;
        }

        public EnumerableValidator<T> Equivalent(IEnumerable<T> otherEnumerable)
        {
            return this;
        }

        public EnumerableValidator<T> EquivalentWithoutOrder(IEnumerable<T> otherEnumerable)
        {
            return this;
        }
    }
}
