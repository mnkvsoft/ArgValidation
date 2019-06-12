using System.Collections;
using System.Linq;

namespace ArgValidation.Tests.Mocks
{
    internal sealed class EnumerableMock : IEnumerable
    {
        private readonly object[] _elems;
        public static EnumerableMock CreateEmpty() => new EnumerableMock(new object []{});
        public static EnumerableMock CreateNotEmpty() => new EnumerableMock(new[] { new object() });
        public static EnumerableMock CreateWintCountElems(int count) => new EnumerableMock(new object[count]);

        private EnumeratorMock _enumerator;

        public EnumerableMock(object[] elems)
        {
            _elems = elems;
        }

        public IEnumerator GetEnumerator()
        {
            _enumerator = new EnumeratorMock(_elems);
            return _enumerator;
        }

        public bool ResetWasCall => _enumerator.WasReset;

        public int MoveNextCallCounter => _enumerator.Counter;
    }
}