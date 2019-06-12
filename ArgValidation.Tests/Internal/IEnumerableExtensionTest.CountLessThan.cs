using ArgValidation.Internal;
using ArgValidation.Internal.Utils;
using ArgValidation.Tests.Mocks;
using Xunit;

namespace ArgValidation.Tests.Internal
{
    public partial class IEnumerableExtensionTest
    {
        [Fact]
        public void CountLessThan_ICollectionCountIsLess_True()
        {
            Assert.True(EnumerableExtension.CountLessThan(
              enumerable: new OnlyCountCollectionMock(count: 0),
              count: 1));
        }

        [Fact]
        public void CountLessThan_ICollectionCountIsEquals_False()
        {
            Assert.False(EnumerableExtension.CountLessThan(
              enumerable: new OnlyCountCollectionMock(count: 1),
              count: 1));
        }

        [Fact]
        public void CountLessThan_ICollectionCountIsMore_False()
        {
            Assert.False(EnumerableExtension.CountLessThan(
              enumerable: new OnlyCountCollectionMock(count: 1),
              count: 0));
        }

        [Fact]
        public void CountLessThan_IEnumerable_ResetWasCall()
        {
            var enumerable = EnumerableMock.CreateWintCountElems(1);
            EnumerableExtension.CountLessThan(enumerable, 1);
            Assert.True(enumerable.ResetWasCall);
        }

        [Fact]
        public void CountLessThan_IEnumerableCountIsLess_True()
        {
            Assert.True(EnumerableExtension.CountLessThan(EnumerableMock.CreateEmpty(), 1));
        }

        [Fact]
        public void CountLessThan_IEnumerableCountIsMore_False()
        {
            Assert.False(EnumerableExtension.CountLessThan(EnumerableMock.CreateWintCountElems(2), 1));
        }

        [Fact]
        public void CountLessThan_IEnumerableCountIsEquals_False()
        {
            Assert.False(EnumerableExtension.CountLessThan(EnumerableMock.CreateWintCountElems(2), 2));
        }

        [Fact]
        public void CountLessThan_IEnumerableManyElems_NoUnnecessaryIterations()
        {
            EnumerableMock enumerable = EnumerableMock.CreateWintCountElems(100);
            EnumerableExtension.CountMoreThan(enumerable, 90);
            Assert.Equal(91, enumerable.MoveNextCallCounter);
        }
    }
}