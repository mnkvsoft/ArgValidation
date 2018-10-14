namespace ArgValidation.Validators
{
    public class ObjectValidator<T> : ValidatorBase<T, ObjectValidator<T>>
    {
        internal ObjectValidator(Argument<T> argument) : base(argument)
        {
        }
        
        protected override ObjectValidator<T> CreateInstance()
        {
            return this;
        }
    }
}