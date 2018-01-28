using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating.Validators
{
    public sealed class StringValidator : ValidatorBase<string, StringValidator>
    {
        internal StringValidator(ValidatingObject<string> validatingObject) : base(validatingObject)
        {
        }

        protected override StringValidator CreateInstance()
        {
            return this;
        }

        public StringValidator NullOrEmpty()
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator NotNullOrEmpty()
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator NotNullOrWhitespace()
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator LengthEqual(int value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator LengthMoreThan(int value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator LengthMoreOrEqualThan(int value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator LengthLessThan(int value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator LengthLessOrEqualThan(int value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }

        public StringValidator Contains(string value)
        {
            throw new NotImplementedException();

            return CreateInstance();
        }
    }
}
