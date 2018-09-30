using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ArgValidation.Internal.Reflection
{
    internal static class ReflectionObjectCreator
    {
        internal static T InvokeConstructor<T>(params ConstructorParameter[] parameters)
        {
            Type t = typeof(T);
            ConstructorInfo[] constructors = t.GetConstructors();

            foreach (var constructor in constructors)
            {
                ParameterInfo[] parInfos = constructor.GetParameters();
                if (parInfos.Length != parameters.Length)
                    continue;

                object[] orderedArguments = parInfos.Select(pi => parameters.FirstOrDefault(x => x.Name == pi.Name && x.ParameterType == pi.ParameterType))
                                                     .Where(p => p != null)
                                                     .Select(p => p.Value)
                                                     .ToArray();

                if (orderedArguments.Length != parameters.Length)
                    continue;

                T result = (T)constructor.Invoke(orderedArguments);
                return result;
            }

            string message = GetExceptionMessage<T>(parameters);
            throw new InvalidOperationException(message);
        }

        private static string GetExceptionMessage<T>(ConstructorParameter[] parameters)
        {
            var result = new StringBuilder($"Failed to create object. Constructor {typeof(T).Name}(");

            for (int i = 0; i < parameters.Length; i++)
            {
                if (i != 0)
                    result.Append(", ");

                var par = parameters[i];
                result.Append($"{par.ParameterType.Name} {par.Name}");
            }

            result.Append(") was not found");
            return result.ToString();
        }
    }
}
