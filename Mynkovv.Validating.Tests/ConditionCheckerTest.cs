using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests
{
    public class ConditionCheckerTest
    {
        //[Fact]
        //public void Compare_ValidatingValueIsNull_Exception()
        //{
        //    object nullValue = null;
        //    Argument<object> validatingObject = new Argument<object>(() => nullValue);

        //    var value = new Argument<object>(() => new object());
        //    InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.Compare(validatingObject, value));
        //    Assert.Equal($"Object with name '{validatingObject.Name}' is null. Сannot compare null object", exc.Message);
        //}

        //[Fact]
        //public void Compare_ComparableValueIsNull_Exception()
        //{
        //    var validatingObject = new Argument<object>(() => new object());
        //    var comparableValue = new Argument<object>(() => null);
        //    InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.Compare(validatingObject, comparableValue));
        //    Assert.Equal("Argument cannot be equal null", exc.Message);
        //}

        //[Fact]
        //public void MoreThan_ValidatingValueNotIComparable_Exception()
        //{
        //    var validatingObject = new Argument<object>(() => new object());
        //    var value = new Argument<object>(() => new object());
        //    InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.Compare(validatingObject, value));
        //    Assert.Equal($"Object with name '{validatingObject.Name}' not implement interface '{typeof(IComparable<object>)}'. Сannot compare objects", exc.Message);
        //}
    }
}
