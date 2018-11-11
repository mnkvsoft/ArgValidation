using ArgValidation.Internal.Utils;
using System;
using System.Collections;

namespace ArgValidation.Internal.ExceptionThrowers
{
    internal static class InvalidMethodArgumentThrower
    {
        public static void IfNullForComparable<T>(T arg, string argName)
        {
            if (arg == null)
                ThrowException($"Argument '{argName}' is null. Сan not compare null object");
        }

        public static void IfArgumentIsNullForRange<T>(T arg, string argName)
        {
            if (arg == null)
                ThrowException($"Argument '{argName}' is null. Cannot define range");
        }

        public static void IfNullForRange<T>(Argument<T> arg, T min, T max)
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Cannot define belonging to range: '{min}' - '{max}'");
        }

        public static void IfNotRange<T>(T min, T max) where T : IComparable<T>
        {
            if (min.MoreThan(max))
                ThrowException($"Argument '{nameof(min)}' cannot be more than '{nameof(max)}'. Cannot define range");
        }

        public static void IfArgumentIsNullForOnlyValues<T>(T[] values, string argName)
        {
            if (values == null)
                ThrowException($"Argument '{argName}' is null. There are no values to compare");
        }

        public static void IfNullForCount<T>(Argument<T> argument)
        {
            if (argument.Value == null)
                ThrowException(
                    $"Argument '{argument.Name}' is null. Сan not get count elements from null object");
        }
        
        public static void IfNullForLength(Argument<string> arg, string operationName)
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Сan not execute '{operationName}' operation");
        }

        public static void IfNullForContains<T>(Argument<T> arg)
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Сan not execute 'Contains' operation");
        }
        
        public static void IfNullForNotContains<T>(Argument<T> arg)
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Сan not execute 'NotContains' operation");
        }
		
        public static void IfNullForEmpty<TEnumerable>(Argument<TEnumerable> arg) where TEnumerable : IEnumerable
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Сan not execute 'Empty' operation");
        }

        public static void IfNullForNotEmpty<TEnumerable>(Argument<TEnumerable> arg) where TEnumerable : IEnumerable
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Сan not execute 'NotEmpty' operation");
        }

        private static void ThrowException(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}