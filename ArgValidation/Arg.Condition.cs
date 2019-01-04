using System;
using System.Linq.Expressions;
using ArgValidation.Internal;

namespace ArgValidation
{
    public static partial class Arg
    {
        /// <summary>
        /// The following validation methods after calling this method will be executed only if the argument is not equal <c>null</c>
        /// </summary>
        public static Argument<T> IfNotNull<T>(T? argValue, string argName) where T : struct
        {
            if (!argValue.HasValue)
                return new Argument<T>(default(T), argName, validationIsDisabled: true);

            return new Argument<T>(argValue.Value, argName);
        }

        /// <summary>
        /// The following validation methods after calling this method will be executed only if the argument is not equal <c>null</c>
        /// </summary>
        public static Argument<T> IfNotNull<T>(Expression<Func<T?>> value) where T : struct
        {
            T? argValue = ExpressionHelper.GetArgumentValue(value);
            string argName = ExpressionHelper.GetArgumentName(value);

            if (!argValue.HasValue)
                return new Argument<T>(default(T), argName, validationIsDisabled: true);

            return new Argument<T>(argValue.Value, argName);
        }

        /// <summary>
        /// The following validation methods after calling this method will be executed only if the argument is not equal <c>null</c>
        /// </summary>
        public static Argument<T> IfNotNull<T>(T argValue, string argName) where T : class
        {
            if (argValue == null)
                return new Argument<T>(value: null, name: argName, validationIsDisabled: true);

            return new Argument<T>(argValue, argName);
        }

        /// <summary>
        /// The following validation methods after calling this method will be executed only if the argument is not equal <c>null</c>
        /// </summary>
        public static Argument<T> IfNotNull<T>(Expression<Func<T>> value) where T : class
        {
            T argValue = ExpressionHelper.GetArgumentValue(value);
            string argName = ExpressionHelper.GetArgumentName(value);

            if (argValue == null)
                return new Argument<T>(default(T), argName, validationIsDisabled: true);

            return new Argument<T>(argValue, argName);
        }
    }
}