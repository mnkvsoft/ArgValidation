namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods for validation by conditions
    /// </summary>
    public static class ArgumentConditionExtension
    {
        /// <summary>
        /// The following validation methods after calling this method will be executed only if the argument is not equal <c>null</c>
        /// </summary>
        public static Argument<T> IfNotNull<T>(this Argument<T?> arg) where T : struct
        {
            if (!arg.Value.HasValue)
                return new Argument<T>(default(T), arg.Name, validationIsDisabled: true);

            return new Argument<T>(arg.Value.Value, arg.Name);
        }

        /// <summary>
        /// The following validation methods after calling this method will be executed only if the argument is not equal <c>null</c>
        /// </summary>
        public static Argument<T> IfNotNull<T>(this Argument<T> arg) where T : class 
        {
            if (arg.Value == null)
                return new Argument<T>(value: null, name: arg.Name, validationIsDisabled: true);

            return new Argument<T>(arg.Value, arg.Name);
        }
    }
}
