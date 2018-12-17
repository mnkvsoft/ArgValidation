using System;

namespace ArgValidation
{
    public static class ArgumentConditionExtension
    {
        public static Argument<T> IfNotNull<T>(this Argument<T?> arg) where T : struct
        {
            if (!arg.Value.HasValue)
                return new Argument<T>(default(T), arg.Name, validationIsDisabled: true);

            return new Argument<T>(arg.Value.Value, arg.Name);
        }

        public static Argument<T> IfNotNull<T>(this Argument<T> arg) where T : class 
        {
            if (arg.Value == null)
                return new Argument<T>(value: null, name: arg.Name, validationIsDisabled: true);

            return new Argument<T>(arg.Value, arg.Name);
        }
    }
}
