using System;
using System.Collections;

namespace ArgValidation.Tests.Mocks
{
    internal class EnumeratorMock : IEnumerator
    {
        private readonly int _count;
        public int Counter = 0;
        public bool WasReset { get; set; } = false;

        public EnumeratorMock(int count)
        {
            _count = count;
        }

        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            Counter++;
            return Counter <= _count;
        }

        public void Reset()
        {
            if (WasReset)
                throw new Exception("Method 'Reset' can only be called once");
            WasReset = true;
        }
    }
}