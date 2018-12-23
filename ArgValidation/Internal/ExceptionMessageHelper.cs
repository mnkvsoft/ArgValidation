using System.Text;

namespace ArgValidation.Internal
{
    internal static class ExceptionMessageHelper
    {
        public static string GetStringValueForMessage<T>(this T value)
        {
            if (value == null)
                return "null";
            return $"'{value}'";
        }

        public static string JoinForMessage<T>(this T[] values)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                if (sb.Length > 0)
                    sb.Append(", ");
                T val = values[i];
                sb.Append(GetStringValueForMessage(val));
            }
            return sb.ToString();
        }
    }
}