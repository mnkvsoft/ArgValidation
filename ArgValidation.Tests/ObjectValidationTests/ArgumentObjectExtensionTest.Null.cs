using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void Null_ValidationIsDisabled_WithoutException()
        {
            object value = new object();
            var arg = new Argument<object>(value, "name", validationIsDisabled: true);
            arg.Null();
        }
    }
}
