using System;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Validators
{
    public class EnumerableValidator<T> : ValidatorBase<IEnumerable<T>, EnumerableValidator<T>>
    {
        internal EnumerableValidator(Argument<IEnumerable<T>> argument) : base(argument)
        {
        }

        protected override EnumerableValidator<T> CreateInstance()
        {
            return this;
        }

        public EnumerableValidator<T> CountEqual(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(Argument);

            int currentCount = Argument.Value.Count();
            if (currentCount != count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must contains {count} elements. Current count elements: {currentCount}");

            return CreateInstance();
        }

        public EnumerableValidator<T> CountNotEqual(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(Argument);

            int currentCount = Argument.Value.Count();
            if (currentCount == count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' not must contains {count} elements");

            return this;
        }

        public EnumerableValidator<T> CountMoreThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(Argument);

            int currentCount = Argument.Value.Count();
            if (currentCount <= count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must contains more than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> CountMoreOrEqualThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(Argument);

            int currentCount = Argument.Value.Count();
            if (currentCount < count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must contains more or equal than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> CountLessThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(Argument);

            int currentCount = Argument.Value.Count();
            if (currentCount >= count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must contains less than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> CountLessOrEqualThan(int count)
        {
            InvalidMethodArgumentThrower.IfNullForCount(Argument);

            int currentCount = Argument.Value.Count();
            if (currentCount > count)
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' must contains less or equal than {count} elements. Current count elements: {currentCount}");

            return this;
        }

        public EnumerableValidator<T> Contains(T elem)
        {
            InvalidMethodArgumentThrower.IfNullForContains(Argument);

            if (!Argument.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return this;
        }

        public EnumerableValidator<T> NotContains(T elem)
        {
            InvalidMethodArgumentThrower.IfNullForNotContains(Argument);

            if (Argument.Value.Contains(elem))
                ValidationErrorExceptionThrower.ArgumentException($"Argument '{Argument.Name}' not contains {ExceptionMessageHelper.GetStringValueForMessage(elem)} value");

            return this;
        }
    }
}
