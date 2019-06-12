using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        /*
        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentNullException"/> if the argument is <c>null</c>
        /// </para>
        /// <para>
        /// Overload for the <see cref="Nullable{T}"/> type is specifically not defined, because this type is used specifically 
        /// when the argument should be able to have the value null
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is <c>null</c></exception>
        public static T NotNull<T>(Expression<Func<T>> value) where T : class
        {
            return Validate(value).NotNull().Value;
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentNullException"/> if the argument is <c>null</c>
        /// </para>
        /// <para>
        /// Overload for the <see cref="Nullable{T}"/> type is specifically not defined, because this type is used specifically 
        /// when the argument should be able to have the value null
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is <c>null</c></exception>
        public static void NotNull<T1, T2>(
            T1 argValue1, string argName1,
            T2 argValue2, string argName2)
            where T1 : class
            where T2 : class
        {
        }
        */
    }
}