using Xunit;

namespace Mynkovv.Validating.Tests
{
    public class ValidatingObjectTest
    {
        private int PrivateTestProperty { get; set; }

        [Fact]
        public void ConstructorFromExpression_Variable_Ok()
        {
            int variableName = 1;
            Argument<int> validatingObject = new Argument<int>(() => variableName);

            Assert.Equal(nameof(variableName), validatingObject.Name);
            Assert.Equal(variableName, validatingObject.Value);
        }

        [Fact]
        public void ConstructorFromExpression_Constant_Ok()
        {
            Argument<int> validatingObject = new Argument<int>(() => 1);

            Assert.Equal($"Static value '1'", validatingObject.Name);
            Assert.Equal(1, validatingObject.Value);
        }

        [Fact] 
        public void ConstructorFromExpression_Constructor_Ok()
        {
            int value = 1;
            Argument<int?> validatingObject = new Argument<int?>(() => new int?(value));

            Assert.Equal($"Static value '{value}'", validatingObject.Name);
            Assert.Equal(new int?(value), validatingObject.Value);
        }

        [Fact]
        public void ConstructorFromExpression_InstanceProperty_Ok()
        {
            Argument<int> validatingObject = new Argument<int>(() => PrivateTestProperty);

            Assert.Equal(nameof(PrivateTestProperty), validatingObject.Name);
            Assert.Equal(PrivateTestProperty, validatingObject.Value);
        }

        [Fact]
        public void ConstructorFromExpression_ObjectProperty_Ok()
        {
            ValidatingObjectTest objWithProperty = new ValidatingObjectTest();

            Argument<int> validatingObject = new Argument<int>(() => objWithProperty.PrivateTestProperty);

            Assert.Equal(nameof(PrivateTestProperty), validatingObject.Name);
            Assert.Equal(PrivateTestProperty, validatingObject.Value);
        }
    }
}
