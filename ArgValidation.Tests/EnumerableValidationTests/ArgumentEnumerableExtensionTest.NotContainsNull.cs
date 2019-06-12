using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void NotContainsNull_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullValue).NotContainsNull());
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'NotContainsNull' method", exc.Message);
        }
        
        [Fact]
        public void NotContainsNull_ListWithoutNull_Ok()
        {
            object[] objs = { new object(), new object() };
            Arg.Validate(() => objs).NotContainsNull();
        }
        
        [Fact]
        public void NotContainsNull_ListContainsNull_ArgumentException()
        {
            object[] objs = { new object(), new object(), null };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objs).NotContainsNull());
            Assert.Equal($"Argument '{nameof(objs)}' contains null. Current value: ['System.Object', 'System.Object', null]", exc.Message);
        }
    }
}
