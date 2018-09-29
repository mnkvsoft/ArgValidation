namespace ArgValidation.Validators
{
    public class ObjectValidator<TValue> : ValidatorBase<TValue, ObjectValidator<TValue>>
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