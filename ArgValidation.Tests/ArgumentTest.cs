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
            Assert.False(arg.ValidationIsDisabled());
        }
        
        [Fact]
        public void ImplicitOperator_NotDefaultValue_ReturnValidValue()
        {
            string value = "stringValue";

            Argument<string> arg = new Argument<string>(value, nameof(value));

            string value2 = arg;
            Assert.Equal(value, value2);
        }

        [Fact]
        public void With_CustomException_CustomExceptionTypeIsSetToValidationContext()
        {
            Argument<string> arg = new Argument<string>("value", "name");
            arg.With<CustomException>();

            Assert.Equal(typeof(CustomException), arg.CustomExceptionType);
        }
    }
}