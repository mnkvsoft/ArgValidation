using System;
using System.Linq.Expressions;
using ArgValidation.Internal;

namespace ArgValidation
{
    /// <summary>
    /// Any check starts with a call to this class
    /// </summary>
    public static partial class Arg
    {
        /// <summary>
        /// Start validaton for an argument
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="argValue">Validated argument</param>
        /// <param name="argName">Validated argument name</param>
        /// <returns>An object on which to call validation methods</returns>
        public static Argument<T> Validate<T>(T argValue, string argName)
        {
            return new Argument<T>(argValue, argName);
        }

        /// <summary>
        /// Start validaton for an argument.
        /// WARNING. 
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="value">Validated argument</param>
        /// <returns>An object on which to call validation methods</returns>
        public static Argument<T> Validate<T>(Expression<Func<T>> value)
        {
            return ArgumentFactory.FromExpression(value);
        }
    }
}