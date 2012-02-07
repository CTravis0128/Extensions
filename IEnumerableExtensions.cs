/*  Author: Cory Travis
 *  IEnumerableExtensions (Static Class)
 *  Modified 5/13/2011  
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions {
    
    public static class IEnumerableExtensions {
        
        private static readonly Random random = new Random();

        public static T Random<T>(this IEnumerable<T> enumerable) {
            try {
                return enumerable.ElementAt(random.Next(0, enumerable.Count() - 1));
            } catch(ArgumentOutOfRangeException) {
                throw new ArgumentException("Sequence contains no elements.", "enumerable");
            }
        }

        public static T[] Random<T>(this IEnumerable<T> enumerable, int count) {
            int range = enumerable.Count() - 1;
            if(range < 1) {
                throw new ArgumentException("Sequence contains no elements.", "enumerable");
            }
            T[] values = new T[count];
            for(int i = 0; i < count; i++) {
                values[i] = enumerable.ElementAt(random.Next(0, range));
            }
            return values;
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> enumerable, T obj) {
            foreach(var item in enumerable) {
                yield return item;
            }
            yield return obj;
        }
    }
}
