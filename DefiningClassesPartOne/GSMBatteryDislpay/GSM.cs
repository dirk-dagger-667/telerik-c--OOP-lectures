using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes (class GSM holding instances of the classes Battery and Display).


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
