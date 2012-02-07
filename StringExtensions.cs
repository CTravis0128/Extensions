/*  Author: Cory Travis
 *  StringExtensions (Static Class)
 *  Modified 5/13/2011
 */

using System;
using System.Collections.Generic;

namespace Extensions {
    
    public static class StringExtensions {

        public static string JoinWith(this string separator, IEnumerable<string> values) {
            return String.Join(separator, values);
        }

        public static string JoinWith<T>(this string separator, IEnumerable<T> values) {
            return String.Join(separator, values);
        }
                
        public static string JoinWith(this string separator, params object[] values) {
            return String.Join(separator, values);
        }

        public static string JoinWith(this string separator, params string[] values) {
            return String.Join(separator, values);
        }

        public static string JoinWith(this string separator, string[] value, int startIndex, int count) {
            return String.Join(separator, value, startIndex, count);
        }
    }
}
