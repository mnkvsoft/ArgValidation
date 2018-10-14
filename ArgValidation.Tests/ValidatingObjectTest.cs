using Xunit;

namespace ArgValidation.Tests
{
    public class ArgumentTest
    {
        private int PrivateTestProperty { get; set; }
        
		[Fact]
        public void ConstructorFromExpression_Variable_Ok()
        {
            int variableName = 1;
            Argument<int> argument = Argument<int>.FromExpression(() => variableName);

            Assert.Equal(nameof(variableName), argument.Name);
			Assert.Equal(variableName, argument.Value);
        }

		[Fact]
        public void ConstructorFromExpression_Constant_Ok()
        {
            Argument<int> argument = Argument<int>.FromExpression(() => 1);

			Assert.Equal($"Static value '1'", argument.Name);
			Assert.Equal(1, argument.Value);
        }
        
		[Fact]
        public void ConstructorFromExpression_Constructor_Ok()
        {
            int value = 1;
            Argument<int?> argument = Argument<int?>.FromExpression(() => new int?(value));

			Assert.Equal($"Static value '{value}'", argument.Name);
			Assert.Equal(new int?(value), argument.Value);
        }

		[Fact]
        public void ConstructorFromExpression_InstanceProperty_Ok()
        {
            Argument<int> argument = Argument<int>.FromExpression(() => PrivateTestProperty);

			Assert.Equal(nameof(PrivateTestProperty), argument.Name);
			Assert.Equal(PrivateTestProperty, argument.Value);
        }

		[Fact]
        public void ConstructorFromExpression_ObjectProperty_Ok()
        {
            ArgumentTest objWithProperty = new ArgumentTest();

            Argument<int> argument = Argument<int>.FromExpression(() => objWithProperty.PrivateTestProperty);

			Assert.Equal(nameof(PrivateTestProperty), argument.Name);
			Assert.Equal(PrivateTestProperty, argument.Value);
        }
    }
}
