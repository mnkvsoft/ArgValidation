using System;

namespace Mynkovv.Validating.ExceptionThrowers
{
    public static class FrameworkErrorThrower
    {
        public static void ArgumentException(string message)
        {
            throw new ArgumentException(message);
        }

        internal static void ArgumentNullException(string paramName)
        {
            throw new ArgumentNullException(paramName);
        }

        internal static void ArgumentException(string message, string paramName)
        {
            throw new ArgumentException(message, paramName);
        }
    }
}
