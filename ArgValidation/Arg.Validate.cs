using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        public static Argument<T> Validate<T>(T argValue, string argName)
        {
            return new Argument<T>(argValue, argName);
        }
        
        public static Argument<T> Validate<T>(Expression<Func<T>> value)
        {
            return ArgumentFactory.FromExpression(value);
        }
    }
}