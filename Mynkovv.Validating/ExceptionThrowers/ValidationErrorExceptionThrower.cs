using System;

namespace Mynkovv.Validating.ExceptionThrowers
{
    internal static class ValidationErrorExceptionThrower
    {
        internal static void ArgumentOutOfRangeException(string message)
        {
            throw new ArgumentOutOfRangeException("", message);
        }

        internal static void ArgumentException(string message)
        {
            throw new ArgumentException(message);
        }

        internal static void ArgumentNullException(string paramName)
        {
            throw new ArgumentNullException(paramName);
        }
    }
}
