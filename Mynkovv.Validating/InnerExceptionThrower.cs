using System;

namespace Mynkovv.Validating
{
    internal static class InnerExceptionThrower
    {
        internal static void IfArgumentIsNull<T>(T arg, string argName)
        {
            if (object.ReferenceEquals(null, arg))
                ThrowExc($"Argument '{argName}' is null. Сannot compare null object");
        }

        internal static void IfNullForComparable<T>(ValidatingObject<T> arg1)
        {
            if (arg1.Value == null)
                ThrowExc($"Object with name '{arg1.Name}' is null. Сannot compare null object");
        }

        internal static void IfNotImplementIComparable<T>(ValidatingObject<T> validatingObject)
        {
            if (!(validatingObject.Value is IComparable<T>))
                ThrowExc($"Object with name '{validatingObject.Name}' not implement interface '{typeof(IComparable<T>)}'. Сannot compare objects");
        }

        internal static void IfArgumentIsNullForRange<TValue>(TValue arg, string argName)
        {
            if (object.ReferenceEquals(arg, null))
                ThrowExc($"Argument '{argName}' is null. Cannot define range");
        }

        internal static void IfNullForRange<T>(ValidatingObject<T> validatingObject, T min, T max)
        {
            if (object.ReferenceEquals(validatingObject.Value, null))
                ThrowExc($"Object with name '{validatingObject.Name}' is null. Cannot define belonging to range: '{min}' - '{max}'");
        }

        internal static void IfNotRange<T>(T min, T max)
        {
            if (min.CompareWith(max) > 0)
                ThrowExc($"Argument '{nameof(min)}' cannot be more than '{nameof(max)}'. Cannot define range");
        }

        internal static void IfValidatingObjectNameIsEmpty(string validatingObjectName)
        {
            if (string.IsNullOrWhiteSpace(validatingObjectName))
                ThrowExc($"Validating object name cannot be empty");
        }

        private static void ThrowExc(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}
