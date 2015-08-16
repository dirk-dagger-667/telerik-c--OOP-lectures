using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMBatteryDislpay
{
    public class GSM
    {
        public string manufacturer;
        public string model;
        public decimal price;
        public string owner;
        public Display display;
        public Battery battery;
    }

    public class Battery
    {

        public string model;
        public double hoursIdle;
        public double hoursTalk;
    }

    public class Display
    {
        public double size;
        public string number;
        public string color;
    }
}
