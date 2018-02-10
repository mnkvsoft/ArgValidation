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
    }
}
