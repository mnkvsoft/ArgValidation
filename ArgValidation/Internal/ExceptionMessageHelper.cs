namespace ArgValidation.Internal
{
    internal class ExceptionMessageHelper
    {
        public static string GetStringValueForMessage<T>(T value)
        {
            if (value == null)
                return "null";

            return $"'{value}'";
        }
    }
}