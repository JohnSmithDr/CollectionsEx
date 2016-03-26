using System;
using System.Collections.Generic;

namespace Fnio.Lib.CollectionsEx
{
    public static partial class CollectionsEx
    {
        /// <summary>
        /// Add this to collection.
        /// </summary>
        public static TItem AddTo<TItem>(this TItem source, ICollection<TItem> collection)
        {
            collection.Add(source);
            return source;
        }

        /// <summary>
        /// Convert this and add it to collection.
        /// </summary>
        public static TItem AddTo<TItem, TSource>(this TItem source, ICollection<TSource> collection, Func<TItem, TSource> convert)
        {
            collection.Add(convert.Invoke(source));
            return source;
        }
    }
}
