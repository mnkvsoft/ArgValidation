using System;

namespace Mynkovv.Validating.ExceptionThrowers
{
    internal static class ValidationErrorExceptionThrower
    {
        public static void ArgumentOutOfRangeException(string message)
        {
            throw new ArgumentOutOfRangeException("", message);
        }

        public static void ArgumentException(string message)
        {
            throw new ArgumentException(message);
        }

        public static void ArgumentNullException(string paramName)
        {
            throw new ArgumentNullException(paramName);
        }
    }
}
