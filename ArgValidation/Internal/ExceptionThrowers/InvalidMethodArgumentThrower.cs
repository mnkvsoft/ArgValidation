using ArgValidation.Internal.Utils;
using System;

namespace ArgValidation.Internal.ExceptionThrowers
{
    internal static class InvalidMethodArgumentThrower
    {
        internal static class ForComparable
        {
            public static void IfValueIsNull<T>(T arg, string argName, string methodName)
            {
                if (arg == null)
                    ThrowException($"Argument '{argName}' of method '{methodName}' is null. Сan not compare null object");
            }

            public static void IfArgumentIsNull<T>(T arg, string argName)
            {
                if (arg == null)
                    ThrowException($"Argument '{argName}' is null. Сan not compare null object");
            }
        }

        internal static class ForRange
        {
            public static void IfValueIsNull<T>(T arg, string argName)
            {
                if (arg == null)
                    ThrowException($"Argument '{argName}' of method 'InRange' is null. Cannot define range");
            }

            public static void IfArgumentIsNull<T>(T arg, string argName)
            {
                if (arg == null)
                    ThrowException($"Argument '{argName}' is null. Cannot define range");
            }

            public static void IfArgumentIsNull<T>(Argument<T> arg, T min, T max)
            {
                if (arg.Value == null)
                    ThrowException(
                        $"Argument '{arg.Name}' is null. Cannot define belonging to range: '{min}' - '{max}'");
            }
        }

        public static void IfNotRange<T>(T min, T max) where T : IComparable<T>
        {
            if (min.MoreOrEquals(max))
                ThrowException($"Argument '{nameof(min)}' cannot be more or equals '{nameof(max)}'. Cannot define range");
        }

        public static void IfArgumentIsNullForOnlyValues<T>(T[] values, string argName)
        {
            if (values == null)
                ThrowException($"Argument '{argName}' is null. There are no values to compare");
        }

        public static void IfArgumentIsNullForCount<T>(Argument<T> argument)
        {
            if (argument.Value == null)
                ThrowException(
                    $"Argument '{argument.Name}' is null. Сan not get count elements from null object");
        }
        
        public static void IfArgumentIsNull<T>(Argument<T> arg, string methodName)
        {
            if (arg.Value == null)
                ThrowException(
                    $"Argument '{arg.Name}' is null. Сan not execute '{methodName}' method");
        }

        private static void ThrowException(string message)
        {
            throw new InvalidOperationException(message);
        }
    }
}