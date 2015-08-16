using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        public static void DateAndTime()
        {
            Console.WriteLine(DateTime.Now);
        }


        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.method = DateAndTime;
            timer.Start(1, 10);
        }
    }

