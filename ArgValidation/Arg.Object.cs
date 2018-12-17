using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        public static T Default<T>(Expression<Func<T>> value)
        {
            return Validate(value).Default().Value;
        }
        
        public static T Default<T>(T argValue, string argName)
        {
            return Validate(argValue, argName).Default().Value;
        }
        
        public static T NotDefault<T>(Expression<Func<T>> value)
        {
            return Validate(value).NotDefault().Value;
        }
        
        public static T NotDefault<T>(T argValue, string argName)
        {
            return Validate(argValue, argName).NotDefault().Value;
        }
        
        public static void Null<T>(Expression<Func<T>> value) where T : class
        {
            Validate(value).Null();
        }
        
        public static void Null<T>(T argValue, string argName) where T : class
        {
            Validate(argValue, argName).Null();
        }

        public static void Null<T>(Expression<Func<T?>> value) where T : struct
        {
            Validate(value).Null();
        }

        public static void Null<T>(T? argValue, string argName) where T : struct
        {
            Validate(argValue, argName).Null();
        }

        /// <summary>
        /// If <paramref name="arg"/> is null then throw <see cref="ArgumentNullException"/>.
        /// 
        /// Overload for the <see cref="Nullable{T}"/> type is specifically not defined, because this type is used specifically 
        /// when the argument should be able to have the value null
        /// </summary>
        public static T NotNull<T>(Expression<Func<T>> value) where T : class
        {
            return Validate(value).NotNull().Value;
        }

        /// <summary>
        /// If <paramref name="arg"/> is null then throw <see cref="ArgumentNullException"/>.
        /// 
        /// Overload for the <see cref="Nullable{T}"/> type is specifically not defined, because this type is used specifically 
        /// when the argument should be able to have the value null
        /// </summary>
        public static T NotNull<T>(T argValue, string argName) where T : class
        {
            return Validate(argValue, argName).NotNull().Value;
        }
    }
}