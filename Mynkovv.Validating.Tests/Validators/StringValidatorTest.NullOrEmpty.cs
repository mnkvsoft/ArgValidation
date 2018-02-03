using Mynkovv.Validating.Validators;
using System;
using System.Linq.Expressions;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class StringValidatorTest
    {
        // NullOrEmpty

        [Fact]
        public void NullOrEmpty_Empty_Ok()
        {
            CreateStringValidator(() => string.Empty).NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_Null_Ok()
        {
            CreateStringValidator(() => null).NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_NotEmpty_ArgumentException()
        {
            string notEmptyString = "not-empty";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => notEmptyString).NullOrEmpty());
            Assert.Equal($"String with name '{nameof(notEmptyString)}' must be empty or null. Current value: '{notEmptyString}'", exc.Message);
        }

        // NotNullOrEmpty

        [Fact]
        public void NotNullOrEmpty_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => emptyString).NotNullOrEmpty());
            Assert.Equal($"String with name '{nameof(emptyString)}' cannot be empty or null. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).NotNullOrEmpty());
            Assert.Equal($"String with name '{nameof(nullString)}' cannot be empty or null. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_NotEmpty_Ok()
        {
            string notEmpty = "not-empty";
            CreateStringValidator(() => notEmpty).NotNullOrEmpty();
        }

        // NullOrWhitespace

        [Fact]
        public void NullOrWhitespace_Empty_Ok()
        {
            string emptyString = string.Empty;
            CreateStringValidator(() => emptyString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_WhiteSpace_Ok()
        {
            string whitespaceString = "   ";
            CreateStringValidator(() => whitespaceString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_Null_Ok()
        {
            string nullString = null;
            CreateStringValidator(() => nullString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_HasValue_ArgumentException()
        {
            string strWithValue = "with-value";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => strWithValue).NullOrWhitespace());
            Assert.Equal($"String with name '{nameof(strWithValue)}' must be empty or whitespace. Current value: '{strWithValue}'", exc.Message);
        }

        // NotNullOrWhitespace

        [Fact]
        public void NotNullOrWhitespace_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => emptyString).NotNullOrWhitespace());
            Assert.Equal($"String with name '{nameof(emptyString)}' cannot be empty or whitespace. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_WhiteSpace_ArgumentException()
        {
            string whitespaceString = "   ";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => whitespaceString).NotNullOrWhitespace());
            Assert.Equal($"String with name '{nameof(whitespaceString)}' cannot be empty or whitespace. Current value: '   '", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).NotNullOrWhitespace());
            Assert.Equal($"String with name '{nameof(nullString)}' cannot be empty or whitespace. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_HasValue_Ok()
        {
            string strWithValue = "with-value";
            CreateStringValidator(() => strWithValue).NotNullOrWhitespace();
        }

        // LengthEqual

        [Fact]
        public void LengthEqual_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthEqual(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthEqual_NotEqual_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 2;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthEqual(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthEqual_Equal_Ok()
        {
            string str = "str";
            CreateStringValidator(() => str).LengthEqual(str.Length);
        }

        // LengthMoreThan

        [Fact]
        public void LengthMoreThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthMoreThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length more than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_Equals_ArgumentException()
        {
            string str = "str";
            int length = str.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthMoreThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length more than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthMoreThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length more than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            CreateStringValidator(() => str).LengthMoreThan(length);
        }


        // LengthMoreOrEqualThan

        [Fact]
        public void LengthMoreOrEqualThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthMoreOrEqualThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length more or equals than {length}. Current length: unknown (string is null)", exc.Message);
        }


        [Fact]
        public void LengthMoreOrEqualThan_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthMoreOrEqualThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length more or equals than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreOrEqualThan_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            CreateStringValidator(() => str).LengthMoreOrEqualThan(length);
        }

        [Fact]
        public void LengthMoreOrEqualThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            CreateStringValidator(() => str).LengthMoreOrEqualThan(length);
        }

        // LengthLessThan

        [Fact]
        public void LengthLessThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthLessThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length less than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthLessThan_More_ArgumentException()
        {
            string str = "str";
            int length = str.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthLessThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length less than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthLessThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length less than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessThan_Less_Ok()
        {
            string str = "str";
            int length = str.Length + 1;
            CreateStringValidator(() => str).LengthLessThan(length);
        }

        // LengthLessOrEqualThan

        [Fact]
        public void LengthLessOrEqualThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthLessOrEqualThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length less or equals than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthLessOrEqualThan_More_ArgumentException()
        {
            string str = "str";
            int length = str.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthLessOrEqualThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length less or equals than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessOrEqualThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            CreateStringValidator(() => str).LengthLessOrEqualThan(length);
        }

        [Fact]
        public void LengthLessOrEqualThan_Less_Ok()
        {
            string str = "str";
            int length = str.Length + 1;
            CreateStringValidator(() => str).LengthLessOrEqualThan(length);
        }

        // LengthInRange

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
