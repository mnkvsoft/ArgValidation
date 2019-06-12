using ArgValidation.Internal.Utils;
using ArgValidation.Tests.Mocks;
using Xunit;

namespace ArgValidation.Tests.Internal
{
    public partial class IEnumerableExtensionTest
    {
        [Fact]
        public void Contains_ArrayContainsObject_True()
        {
            var obj = new object();
            object[] arr = { obj };
            Assert.True(EnumerableExtension.Contains(arr, obj));
        }

        [Fact]
        public void Contains_ArrayContainsNull_True()
        {
            object[] arr = { new object(), null };
            Assert.True(EnumerableExtension.Contains(arr, null));
        }

        [Fact]
        public void Contains_IEnumerable_ResetWasCall()
        {
            var enumerable = EnumerableMock.CreateNotEmpty();
            EnumerableExtension.Contains(enumerable, new object());
            Assert.True(enumerable.ResetWasCall);
        }
    }
}