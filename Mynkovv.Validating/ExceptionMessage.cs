using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    internal sealed class ExceptionMessage
    {
        public sealed class Argument
        {
            public const string Null = "Argument '{0}' must be null";
            public const string Equal = "Argument '{0}' must be equal '{1}'";
            public const string MoreThan = "Argument '{0}' must be more than '{1}'";

            public sealed class InvalidOperation
            {
                public const string CannotCompareNullArgument = "Сannot compare null argument";
                public const string CannotCompareNullValue = "Сannot compare with null value";
                public const string ArgumentMustBeImplementInterface = "Argument must be implement interface '{0}'";
            }
        }
    }
}
