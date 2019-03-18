using System;

namespace ArgValidation.Internal.ExceptionThrowers
{
    internal static class ValidationErrorExceptionThrower
    {
        public static void ArgumentOutOfRangeException<T>(Argument<T> arg, string message)
        {
            if (arg.CustomExceptionType != null)
                throw (Exception)Activator.CreateInstance(arg.CustomExceptionType, message);

            throw new ArgumentOutOfRangeException("", message);
        }

        public static void ArgumentException<T>(Argument<T> arg, string message)
        {
            if (arg.CustomExceptionType != null)
                throw (Exception)Activator.CreateInstance(arg.CustomExceptionType, message);

            throw new ArgumentException(message);
        }

        public static void ArgumentNullException<T>(Argument<T> arg)
        {
            if (arg.CustomExceptionType != null)
                throw (Exception)Activator.CreateInstance(arg.CustomExceptionType, $"Argument '{arg.Name}' is null");

            throw new ArgumentNullException(arg.Name);
        }
    }
}
