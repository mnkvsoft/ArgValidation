using System;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {

        [Fact]
        public void NotDefault_ValidationIsDisabled_WithoutException()
        {
            int value = default(int);
            var arg = new Argument<int>(value, "name", validationIsDisabled: true);
            arg.NotDefault();
        }
    }
}
