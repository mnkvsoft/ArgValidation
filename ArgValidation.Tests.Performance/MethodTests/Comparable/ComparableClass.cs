using System;

namespace ArgValidation.Tests.Performance.MethodTests.Comparable
{
    class ComparableClass : IComparable<ComparableClass>
    {
        private string _strValue = "StrValue";
        private long _intValue = 1;
        private decimal _decimalValue = 1;
        private int _comparableValue;

        public ComparableClass(int comparableValue)
        {
            _comparableValue = comparableValue;
        }

        public int CompareTo(ComparableClass other)
        {
            return _comparableValue.CompareTo(other._comparableValue);
        }

        public static implicit operator ComparableClass(int value)
        {
            return new ComparableClass(value);
        }
    }
}
