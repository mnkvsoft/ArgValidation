using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    internal sealed class ExceptionMessage<TValue>
    {
        public ValidatingObject<TValue> ValidatingObject { get; set; }

        public string Null()
        {
            return $"Argument '{ValidatingObject.Name}' must be null";
        }

        public string Equal(TValue value)
        {
            return $"Argument '{ValidatingObject.Name}' must be equal '{value}'";
        }

        public string MoreThan(TValue value)
        {
            return $"Argument '{ValidatingObject.Name}' must be more than '{value}'";
        }

        public string Default()
        {
            return $"Argument '{ValidatingObject.Name}' must be default value. Current value: '{ValidatingObject.Value}'";
        }

        

        public sealed class Argument<TValue>
        {
            private ValidatingObject<TValue> ValidatingObject { get; set; }

            public string Null()
            {
                return $"Argument '{ValidatingObject.Name}' must be null";
            }

            public string Equal(string value)
            {
                return $"Argument '{ValidatingObject.Name}' must be equal '{value}'";
            }

            public string MoreThan(string value)
            {
                return $"Argument '{ValidatingObject.Name}' must be more than '{value}'";
            }

            public string Default()
            {
                return $"Argument '{ValidatingObject.Name}' must be default value. Current value: '{ValidatingObject.Value}'";
            }

            //public const string Equal = "Argument '{0}' must be equal '{1}'";
            //public const string MoreThan = "Argument '{0}' must be more than '{1}'";
            //public const string Default = "Argument '{0}' must be default value. Current value: '{1}'";



            
        }
    }

    internal sealed class InvalidOperation
    {
        public const string CannotCompareNullArgument = "Сannot compare null argument";
        public const string CannotCompareNullValue = "Сannot compare with null value";
        public const string ArgumentMustBeImplementInterface = "Argument must be implement interface '{0}'";
    }
}
