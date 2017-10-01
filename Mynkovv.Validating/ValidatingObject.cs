using System;
using System.Collections.Generic;
using System.Text;

namespace Mynkovv.Validating
{
    public sealed class ValidatingObject<TValue>
    {
        public string Name { get; }
        public TValue Value { get; }

        public ValidatingObject(string name, TValue value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"Argument '{nameof(name)}' cannot be empty", nameof(name));

            Name = name;
            Value = value;
        }
    }
}
