using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void GetCurrentValuesString_ValuesIsNull_ValidResult()
        {
            string result = ArgumentEnumerableExtension.GetCurrentValuesString(null);
            Assert.Equal("Current value: null", result);
        }

        [Fact]
        public void GetCurrentValuesString_ValuesIsEmpty_ValidResult()
        {
            string result = ArgumentEnumerableExtension.GetCurrentValuesString(new string[0]);
            Assert.Equal("Current value: empty", result);
        }

        [Fact]
        public void GetCurrentValuesString_FewValues_ValidResult()
        {
            string result = ArgumentEnumerableExtension.GetCurrentValuesString(new[] { 1, 2, 3 });
            Assert.Equal("Current value: ['1', '2', '3']", result);
        }

        [Fact]
        public void GetCurrentValuesString_ManyValues_ValidResult()
        {
            string result = ArgumentEnumerableExtension.GetCurrentValuesString(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            Assert.Equal("Current value: ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', ... ]", result);
        }
    }
}
