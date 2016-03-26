using System;
using System.Collections.Generic;

namespace Fnio.Lib.CollectionsEx
{
    public static partial class CollectionsEx
    {
        /// <summary>
        /// Apply the handler to each item in the source.
        /// </summary>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> handler)
        {
            foreach (var item in source)
            {
                handler.Invoke(item);
            }
        }

        /// <summary>
        /// Apply the handler to each item in the source.
        /// </summary>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> handler)
        {
            var i = 0;
            foreach (var item in source)
            {
                handler.Invoke(item, i++);
            }
        }

        /// <summary>
        /// Apply the handler to each item in the dictionary.
        /// </summary>
        public static void ForEach<TKey, TValue>(this IDictionary<TKey, TValue> source, Action<TKey, TValue> handler)
        {
            foreach (var item in source)
            {
                handler.Invoke(item.Key, item.Value);
            }
        }
    }
}
