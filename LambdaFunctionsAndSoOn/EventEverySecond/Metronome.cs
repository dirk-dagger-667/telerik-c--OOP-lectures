namespace EventEverySecond
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Metronome
    {
        public delegate void EventHandler(Metronome me, EventArgs arg);
        public EventArgs arg = null;
        public event EventHandler Event;

        public void PrintEverySecond()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);

                if (Event != null)
                {
                    Event(this, arg);
                }
            }
        }
    }
}
