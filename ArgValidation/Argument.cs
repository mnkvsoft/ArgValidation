namespace ArgValidation
{
    /// <summary>
    /// The main class for the library. 
    /// All necessary extensions are implemented for it to check the argument and control the validation flow
    /// </summary>
    public struct Argument<T>
    {
        internal T Value => ValidationContext<T>.ArgumentValue;

        internal string Name => ValidationContext<T>.ArgumentName;

        internal Argument(T value, string name, bool validationIsDisabled = false)
        {
            ValidationContext<T>.Init(value, name, validationIsDisabled);
        }

        internal bool ValidationIsDisabled() => ValidationContext<T>.ValidationIsDisabled;

        /// <summary>
        /// Returns the value of the argument being validated
        /// </summary>
        public static implicit operator T(Argument<T> argument)
        {
            return ValidationContext<T>.ArgumentValue;
        }
    }
}
