using System.Collections;

namespace ArgValidation.Internal
{
    internal static class IEnumerableExtension
    {
        public static int Count(this IEnumerable enumerable)
        {
            int counter = 0;
            foreach (object o in enumerable)
            {
                counter++;
            }

            return counter;
        }
    }
}