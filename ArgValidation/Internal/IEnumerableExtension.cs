using System.Collections;

namespace ArgValidation.Internal
{
    internal static class EnumerableExtension
    {
        public static int Count(this IEnumerable enumerable)
        {
            if (enumerable is ICollection collection)
                return collection.Count;

            int counter = 0;
            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                counter++;
            }

            return counter;
        }
    }
}