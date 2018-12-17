namespace ArgValidation
{
    public struct Argument<T>
    {
        internal string Name { get; }
        internal T Value { get; }

        private ValidationOption ValidationOption { get; } 

        internal Argument(T value, string name, bool validationIsDisabled = false)
        {
            Name = name;
            Value = value;
            ValidationOption = validationIsDisabled ? ValidationOption.NoValidation : ValidationOption.None;
        }

        internal bool ValidationIsDisabled() => ValidationOption == ValidationOption.NoValidation;

        public static implicit operator T(Argument<T> argument)
        {
            return argument.Value;
        }
    }
}
