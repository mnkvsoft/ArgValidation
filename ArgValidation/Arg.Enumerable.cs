using System;
using System.Collections;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        public static TEnumerable Empty<TEnumerable>(TEnumerable value, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(value, argName).Empty().Value;
        }
        
        public static TEnumerable Empty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).Empty().Value;
        }
        
        
        public static TEnumerable NotEmpty<TEnumerable>(TEnumerable value, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(value, argName).NotEmpty().Value;
        }
        
        public static TEnumerable NotEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NotEmpty().Value;
        }
        
        
        public static TEnumerable NotNullOrEmpty<TEnumerable>(TEnumerable value, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(value, argName).NotNullOrEmpty().Value;
        }
        
        public static TEnumerable NotNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NotNullOrEmpty().Value;
        }
        
        
        public static TEnumerable NullOrEmpty<TEnumerable>(TEnumerable value, string argName)
            where TEnumerable : IEnumerable
        {
            return Validate(value, argName).NullOrEmpty().Value;
        }
        
        public static TEnumerable NullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable
        {
            return Validate(value).NullOrEmpty().Value;
        }
    }
}