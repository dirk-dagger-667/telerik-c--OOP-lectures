using System;
using System.Threading;

namespace _08.Events
{
    public delegate void TimeElapsedEventHandler(object publisher, TimeElapsedEventArgs e);

    public class TimeElapsedEventArgs : EventArgs
    {
        public int Ticks { get; set; }

        public TimeElapsedEventArgs(int ticks)
        {
            this.Ticks = ticks;
        }
    }

    public class Timer
    {
        public int Interval { get; set; }
        public int Ticks { get; set; }

        public event TimeElapsedEventHandler TimeElapsed;

        public Timer(int interval, int ticks)
        {
            this.Interval = interval;
            this.Ticks = ticks;
        }

        public void Subscribe(int ticks)
        {
            TimeElapsedEventArgs e = new TimeElapsedEventArgs(ticks);
            TimeElapsed(this, e);
        }

        public void Run()
        {
            while (Ticks > 0)
            {
                Thread.Sleep(this.Interval);
                this.Ticks--;
                Subscribe(this.Ticks);
            }
        }

    }

    public class TestTimer
    {
        static void Main()
        {
            Timer testTimer = new Timer(3000, 5);

            testTimer.TimeElapsed += new TimeElapsedEventHandler(Message);

            Thread th = new Thread(new ThreadStart(testTimer.Run));

            th.Start();

            Console.WriteLine("If the counting is below this message that means counting does not break the process...");
        }

        static void Message(object publisher, TimeElapsedEventArgs e)
        {
            Console.WriteLine("{0} ticks left...", e.Ticks);
        }
    }
}