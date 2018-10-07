namespace ArgValidation.Validators
{
    public class ObjectValidator<T> : ValidatorBase<T, ObjectValidator<T>>
    {
        internal ObjectValidator(ValidatingObject<T> validatingObject) : base(validatingObject)
        {
        }
        
        protected override ObjectValidator<T> CreateInstance()
        {
            return this;
        }
    }
}