using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void NotEmpty_ValidationIsDisabled_WithoutException()
        {
            int[] empty = { };
            var arg = new Argument<int[]>(empty, "name", validationIsDisabled: true);
            arg.NotEmpty();
        }
    }
}
