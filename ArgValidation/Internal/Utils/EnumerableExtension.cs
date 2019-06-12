using System.Collections;

namespace ArgValidation.Internal.Utils
{
    internal static class EnumerableExtension
    {
        public static bool Any(this IEnumerable enumerable)
        {
            if (enumerable is ICollection collection)
                return collection.Count > 0;

            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
                return true;

            return false;
        }

        public static bool CountMoreThan(this IEnumerable enumerable, int count)
        {
            if (enumerable is ICollection collection)
                return collection.Count > count;

            int counter = 0;
            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                counter++;
                if (counter > count)
                    return true;
            }

            return false;
        }

        public static bool CountLessThan(this IEnumerable enumerable, int count)
        {
            if (enumerable is ICollection collection)
                return collection.Count < count;

            int counter = 0;
            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                counter++;
                if (counter >= count)
                    return false;
            }

            return true;
        }

        public static bool CountEquals(this IEnumerable enumerable, int count)
        {
            if (enumerable is ICollection collection)
                return collection.Count == count;

            int counter = 0;
            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                counter++;
                if (counter > count)
                    return false;
            }

            return counter == count;
        }

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

        public static bool Contains(this IEnumerable enumerable, object value)
        {
            var enumerator = enumerable.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current == value)
                    return true;
            }

            return false;
        }
    }
}