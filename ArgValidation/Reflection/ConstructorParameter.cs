using System;

namespace ArgValidation.Reflection
{
    internal sealed class ConstructorParameter
    {
        public string Name { get; }
        public object Value { get; }
        public Type ParameterType { get; }

        public ConstructorParameter(string name, object value, Type parameterType)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"Argument {nameof(name)} cannot be empty, null or whitespaces", nameof(name));

            if (parameterType == null)
                throw new ArgumentNullException(nameof(parameterType));

            Name = name;
            Value = value;
            ParameterType = parameterType;
        }
    }
}
