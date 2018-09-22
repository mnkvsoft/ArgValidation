using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthInRange_MinMoreThanMax_InvalidOperationException()
        {
            string str = "str";
            int min5 = 5;
            int max3 = 3;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateStringValidator(() => str).LengthInRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more than 'max'. Cannot define range", exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueIsNull_ArgumentException()
        {
            string nullString = null;
            int min3 = 3;
            int max5 = 5;

            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthInRange(min3, max5));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length in range {min3} - {max5}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueLengthMoreMax_ArgumentException()
        {
            string strLength6 = "123456";
            int min3 = 3;
            int max5 = 5;

            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => strLength6).LengthInRange(min3, max5));
            Assert.Equal($"String with name '{nameof(strLength6)}' must be length in range {min3} - {max5}. Current length: {strLength6.Length}", exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueLengthLessMin_ArgumentException()
        {
            string strLength2 = "12";
            int min3 = 3;
            int max5 = 5;

            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => strLength2).LengthInRange(min3, max5));
            Assert.Equal($"String with name '{nameof(strLength2)}' must be length in range {min3} - {max5}. Current length: {strLength2.Length}", exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueLengthEqualsMax_Ok()
        {
            string strLength5 = "12345";
            int min3 = 3;
            int max5 = 5;

            CreateStringValidator(() => strLength5).LengthInRange(min3, max5);
        }

        [Fact]
        public void LengthInRange_ValueLengthEqualsMin_Ok()
        {
            string strLength3 = "123";
            int min3 = 3;
            int max5 = 5;

            CreateStringValidator(() => strLength3).LengthInRange(min3, max5);
        }
    }
}
