using ArgValidation.Internal;
using ArgValidation.Internal.Utils;
using ArgValidation.Tests.Mocks;
using Xunit;

namespace ArgValidation.Tests.Internal
{
    public partial class IEnumerableExtensionTest
    {
        [Fact]
        public void CountMoreThan_ICollectionCountIsLess_False()
        {
            Assert.False(EnumerableExtension.CountMoreThan(
               enumerable: new OnlyCountCollectionMock(count: 0),
               count: 1));
        }

        [Fact]
        public void CountMoreThan_ICollectionCountIsEquals_False()
        {
            Assert.False(EnumerableExtension.CountMoreThan(
               enumerable: new OnlyCountCollectionMock(count: 1),
               count: 1));
        }

        [Fact]
        public void CountMoreThan_ICollectionCountIsMore_True()
        {
            Assert.True(EnumerableExtension.CountMoreThan(
               enumerable: new OnlyCountCollectionMock(count: 1),
               count: 0));
        }

        [Fact]
        public void CountMoreThan_IEnumerable_ResetWasCall()
        {
            var enumerable = new EnumerableMock(1);
            EnumerableExtension.CountMoreThan(enumerable, 1);
            Assert.True(enumerable.ResetWasCall);
        }

        [Fact]
        public void CountMoreThan_IEnumerableCountIsLess_False()
        {
            Assert.False(EnumerableExtension.CountMoreThan(EnumerableMock.CreateEmpty(), 1));
        }

        [Fact]
        public void CountMoreThan_IEnumerableCountIsMore_True()
        {
            Assert.True(EnumerableExtension.CountMoreThan(new EnumerableMock(2), 1));
        }

        [Fact]
        public void CountMoreThan_IEnumerableCountIsEquals_False()
        {
            Assert.False(EnumerableExtension.CountMoreThan(new EnumerableMock(2), 2));
        }

        [Fact]
        public void CountMoreThan_IEnumerableManyElems_NoUnnecessaryIterations()
        {
            EnumerableMock enumerable = new EnumerableMock(100);
            EnumerableExtension.CountMoreThan(enumerable, 100);
            Assert.Equal(101, enumerable.MoveNextCallCounter);
        }
    }
}