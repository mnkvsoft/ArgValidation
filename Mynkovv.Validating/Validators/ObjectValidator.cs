namespace Mynkovv.Validating.Validators
{
    public sealed class ObjectValidator<TValue> : ValidatorBase<TValue, ObjectValidator<TValue>>
    {
        internal ObjectValidator(ValidatingObject<TValue> validatingObject) : base(validatingObject)
        {
        }

        protected override ObjectValidator<TValue> CreateInstance()
        {
            return this;
        }
    }
}
