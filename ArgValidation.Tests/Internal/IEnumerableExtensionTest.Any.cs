using ArgValidation.Internal.Utils;
using ArgValidation.Tests.Mocks;
using Xunit;

namespace ArgValidation.Tests.Internal
{
    public partial class IEnumerableExtensionTest
    {
        [Fact]
        public void Any_ICollectionIsEmpty_False()
        {
            Assert.False(EnumerableExtension.Any(OnlyCountCollectionMock.Empty));
        }

        [Fact]
        public void Any_ICollectionIsNotEmpty_True()
        {
            Assert.True(EnumerableExtension.Any(new OnlyCountCollectionMock(count: 5)));
        }

        [Fact]
        public void Any_IEnumerable_ResetWasCall()
        {
            var enumerable = EnumerableMock.CreateNotEmpty();
            EnumerableExtension.Any(enumerable);
            Assert.True(enumerable.ResetWasCall);
        }

        [Fact]
        public void Any_IEnumerableIsEmpty_False()
        {
            EnumerableMock empty = EnumerableMock.CreateEmpty();
            Assert.False(EnumerableExtension.Any(empty));
        }

        [Fact]
        public void Any_IEnumerableIsNotEmpty_True()
        {
            EnumerableMock notEmpty = EnumerableMock.CreateNotEmpty();
            Assert.True(EnumerableExtension.Any(notEmpty));
        }

        [Fact]
        public void Any_IEnumerableManyElems_NoUnnecessaryIterations()
        {
            EnumerableMock enumerable = EnumerableMock.CreateWintCountElems(9);
            EnumerableExtension.Any(enumerable);
            Assert.Equal(1, enumerable.MoveNextCallCounter);
        }
    }
}