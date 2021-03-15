using System;
using System.Collections.Generic;

namespace Negocio.Extensions
{
    public static class ExtensionsEnumerable
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> itemAction)
        {
            foreach (var item in items)
            {
                itemAction(item);
            }
        }
    }
}
