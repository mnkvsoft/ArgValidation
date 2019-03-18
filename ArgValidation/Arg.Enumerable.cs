using System;
using System.Collections;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is more than 0</exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static TEnumerable Empty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).Empty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is more than 0</exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static TEnumerable Empty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).Empty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is equals 0</exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static TEnumerable NotEmpty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).NotEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if element count is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if element count is equals 0</exception>
        /// <exception cref="ArgValidationException">Throws if argument is <c>null</c></exception>
        public static TEnumerable NotEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NotEmpty().Value;
        }


        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or elements count is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or elements count is equals 0</exception>
        public static TEnumerable NotNullOrEmpty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).NotNullOrEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is <c>null</c> or elements count is equals 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is <c>null</c> or elements count is equals 0</exception>
        public static TEnumerable NotNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NotNullOrEmpty().Value;
        }


        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or elements count is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or elements count is more than 0</exception>
        public static TEnumerable NullOrEmpty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).NullOrEmpty().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if argument is not <c>null</c> or elements count is more than 0
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not <c>null</c> or elements count is more than 0</exception>
        public static TEnumerable NullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NullOrEmpty().Value;
        }
    }
}