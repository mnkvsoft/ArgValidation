using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void MaxCount_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => 
                Arg.Validate(() => nullValue)
                    .MaxCount(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void MaxCount_CountEqual_Ok()
        {
            object[] objsWithEqualCount = { new object(), new object() };
            int count = objsWithEqualCount.Length;
            
           Arg.Validate(() => objsWithEqualCount)
               .MaxCount(count);
        }

        [Fact]
        public void MaxCount_CountLess_Ok()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            
            Arg.Validate(() => objsWithLessCount)
                .MaxCount(count);
        }

        [Fact]
        public void MaxCount_CountMore_ArgumentException()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            
            ArgumentException exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => objsWithMoreCount)
                    .MaxCount(count));
            
            Assert.Equal($"Argument '{nameof(objsWithMoreCount)}' must contains a maximum of {count} elements. Current count elements: {objsWithMoreCount.Length}", exc.Message);
        }
    }
}
