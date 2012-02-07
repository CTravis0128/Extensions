/*  Author: Cory Travis
 *  ObjectExtensions (Static Class)
 *  Modified 5/13/2011
 */

using System.Collections.Generic;

namespace Extensions {

    public static class ObjectExtensions {

        public static IEnumerable<T> ToEnumerable<T>(this T item) {
            yield return item;
        }
    }
}
