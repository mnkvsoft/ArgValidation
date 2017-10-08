using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class MoreThanTest
    {
        [Fact]
        public void value_more()
        {
            Validate.Obj(() => 2).MoreThan(1);
        }

        [Fact]
        public void value_not_more()
        {
            int argEqual0 = 0;
            int valueEqual1 = 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => argEqual0).MoreThan(valueEqual1));
            Assert.Equal($"Object with name '{nameof(argEqual0)}' must be more than '{valueEqual1}'", exc.Message);
        }

       
    }
}
