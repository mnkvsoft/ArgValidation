using System;

namespace ArgValidation
{
    /// <summary>
    /// Exception class generated when the argument is not validated
    /// </summary>
    public class ArgValidationException : Exception
    {
        /// <summary>
        /// Constructor with exception message
        /// </summary>
        public ArgValidationException(string message) : base(message)
        {
        }
    }
}
