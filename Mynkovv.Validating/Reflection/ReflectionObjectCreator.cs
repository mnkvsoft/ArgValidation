using System;
using System.Linq;
using System.Reflection;

namespace Mynkovv.Validating.Reflection
{
    internal static class ReflectionObjectCreator
    {
        public static T InvokeConstructor<T>(params ConstructorParameter[] parameters)
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
            string message = $"Failed to create object. Constructor {typeof(T).Name}(";

            for (int i = 0; i < parameters.Length; i++)
            {
                if (i != 0)
                    message += ", ";

                var par = parameters[i];
                message += $"{par.ParameterType.Name} {par.Name}";
            }

            message += ") was not found";
            return message;
        }
    }
}
