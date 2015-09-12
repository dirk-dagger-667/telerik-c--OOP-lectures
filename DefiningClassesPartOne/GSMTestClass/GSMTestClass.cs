﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.


namespace GSMTestClass
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class GSM
    {
        private string manufacturer;
        private string model;
        private decimal? price;
        private string owner;
        private Display display;
        private Battery battery;
        private static GSM iPhone4S = new GSM("Apple", "IPhone4S", 1400, "Someone other than YOU, HA HA HA!!!!", new Battery("Something", 240, 120), new Display(5, "123Gh123", 256));

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
            sb.Append("\nBattery model : " + Battery.Model);
            sb.Append("\nBattery lasts in idle mode in hours : " + Battery.HoursIdle);
            sb.Append("\nBattery last while speaking in hours : " + Battery.HoursTalk);
            sb.Append("\nBattery type : " + Battery.BatteryType);
            sb.Append("\nDisplay size : " + Display.Size + "M");
            sb.Append("\nDisplay number : " + Display.Number);
            sb.Append("\nDisplay supported colors : " + Display.Color + "mbit");
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

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
    }

    public class Battery
    {
        private BatteryType batteryType;
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;

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
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
        public BatteryType BatteryType
        {
            get { return batteryType; }
        }
    }

    public class Display
    {
        private double? size;
        private string number;
        private int? color;

        public Display()
        {
        }

        public Display(double size)
            : this(size, null, 0)
        {
        }

        public Display(double size, string number)
            : this(size, number, 0)
        {
        }

        public Display(double size, string number, int color)
        {
            this.size = size;
            this.number = number;
            this.color = color;
        }
        public double? Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int? Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }

    class GSMTestClass
    {
        static void Main(string[] args)
        {
            GSM[] listOfGSMs = new GSM[3];
            listOfGSMs[0] = new GSM("Motorolla", "MTLL43123", 1000, "Gosho", new Battery("MOTONI", 300, 70, BatteryType.NiMH), new Display(6, "123312", 256));
            listOfGSMs[1] = new GSM("Samsung", "Note III", 1350, "Chicho Mitko", new Battery("SamLi", 350, 120, BatteryType.LiIon), new Display(6, "HGH123", 256));
            listOfGSMs[2] = new GSM("HTC", "OneTouch", 650, @"Baba Dona ""Skorosmurtnitzata""", new Battery("HTChinaPrimal", 10, 2, BatteryType.NiCd), new Display(4, "OOPS!", 256));

            foreach(GSM gsm in listOfGSMs)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
