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
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Argument name cannot be empty");

            Name = name;
            Value = value;
        }

        public bool IsNotInitialized()
        {
            return Name == null;
        }
    }
}
