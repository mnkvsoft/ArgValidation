namespace ArgValidation
{
    internal class ExceptionMessageHelper
    {
        public static string GetStringValueForMessage<T>(T value)
        {
            if (value.IsNull())
                return "null";

            return $"'{value}'";
        }
    }
}
