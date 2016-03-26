using System.Collections.Generic;

namespace Fnio.Lib.CollectionsEx
{
    public static partial class CollectionsEx
    {
        /// <summary>
        /// Add items to the collection.
        /// </summary>
        public static void AddRange<T>(this ICollection<T> source, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                source.Add(item);
            }
        }

        /// <summary>
        /// Add items to the collection.
        /// </summary>
        public static void AddRange<T>(this ICollection<T> source, params T[] items)
        {
            foreach (var item in items)
            {
                source.Add(item);
            }
        }
    }
}
