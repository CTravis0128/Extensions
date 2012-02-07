/*  Author: Cory Travis
 *  EventHandlerExtensions (Static Class)
 *  Modified 5/13/2011
 */

using System;

namespace Extensions {
    
    public static class EventHandlerExtensions {

        public static void Raise(this EventHandler handler, object sender, EventArgs args = null) {
            if(handler != null) {
                handler(sender, args ?? EventArgs.Empty);
            }
        }

        public static void Raise<TEventArgs>(this EventHandler<TEventArgs> handler, object sender, TEventArgs args) 
            where TEventArgs : EventArgs {

            if(handler != null) {
                handler(sender, args);
            }
        }
    }
}
