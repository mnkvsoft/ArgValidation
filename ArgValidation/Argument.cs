using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public struct Argument<T>
    {
        public string Name { get; }
        public T Value { get; }

        public Argument(T value, string name)
        {
            Name = name;
            Value = value;
        }
    }
}
