/*  Author: Cory Travis
 *  EnumExtensions (Static Class)
 *  Modified 5/13/2011
 */

using System;

namespace Extensions {

    public static class EnumExtensions {

        public static bool All(this Enum flags, Enum options) {      
            return (Convert.ToUInt64(flags) & Convert.ToUInt64(options)) == Convert.ToUInt64(options);
        }

        public static bool Any(this Enum flags, Enum options) {
            return (Convert.ToUInt64(flags) & Convert.ToUInt64(options)) != 0;
        }
    }
}
