using System.Collections;
using System.Collections.Generic;

namespace ArgValidation.Internal
{
    internal static class EnumerableExtension
    {
        public static int Count(this IEnumerable enumerable)
        {
            if (enumerable is ICollection collection)
                return collection.Count;
            
            int counter = 0;
            foreach (object unused in enumerable)
            {
                counter++;
            }

            return counter;
        }
    }
}