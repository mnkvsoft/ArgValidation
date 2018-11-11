using System;
using System.Collections;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        public static TEnumerable Empty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).Empty().Value;
        }
        
        public static TEnumerable Empty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).Empty().Value;
        }
        
        
        public static TEnumerable NotEmpty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).NotEmpty().Value;
        }
        
        public static TEnumerable NotEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NotEmpty().Value;
        }
        
        
        public static TEnumerable NotNullOrEmpty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).NotNullOrEmpty().Value;
        }
        
        public static TEnumerable NotNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NotNullOrEmpty().Value;
        }
        
        
        public static TEnumerable NullOrEmpty<TEnumerable>(TEnumerable argValue, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(argValue, argName).NullOrEmpty().Value;
        }
        
        public static TEnumerable NullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NullOrEmpty().Value;
        }
    }
}