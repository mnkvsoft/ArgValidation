using System;
using System.Collections.Generic;

namespace ArgValidation.ExceptionThrowers
{
    internal static class InvalidMethodArgumentThrower
    {
        public static void IfArgumentIsNullForComparable<T>(T arg, string argName)
        {
            if (arg.IsNull())
                ThrowException($"Argument '{argName}' is null. Сan not compare null object");
        }

        public static void IfNullForComparable<T>(ValidatingObject<T> arg1)
        {
            if (arg1.Value.IsNull())
                ThrowException($"Object with name '{arg1.Name}' is null. Сan not compare null object");
        }

        public static void IfNotImplementIComparable<T>(ValidatingObject<T> validatingObject)
        {
            if (!(validatingObject.Value is IComparable<T>))
                ThrowException($"Object with name '{validatingObject.Name}' not implement interface '{typeof(IComparable<T>)}'. Сan not compare objects");
        }

        public static void IfArgumentIsNullForRange<TValue>(TValue arg, string argName)
        {
            if (arg.IsNull())
                ThrowException($"Argument '{argName}' is null. Cannot define range");
        }

        public static void IfNullForRange<T>(ValidatingObject<T> validatingObject, T min, T max)
        {
            if (validatingObject.Value.IsNull())
                ThrowException($"Object with name '{validatingObject.Name}' is null. Cannot define belonging to range: '{min}' - '{max}'");
        }

        public static void IfNotRange<T>(T min, T max)
        {
            if (min.CompareWith(max) > 0)
                ThrowException($"Argument '{nameof(min)}' cannot be more than '{nameof(max)}'. Cannot define range");
        }

        public static void IfArgumentIsNullForOnlyValues<TValue>(TValue[] values, string argName)
        {
            if (values.IsNull())
                ThrowException($"Argument '{argName}' is null. There are no values to compare");
        }

        public static void IfNullForCount<T>(ValidatingObject<T> validatingObject)
        {
            if (object.ReferenceEquals(validatingObject.Value, null))
                ThrowException($"Object with name '{validatingObject.Name}' is null. Сan not get count elements from null object");
        }

        public static void IfNullForContains<T>(ValidatingObject<IEnumerable<T>> validatingObject)
        {
            if (object.ReferenceEquals(validatingObject.Value, null))
                ThrowException($"Object with name '{validatingObject.Name}' is null. Сan not execute 'Contains' operation");
        }

        private static void ThrowException(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}
