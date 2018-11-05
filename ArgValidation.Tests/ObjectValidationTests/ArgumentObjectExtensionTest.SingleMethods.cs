using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public class StringSingleMethodsTest : ObjectSingleMethodsTestBase
    {
        protected override void RunDefault<T>(Expression<Func<T>> value)
        {
            Arg.Validate(value).Default();
        }

        protected override void RunNull<T>(Expression<Func<T>> value)
        {
            Arg.Validate(value).Null();
        }

        protected override void RunNotNull<T>(Expression<Func<T>> value)
        {
            Arg.Validate(value).NotNull();
        }
        
        protected override void RunNotDefault<T>(Expression<Func<T>> value)
        {
            Arg.Validate(value).NotDefault();
        }
        
        [Fact]
        public void Default_Normal_ArgumentNotChange()
        {
            object argValue = null;
            var argument = Arg.Validate(() => argValue).Default();
            
            Assert.Equal(argValue, argument.Value);
            Assert.Equal(nameof(argValue), argument.Name);
        }

        [Fact]
        public void NotDefault_Normal_ArgumentNotChange()
        {
            object argValue = new object();
            var argument = Arg.Validate(() => argValue).NotDefault();
            
            Assert.Equal(argValue, argument.Value);
            Assert.Equal(nameof(argValue), argument.Name);
        }
    }
}