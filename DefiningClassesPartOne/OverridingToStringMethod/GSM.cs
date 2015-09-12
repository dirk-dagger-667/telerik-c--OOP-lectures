using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add a method in the GSM class for displaying all information about it. Try to override ToString().


namespace OverridingToStringMethod
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class GSM
    {
        public string manufacturer;
        public string model;
        public decimal price;
        public string owner;
        public Display display;
        public Battery battery;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("model : " + model + "\nManufacturer : " + manufacturer);
            if (price <= 0.0M)
            {
                sb.Append("\nPrice : for free");
            }
            if (price > 0.0M)
            {
                sb.Append("\nPrice : " + price);
            }
            if (owner == null)
            {
                sb.Append("Owner : no onwer yet");
            }
            if (owner != null)
            {
                sb.Append("\nOwner : " + owner);
            }
            sb.Append("\nBattery model : " + battery.model);
            sb.Append("\nBattery lasts in idle mode in hours : " + battery.hoursIdle);
            sb.Append("\nBattery last while speaking in hours : " + battery.hoursTalk);
            sb.Append("\nDisplay size : " + display.size + "M");
            sb.Append("\nDisplay number : " + display.number);
            sb.Append("\nDisplay supported colors : " + display.color + "mbit");
            return sb.ToString();
        }

        public GSM(string manufacturer, string model)
            : this(manufacturer, model, 0.0M, null, new Battery(), new Display())
        {
        }

        public GSM(string manufacturer, string model, decimal price)
            : this(manufacturer, model, price, null, new Battery(), new Display())
        {
        }

        public GSM(string manufacturer, string model, decimal price, string owner)
            : this(manufacturer, model, price, owner, new Battery(), new Display())
        {
        }

        public GSM(string manufacturer, string model, decimal price, string owner, Battery battery)
            : this(manufacturer, model, price, owner, battery, new Display())
        {
        }

        public GSM(string manufacturer, string model, decimal price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
    }

    public class Battery
    {
        public BatteryType batteryType;
        public string model;
        public double hoursIdle;
        public double hoursTalk;

        public Battery()
        {
        }

        public Battery(string model)
            : this(model, 0.0d, 0.0d, new BatteryType())
        {
        }

        public Battery(string model, double hoursIdle)
            : this(model, hoursIdle, 0.0d, new BatteryType())
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
            : this(model, hoursIdle, hoursTalk, new BatteryType())
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }
    }

    public class Display
    {
        public double size;
        public string number;
        public string color;

        public Display()
        {
        }

        public Display(double size)
            : this(size, null, null)
        {
        }

        public Display(double size, string number)
            : this(size, number, null)
        {
        }

        public Display(double size, string number, string color)
        {
            this.size = size;
            this.number = number;
            this.color = color;
        }
    }
}
