using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or length is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or length is more than 0</exception>
        public static string NullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NullOrEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or length is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or length is more than 0</exception>
        public static string NullOrEmpty(string argValue, string argName)
        {
            return Validate(argValue, argName).NullOrEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or length is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or length is equals 0</exception>
        public static string NotNullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or length is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or length is equals 0</exception>
        public static string NotNullOrEmpty(string argValue, string argName)
        {
            return Validate(argValue, argName).NotNullOrEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or argument is not contains only whitespaces
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or argument is not contains only whitespaces</exception>
        public static string NullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NullOrWhitespace().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or argument is not contains only whitespaces
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or argument is not contains only whitespaces</exception>
        public static string NullOrWhitespace(string argValue, string argName)
        {
            return Validate(argValue, argName).NullOrWhitespace().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or argument is contains only whitespaces
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or argument is contains only whitespaces</exception>
        public static string NotNullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrWhitespace().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or argument is contains only whitespaces
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or argument is contains only whitespaces</exception>
        public static string NotNullOrWhitespace(string argValue, string argName)
        {
            return Validate(argValue, argName).NotNullOrWhitespace().Value;
        }
    }
}