using System;
using System.Collections;

namespace ArgValidation.Tests.Mocks
{
    internal sealed class OnlyCountCollectionMock : ICollection
    {
        public static readonly OnlyCountCollectionMock Empty = new OnlyCountCollectionMock(count: 0);

        public OnlyCountCollectionMock(int count) => Count = count;

        public int Count { get; }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
