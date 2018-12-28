using System;

namespace ArgValidation
{
    public class ArgValidationException : Exception
    {
        public ArgValidationException(string message) : base(message)
        {
        }
    }
}
