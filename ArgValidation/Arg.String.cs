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
        
        public static string NullOrEmpty(string value, string argName)
        {
            return Validate(value, argName).NullOrEmpty().Value;
        }
        
        public static string NotNullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrEmpty().Value;
        }
        
        public static string NotNullOrEmpty(string value, string argName)
        {
            return Validate(value, argName).NotNullOrEmpty().Value;
        }
        
        public static string NullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NullOrWhitespace().Value;
        }
        
        public static string NullOrWhitespace(string value, string argName)
        {
            return Validate(value, argName).NullOrWhitespace().Value;
        }
        
        public static string NotNullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrWhitespace().Value;
        }
        
        public static string NotNullOrWhitespace(string value, string argName)
        {
            return Validate(value, argName).NotNullOrWhitespace().Value;
        }
    }
}