//Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices.


namespace EventEverySecond
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Listener
    {
        public void SubscribeToEvent(Metronome me)
        {
            me.Event += new Metronome.EventHandler(Listening);
        }

        public void Listening(Metronome me, EventArgs args)
        {
            Console.WriteLine("I'm listening!!!");
        }
    }
}
