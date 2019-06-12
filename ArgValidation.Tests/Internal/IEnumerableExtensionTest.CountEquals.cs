using ArgValidation.Internal;
using ArgValidation.Internal.Utils;
using ArgValidation.Tests.Mocks;
using Xunit;

namespace ArgValidation.Tests.Internal
{
    public partial class IEnumerableExtensionTest
    {
        [Fact]
        public void CountEquals_ICollectionCountNotEquals_False()
        {
            Assert.False(EnumerableExtension.CountEquals(
                enumerable: new OnlyCountCollectionMock(count: 3), 
                count: 1));
        }

        [Fact]
        public void CountEquals_ICollectionCountIsEquals_True()
        {
            Assert.True(EnumerableExtension.CountEquals(
                enumerable: new OnlyCountCollectionMock(count: 3),
                count: 3));
        }

        [Fact]
        public void CountEquals_IEnumerable_ResetWasCall()
        {
            var enumerable = EnumerableMock.CreateWintCountElems(1);
            EnumerableExtension.CountEquals(enumerable, 1);
            Assert.True(enumerable.ResetWasCall);
        }

        [Fact]
        public void CountEquals_IEnumerableCountIsLess_False()
        {
            Assert.False(EnumerableExtension.CountEquals(EnumerableMock.CreateEmpty(), 1));
        }

        [Fact]
        public void CountEquals_IEnumerableCountIsMore_False()
        {
            Assert.False(EnumerableExtension.CountEquals(EnumerableMock.CreateWintCountElems(2), 1));
        }

        [Fact]
        public void CountEquals_IEnumerableCountIsEquals_True()
        {
            Assert.True(EnumerableExtension.CountEquals(EnumerableMock.CreateWintCountElems(2), 2));
        }

        [Fact]
        public void CountEquals_IEnumerableManyElems_NoUnnecessaryIterations()
        {
            EnumerableMock enumerable = EnumerableMock.CreateWintCountElems(100);
            EnumerableExtension.CountEquals(enumerable, 2);
            Assert.Equal(3, enumerable.MoveNextCallCounter);
        }
    }
}