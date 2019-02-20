using System;

namespace ArgValidation
{
    internal static class ValidationContext<T>
    {
        [ThreadStatic]
        internal static string ArgumentName;

        [ThreadStatic]
        internal static bool ValidationIsDisabled;

        [ThreadStatic]
        internal static T ArgumentValue;

        internal static Argument<T> Init(T argValue, string argName, bool validationIsDisabled)
        {
            ArgumentValue = argValue;
            ArgumentName = argName;
            ValidationIsDisabled = validationIsDisabled;
            return new Argument<T>();
        }
    }
}
