using System;
using System.Collections.Generic;
using System.Linq;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation.Internal.ConditionCheckers
{
    internal static class ObjectConditionChecker
    {
        public static bool IsDefault<T>(T obj)
        {
            return EqualityComparer<T>.Default.Equals(obj, default(T));
        }

        public static bool IsEqual<T>(T obj1, T obj2)
        {
            return EqualityComparer<T>.Default.Equals(obj1, obj2);
        }
        
        internal static bool OnlyValues<T>(Argument<T> arg, T[] values)
        {
            InvalidMethodArgumentThrower.IfArgumentIsNullForOnlyValues(values, nameof(values));
            return values.Any(x => IsEqual(arg.Value, x));
        }
    }
}