using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Treehouse.Common
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }
    }
}