using System;
using System.Linq.Expressions;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        public class SimpleStringMethodsExpressionThreeTest : StringSimpleMethodsTestBase
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
    
    public class SimpleStringMethodsNameOfTest : StringSimpleMethodsTestBase
    {
        protected override void RunNullOrWhitespace(Expression<Func<string>> value)
        {
            var arg = Arg.Validate(value);
            Arg.Validate(arg.Value, arg.Name).NullOrWhitespace();
        }

        protected override void RunNotNullOrWhitespace(Expression<Func<string>> value)
        {
            var arg = Arg.Validate(value);
            Arg.Validate(arg.Value, arg.Name).NotNullOrWhitespace();
        }

        protected override void RunNullOrEmpty(Expression<Func<string>> value)
        {
            var arg = Arg.Validate(value);
            Arg.Validate(arg.Value, arg.Name).NullOrEmpty();
        }

        protected override void RunNotNullOrEmpty(Expression<Func<string>> value)
        {
            var arg = Arg.Validate(value);
            Arg.Validate(arg.Value, arg.Name).NotNullOrEmpty();
        }
    }
}