using Xunit;

namespace ArgValidation.Tests
{
    public class ArgumentTest
    {
        [Fact]
        public void Constructor_ValidInput_CopyToFields()
        {
            string value = "stringValue";

            Argument<string> arg = new Argument<string>(value, nameof(value));
            
            Assert.Equal(value, arg.Value);
            Assert.Equal(nameof(value), arg.Name);
        }
        
        [Fact]
        public void implicitOperator_NotDefaultValue_ReturnValidValue()
        {
            string value = "stringValue";

            Argument<string> arg = new Argument<string>(value, nameof(value));

            string value2 = arg;
            Assert.Equal(value, value2);
        }
    }
}