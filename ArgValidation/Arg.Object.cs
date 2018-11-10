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
        
        public static T Default<T>(T value, string argName)
        {
            return Validate(value, argName).Default().Value;
        }
        
        public static T NotDefault<T>(Expression<Func<T>> value)
        {
            return Validate(value).NotDefault().Value;
        }
        
        public static T NotDefault<T>(T value, string argName)
        {
            return Validate(value, argName).NotDefault().Value;
        }
        
        public static T Null<T>(Expression<Func<T>> value)
        {
            return Validate(value).Null().Value;
        }
        
        public static T Null<T>(T value, string argName)
        {
            return Validate(value, argName).Null().Value;
        }
        
        public static T NotNull<T>(Expression<Func<T>> value)
        {
            return Validate(value).NotNull().Value;
        }
        
        public static T NotNull<T>(T value, string argName)
        {
            return Validate(value, argName).NotNull().Value;
        }
    }
}