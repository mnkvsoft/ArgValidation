using System;
using System.Linq;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void FailedIf_ConditionIsTrue_Exception()
        {
            string shortName = "Harry P,";

            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(shortName, nameof(shortName))
                    .FailedIf(shortName.Last() != '.', "Last char must be equals '.'"));

            Assert.Equal("Last char must be equals '.'" + Environment.NewLine +
                         "Argument name: 'shortName'",
                exc.Message);
        }

        [Fact]
        public void FailedIf_ConditionIsFalse_Ok()
        {
            string shortName = "Harry P.";

            Arg.Validate(shortName, nameof(shortName))
                .FailedIf(shortName.Last() != '.', "Last char must be equals '.'");
        }
    }
}
