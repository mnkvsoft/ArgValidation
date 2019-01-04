using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not default value
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not default value</exception>
        public static T Default<T>(Expression<Func<T>> value)
        {
            return Validate(value).Default().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not default value
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not default value</exception>
        public static T Default<T>(T argValue, string argName)
        {
            return Validate(argValue, argName).Default().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is default value
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is default value</exception>
        public static T NotDefault<T>(Expression<Func<T>> value)
        {
            return Validate(value).NotDefault().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is default value
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is default value</exception>
        public static T NotDefault<T>(T argValue, string argName)
        {
            return Validate(argValue, argName).NotDefault().Value;
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not <c>null</c>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not <c>null</c></exception>
        public static void Null<T>(Expression<Func<T>> value) where T : class
        {
            Validate(value).Null();
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not <c>null</c>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not <c>null</c></exception>
        public static void Null<T>(T argValue, string argName) where T : class
        {
            Validate(argValue, argName).Null();
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not <c>null</c>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not <c>null</c></exception>
        public static void Null<T>(Expression<Func<T?>> value) where T : struct
        {
            Validate(value).Null();
        }

         /// <summary>
        /// Throws <see cref="ArgumentException"/> if the argument is not <c>null</c>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not <c>null</c></exception>
        public static void Null<T>(T? argValue, string argName) where T : struct
        {
            Validate(argValue, argName).Null();
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
        public static T NotNull<T>(T argValue, string argName) where T : class
        {
            return Validate(argValue, argName).NotNull().Value;
        }
    }
}