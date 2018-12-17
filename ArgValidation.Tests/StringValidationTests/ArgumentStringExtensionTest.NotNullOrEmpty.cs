using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotNullOrEmpty_ValidationIsDisabled_WithoutException()
        {
            string value = "";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NotNullOrEmpty();
        }
    }
}
