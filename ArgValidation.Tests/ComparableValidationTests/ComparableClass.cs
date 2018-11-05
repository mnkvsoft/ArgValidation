using System;

namespace ArgValidation.Tests.ComparableValidationTests
{
    public class ComparableClass : IComparable<ComparableClass>
    {
        private int value;

        public ComparableClass(int value = 0)
        {
            this.value = value;
        }

        public int CompareTo(ComparableClass other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return value.CompareTo(other.value);
        }
    }
}