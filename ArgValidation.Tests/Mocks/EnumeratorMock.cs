using System;
using System.Collections;

namespace ArgValidation.Tests.Mocks
{
    internal class EnumeratorMock : IEnumerator
    {
        private object[] _elems;
        public int Counter = 0;
        public bool WasReset { get; set; } = false;

        public EnumeratorMock(object[] elems)
        {
            _elems = elems;
        }

        public object Current => _elems[Counter - 1];

        public bool MoveNext()
        {
            Counter++;
            return Counter <= _elems.Length;
        }

        public void Reset()
        {
            if (WasReset)
                throw new Exception("Method 'Reset' can only be called once");
            WasReset = true;
        }
    }
}