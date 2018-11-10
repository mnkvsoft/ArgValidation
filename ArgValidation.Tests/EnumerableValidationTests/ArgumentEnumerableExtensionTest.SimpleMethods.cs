using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        public class SimpleEnumerableMethodsExpressionThreeTest : EnumerableSimpleMethodsTestBase
        {
            protected override void RunNullOrEmpty<T>(Expression<Func<T>> value)
            {
                Arg.Validate(value).NullOrEmpty();
            }

            protected override void RunNotNullOrEmpty<T>(Expression<Func<T>> value)
            {
                Arg.Validate(value).NotNullOrEmpty();
            }

            protected override void RunNotEmpty<T>(Expression<Func<T>> value)
            {
                Arg.Validate(value).NotEmpty();
            }

            protected override void RunEmpty<T>(Expression<Func<T>> value)
            {
                Arg.Validate(value).Empty();
            }
        }
        
        public class SimpleEnumerableMethodsNameOfTest : EnumerableSimpleMethodsTestBase
        {
            protected override void RunNullOrEmpty<T>(Expression<Func<T>> value)
            {
                var arg = Arg.Validate(value);
                Arg.Validate(arg.Value, arg.Name).NullOrEmpty();
            }

            protected override void RunNotNullOrEmpty<T>(Expression<Func<T>> value)
            {
                var arg = Arg.Validate(value);
                Arg.Validate(arg.Value, arg.Name).NotNullOrEmpty();
            }

            protected override void RunNotEmpty<T>(Expression<Func<T>> value)
            {
                var arg = Arg.Validate(value);
                Arg.Validate(arg.Value, arg.Name).NotEmpty();
            }

            protected override void RunEmpty<T>(Expression<Func<T>> value)
            {
                var arg = Arg.Validate(value);
                Arg.Validate(arg.Value, arg.Name).Empty();
            }
        }
    }
}
