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
        public void create_validatingObject_from_variable()
        {
            int vaiableName = 1;
            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => vaiableName);

            Assert.Equal(nameof(vaiableName), validatingObject.Name);
            Assert.Equal(vaiableName, validatingObject.Value);
        }

        [Fact]
        public void create_validatingObject_from_constant()
        {
            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => 1);

            Assert.Equal($"Static value '1'", validatingObject.Name);
            Assert.Equal(1, validatingObject.Value);
        }

        [Fact]
        public void create_validatingObject_from_constructor()
        {
            int value = 1;
            ValidatingObject<int?> validatingObject = Validate.CreateValidatingObjectFromExpression(() => new int?(value));

            Assert.Equal($"Static value '{value}'", validatingObject.Name);
            Assert.Equal(new int?(value), validatingObject.Value);
        }

        [Fact]
        public void create_validatingObject_from_private_property()
        {
            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => PrivateTestProperty);

            Assert.Equal(nameof(PrivateTestProperty), validatingObject.Name);
            Assert.Equal(PrivateTestProperty, validatingObject.Value);
        }

        [Fact]
        public void create_validatingObject_from_object_property()
        {
            ValidateTest objWithProperty = new ValidateTest();

            ValidatingObject<int> validatingObject = Validate.CreateValidatingObjectFromExpression(() => objWithProperty.PrivateTestProperty);

            Assert.Equal(nameof(PrivateTestProperty), validatingObject.Name);
            Assert.Equal(PrivateTestProperty, validatingObject.Value);
        }
    }
}
