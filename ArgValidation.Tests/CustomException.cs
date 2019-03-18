using System;

namespace ArgValidation.Tests
{
    public class CustomException : Exception
    {
        public CustomException(string mes) : base(mes) { }
    }
}