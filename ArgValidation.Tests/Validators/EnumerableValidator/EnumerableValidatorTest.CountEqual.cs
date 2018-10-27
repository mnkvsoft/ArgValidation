using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountEqual_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => 
                Arg.Validate(() => nullValue)
                    .CountEqual(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountEqual_CountEqual_Ok()
        {
            object[] objs = new[] { new object(), new object() };
            
            Arg.Validate(() => objs)
                .CountEqual(objs.Length);
        }

        [Fact]
        public void CountEqual_CountNotEqual_ArgumentException()
        {
            object[] objsWithNotEqualCount = { new object(), new object() };
            int count = objsWithNotEqualCount.Length + 1;
            
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(() => objsWithNotEqualCount)
                    .CountEqual(count));
            
            Assert.Equal($"Argument '{nameof(objsWithNotEqualCount)}' must contains {count} elements. Current count elements: {objsWithNotEqualCount.Length}", exc.Message);
        }
    }
}
