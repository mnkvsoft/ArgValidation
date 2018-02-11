using System;

namespace Mynkovv.Validating.ExceptionThrowers
{
    internal static class InvalidMethodArgumentThrower
    {
        internal static void IfArgumentIsNullForCompare<T>(T arg, string argName)
        {
            if (object.ReferenceEquals(arg, null))
                ThrowException($"Argument '{argName}' is null. Сannot compare null object");
        }

        internal static void IfNullForComparable<T>(ValidatingObject<T> arg1)
        {
            if (object.ReferenceEquals(arg1.Value, null))
                ThrowException($"Object with name '{arg1.Name}' is null. Сannot compare null object");
        }

        internal static void IfNotImplementIComparable<T>(ValidatingObject<T> validatingObject)
        {
            if (!(validatingObject.Value is IComparable<T>))
                ThrowException($"Object with name '{validatingObject.Name}' not implement interface '{typeof(IComparable<T>)}'. Сannot compare objects");
        }

        internal static void IfArgumentIsNullForRange<TValue>(TValue arg, string argName)
        {
            if (object.ReferenceEquals(arg, null))
                ThrowException($"Argument '{argName}' is null. Cannot define range");
        }

        internal static void IfNullForRange<T>(ValidatingObject<T> validatingObject, T min, T max)
        {
            if (object.ReferenceEquals(validatingObject.Value, null))
                ThrowException($"Object with name '{validatingObject.Name}' is null. Cannot define belonging to range: '{min}' - '{max}'");
        }

        internal static void IfNotRange<T>(T min, T max)
        {
            if (min.CompareWith(max) > 0)
                ThrowException($"Argument '{nameof(min)}' cannot be more than '{nameof(max)}'. Cannot define range");
        }

        internal static void IfArgumentIsNullForOnlyValues<TValue>(TValue[] values, string argName)
        {
            if (object.ReferenceEquals(values, null))
                ThrowException($"Argument '{argName}' is null. There are no values to compare");
        }

        internal static void IfNullForCount<T>(ValidatingObject<T> validatingObject)
        {
            if (object.ReferenceEquals(validatingObject.Value, null))
                ThrowException($"Object with name '{validatingObject.Name}' is null. Сannot get count elements from null object");
        }

        private static void ThrowException(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}
