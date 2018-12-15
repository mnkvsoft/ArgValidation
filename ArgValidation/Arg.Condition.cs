using System;
using System.Linq.Expressions;
using ArgValidation.Internal;

namespace ArgValidation
{
    public static partial class Arg
    {
        public static Argument<T> IfNotNull<T>(T? argValue, string argName) where T : struct
        {
            if (!argValue.HasValue)
                return new Argument<T>(default(T), argName, validationIsDisabled: true);

            return new Argument<T>(argValue.Value, argName);
        }

        public static Argument<T> IfNotNull<T>(Expression<Func<T?>> value) where T : struct
        {
            T? argValue = ExpressionHelper.GetArgumentValue(value);
            string argName = ExpressionHelper.GetArgumentName(value);

            if (!argValue.HasValue)
                return new Argument<T>(default(T), argName, validationIsDisabled: true);

            return new Argument<T>(argValue.Value, argName);
        }

        public static Argument<T> IfNotNull<T>(T argValue, string argName) where T : class
        {
            if (argValue == null)
                return new Argument<T>(value: null, name: argName, validationIsDisabled: true);

            return new Argument<T>(argValue, argName);
        }

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