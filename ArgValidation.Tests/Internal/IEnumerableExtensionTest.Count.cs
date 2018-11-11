using ArgValidation.Internal;
using ArgValidation.Internal.Utils;
using ArgValidation.Tests.Mocks;
using Xunit;

namespace ArgValidation.Tests.Internal
{
    public partial class IEnumerableExtensionTest
    {
        [Fact]
        public void Count_ICollection_ResetNotInv()
        {
            int count = 10;
            Assert.Equal(count, EnumerableExtension.Count(new OnlyCountCollectionMock(count)));
        }

        [Fact]
        public void Count_IEnumerable_ResetWasCall()
        {
            var enumerable = new EnumerableMock(1);
            EnumerableExtension.Count(enumerable);
            Assert.True(enumerable.ResetWasCall);
        }

        [Fact]
        public void Count_IEnumerableCountIsLess_False()
        {
            int count = 10;
            Assert.Equal(count, EnumerableExtension.Count(new EnumerableMock(count)));
        }
    }
}