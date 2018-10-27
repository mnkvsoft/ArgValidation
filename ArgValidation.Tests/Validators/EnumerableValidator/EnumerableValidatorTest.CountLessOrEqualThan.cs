using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountLessOrEqualThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => 
                Arg.Validate(() => nullValue)
                    .CountLessOrEqualThan(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountLessOrEqualThan_CountEqual_Ok()
        {
            object[] objsWithEqualCount = { new object(), new object() };
            int count = objsWithEqualCount.Length;
            
           Arg.Validate(() => objsWithEqualCount)
               .CountLessOrEqualThan(count);
        }

        [Fact]
        public void CountLessOrEqualThan_CountLess_Ok()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            
            Arg.Validate(() => objsWithLessCount)
                .CountLessOrEqualThan(count);
        }

        [Fact]
        public void CountLessOrEqualThan_CountMore_ArgumentException()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            
            ArgumentException exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => objsWithMoreCount)
                    .CountLessOrEqualThan(count));
            
            Assert.Equal($"Argument '{nameof(objsWithMoreCount)}' must contains less or equal than {count} elements. Current count elements: {objsWithMoreCount.Length}", exc.Message);
        }
    }
}
