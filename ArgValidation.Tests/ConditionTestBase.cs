using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests
{
    public abstract class ConditionTestBase
    {
        protected abstract Argument<T> RunForNullableValueType<T>(Expression<Func<T?>> value) where T : struct;
        protected abstract Argument<T> RunForReferenceType<T>(Expression<Func<T>> value) where T : class ;

        [Fact]
        public void IfNotNull_NullableTypeIsNull_ReturnArgumentWithValidState()
        {
            int? value = null;

            Argument<int> result = RunForNullableValueType(() => value);

            Assert.Equal(default(int), result.Value);
            Assert.Equal(nameof(value), result.Name);
            Assert.True(result.ValidationIsDisabled());
        }

        [Fact]
        public void IfNotNull_NullableTypeIsNotNull_ReturnArgumentWithValidState()
        {
            int? value = 1;

            Argument<int> result = RunForNullableValueType(() => value);

            Assert.Equal(value.Value, result.Value);
            Assert.Equal(nameof(value), result.Name);
            Assert.False(result.ValidationIsDisabled());
        }

        private class ReferenceType { }

        [Fact]
        public void IfNotNull_ReferenceTypeIsNull_ReturnArgumentWithValidState()
        {
            ReferenceType value = null;

            Argument<ReferenceType> result = RunForReferenceType(() => value);

            Assert.Null(result.Value);
            Assert.Equal(nameof(value), result.Name);
            Assert.True(result.ValidationIsDisabled());
        }

        [Fact]
        public void IfNotNull_ReferenceTypeIsNotNull_ReturnArgumentWithValidState()
        {
            var value = new ReferenceType();

            Argument<ReferenceType> result = RunForReferenceType(() => value);

            Assert.True(ReferenceEquals(value, result.Value));
            Assert.Equal(nameof(value), result.Name);
            Assert.False(result.ValidationIsDisabled());
        }
    }
}
