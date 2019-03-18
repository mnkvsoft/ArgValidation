//using System;
//using System.Linq;
//using System.Reflection;
//using System.Text;

//namespace ArgValidation.Internal.Utils.Reflection
//{
//    internal static class ReflectionObjectCreator
//    {
//        internal static object InvokeConstructor(Type type, params ConstructorParameter[] parameters)
//        {
//            ConstructorInfo[] constructors = type.GetConstructors();
//            type.GetConstructor(BindingFlags.Public, new Binder())

//            foreach (var constructor in constructors)
//            {
//                ParameterInfo[] parInfos = constructor.GetParameters();
//                if (parInfos.Length != parameters.Length)
//                    continue;

//                object[] orderedArguments = parInfos.Select(pi => parameters.FirstOrDefault(x => x.Name == pi.Name && x.ParameterType == pi.ParameterType))
//                                                     .Where(p => p != null)
//                                                     .Select(p => p.Value)
//                                                     .ToArray();

//                if (orderedArguments.Length != parameters.Length)
//                    continue;

//                object result = constructor.Invoke(orderedArguments);
//                return result;
//            }

//            string message = GetExceptionMessage(type, parameters);
//            throw new InvalidOperationException(message);
//        }

//        private static string GetExceptionMessage(Type type, ConstructorParameter[] parameters)
//        {
//            var result = new StringBuilder($"Failed to create object. Constructor {type.Name}(");

//            for (int i = 0; i < parameters.Length; i++)
//            {
//                if (i != 0)
//                    result.Append(", ");

//                var par = parameters[i];
//                result.Append($"{par.ParameterType.Name} {par.Name}");
//            }

//            result.Append(") was not found");
//            return result.ToString();
//        }
//    }
//}
