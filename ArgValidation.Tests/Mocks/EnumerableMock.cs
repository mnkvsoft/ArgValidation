using System;
using System.Collections;

namespace ArgValidation.Tests.Mocks
{
    internal sealed class EnumerableMock : IEnumerable
    {
        public static EnumerableMock CreateEmpty() => new EnumerableMock(0);
        public static EnumerableMock CreateNotEmpty() => new EnumerableMock(1);

        private EnumeratorMock _enumerator;

        public EnumerableMock(int count)
        {
            Count = count;
        }

        public IEnumerator GetEnumerator()
        {
            _enumerator = new EnumeratorMock(Count);
            return _enumerator;
        }

        public bool ResetWasCall => _enumerator.WasReset;

        public int Count { get; }

        public int MoveNextCallCounter => _enumerator.Counter;
    }
}