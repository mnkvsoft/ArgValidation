using Mynkovv.Validating.ExceptionThrowers;
using System;

namespace Mynkovv.Validating.Reflection
{
    internal sealed class ConstructorParameter
    {
        public string Name { get; }
        public object Value { get; }
        public Type ParameterType { get; }

        public ConstructorParameter(string name, object value, Type parameterType)
        {
            if (string.IsNullOrWhiteSpace(name))
                FrameworkErrorThrower.ArgumentException($"Argument {nameof(name)} cannot be empty, null or whitespaces", nameof(name));

            if (parameterType == null)
                FrameworkErrorThrower.ArgumentNullException(nameof(parameterType));

            Name = name;
            Value = value;
            ParameterType = parameterType;
        }
    }
}
