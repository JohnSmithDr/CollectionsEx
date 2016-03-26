using System.Collections.Generic;
using System.Linq;

namespace Fnio.Lib.CollectionsEx
{
    public static partial class CollectionsEx
    {
        /// <summary>
        /// Determines whether a sequence is not null and contains elements.
        /// </summary>
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }
    }
}
