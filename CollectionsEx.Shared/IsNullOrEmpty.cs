using System.Collections.Generic;
using System.Linq;

namespace Fnio.Lib.CollectionsEx
{
    public static partial class CollectionsEx
    {
        /// <summary>
        /// Determines whether a sequence is null or contains no element.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || source.Any() == false;
        }
    }
}
