using System;

namespace ArgValidation
{
    /// <summary>
    /// The main class for the library. 
    /// All necessary extensions are implemented for it to check the argument and control the validation flow
    /// </summary>
    public struct Argument<T>
    {
        /// <summary>
        /// Argument name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Argument value
        /// </summary>
        public  T Value { get; }

        private ValidationOption ValidationOption { get; }

        internal Type CustomExceptionType { get; private set; }

        internal Argument(T value, string name, bool validationIsDisabled = false)
        {
            Name = name;
            Value = value;
            ValidationOption = validationIsDisabled ? ValidationOption.NoValidation : ValidationOption.None;
            CustomExceptionType = null;
        }

        internal bool ValidationIsDisabled() => ValidationOption == ValidationOption.NoValidation;

        /// <summary>
        /// Set custom exception type. All the following failed checks will throw an <typeparamref name="TException"/>
        /// </summary>
        /// <typeparam name="TException">Custom type of exception to be thrown</typeparam>
        public Argument<T> With<TException>() where TException : Exception
        {
            CustomExceptionType = typeof(TException);
            return this;
        }

        /// <summary>
        /// Returns the value of the argument being validated
        /// </summary>
        public static implicit operator T(Argument<T> argument)
        {
            return argument.Value;
        }
    }
}
