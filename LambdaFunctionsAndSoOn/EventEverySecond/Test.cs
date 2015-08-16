namespace EventEverySecond
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Test
    {
        public static void Main()
        {
            var me = new Metronome();
            var listener = new Listener();
            listener.SubscribeToEvent(me);
            me.PrintEverySecond();
        }
    }
}
