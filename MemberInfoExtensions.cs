/*  Author: Cory Travis
 *  MemberInfoExtensions (Static Class)
 *  Modified 5/13/2011
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Extensions {
    
    public static class MemberInfoExtensions {

        private static readonly object syncRoot = new object();

        private static readonly Dictionary<MemberInfo, Attribute[]> attributeCache 
            = new Dictionary<MemberInfo, Attribute[]>();

        public static bool HasAttribute<TAttribute>(this MemberInfo info, bool inherit = false) 
            where TAttribute : Attribute {

            lock(syncRoot) {
                if(!attributeCache.ContainsKey(info)) {
                    attributeCache.Add(info, (Attribute[])info.GetCustomAttributes(typeof(Attribute), inherit));
                }
                return attributeCache[info].Any(attr => attr is TAttribute);
            }
        }

        public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this MemberInfo info, bool inherit = false) 
            where TAttribute : Attribute {

            Attribute[] attrs;
            lock(syncRoot) {
                if(!attributeCache.ContainsKey(info)) {
                    attributeCache.Add(info, (Attribute[])info.GetCustomAttributes(typeof(Attribute), inherit));
                }             
                attrs = attributeCache[info];
            }            
            for(int i = 0; i < attrs.Length; i++) {
                TAttribute attr = attrs[i] as TAttribute;
                if(attr != null) {
                    yield return attr;
                }
            }
        }
    }
}
