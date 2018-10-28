using System;
using System.Linq.Expressions;
using ArgValidation.Tests.StringValidationTests.SingleMethodsTestBase;

namespace ArgValidation.Tests.StringValidationTests.ArgumentStringExtensionTest
{
    public class SingleMethods : StringSingleMethodsTestBase
    {
        protected override void RunNullOrWhitespace(Expression<Func<string>> value)
        {
            Arg.Validate(value).NullOrWhitespace();
        }

        protected override void RunNotNullOrWhitespace(Expression<Func<string>> value)
        {
            Arg.Validate(value).NotNullOrWhitespace();
        }

        protected override void RunNullOrEmpty(Expression<Func<string>> value)
        {
            Arg.Validate(value).NullOrEmpty();
        }

        protected override void RunNotNullOrEmpty(Expression<Func<string>> value)
        {
            Arg.Validate(value).NotNullOrEmpty();
        }
    }
}