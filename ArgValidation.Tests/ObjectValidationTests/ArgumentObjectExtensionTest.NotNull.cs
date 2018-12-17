using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {

        [Fact]
        public void NotNull_ValidationIsDisabled_WithoutException()
        {
            var arg = new Argument<object>(null, "name", validationIsDisabled: true);
            arg.NotNull();
        }
    }
}
