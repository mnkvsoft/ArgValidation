using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        public static string NullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NullOrEmpty().Value;
        }
        
        public static string NullOrEmpty(string argValue, string argName)
        {
            return Validate(argValue, argName).NullOrEmpty().Value;
        }
        
        public static string NotNullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrEmpty().Value;
        }
        
        public static string NotNullOrEmpty(string argValue, string argName)
        {
            return Validate(argValue, argName).NotNullOrEmpty().Value;
        }
        
        public static string NullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NullOrWhitespace().Value;
        }
        
        public static string NullOrWhitespace(string argValue, string argName)
        {
            return Validate(argValue, argName).NullOrWhitespace().Value;
        }
        
        public static string NotNullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrWhitespace().Value;
        }
        
        public static string NotNullOrWhitespace(string argValue, string argName)
        {
            return Validate(argValue, argName).NotNullOrWhitespace().Value;
        }
    }
}