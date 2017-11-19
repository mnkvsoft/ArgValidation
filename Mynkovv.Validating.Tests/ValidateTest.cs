using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests
{
    public class ValidateTest
    {
        private int PrivateTestProperty { get; set; }

        [Fact]
        public void CreateValidatingObjectFromExpression_Variable_Ok()
        {
            int variableName = 1;
            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => variableName);

            Assert.Equal(nameof(variableName), validatingObject.Name);
            Assert.Equal(variableName, validatingObject.Value);
        }

        [Fact]
        public void CreateValidatingObjectFromExpression_Constant_Ok()
        {
            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => 1);

            Assert.Equal($"Static value '1'", validatingObject.Name);
            Assert.Equal(1, validatingObject.Value);
        }

        [Fact] 
        public void CreateValidatingObjectFromExpression_Constructor_Ok()
        {
            int value = 1;
            ValidatingObject<int?> validatingObject = Validate.CreateValidatingObjectFromExpression(() => new int?(value));

            Assert.Equal($"Static value '{value}'", validatingObject.Name);
            Assert.Equal(new int?(value), validatingObject.Value);
        }

        [Fact]
        public void CreateValidatingObjectFromExpression_InstanceProperty_Ok()
        {
            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => PrivateTestProperty);

            Assert.Equal(nameof(PrivateTestProperty), validatingObject.Name);
            Assert.Equal(PrivateTestProperty, validatingObject.Value);
        }

        [Fact]
        public void CreateValidatingObjectFromExpression_ObjectProperty_Ok()
        {
            ValidateTest objWithProperty = new ValidateTest();

            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => objWithProperty.PrivateTestProperty);

            Assert.Equal(nameof(PrivateTestProperty), validatingObject.Name);
            Assert.Equal(PrivateTestProperty, validatingObject.Value);
        }
    }
}
