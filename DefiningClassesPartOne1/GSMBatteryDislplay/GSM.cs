using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMBatteryDislplay
{
    class GSM
    {
        private const decimal pricePerMinute = 0.25m;
        private int? price;

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, new Battery("Nqkakuv"), new Display())
        {

        }

        public GSM(string model, string manufacturer, string owner, int? price, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the price cannot be a negative value");
                }

                this.price = value;
            }
        }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public static GSM IPhone4S
        {
            get
            {
                return new GSM("IPhone4S", "Apple");
            }
        }
        public List<Call> CallHistory { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Model);
            result.Append(this.Manufacturer);
            result.Append(this.Price);
            result.Append(this.Owner);
            result.Append(this.Battery.Model);
            result.Append(this.Battery.HoursIdle);
            result.Append(this.Battery.HoursTalk);
            result.Append(this.Display.Colours);
            result.Append(this.Display.Size);

            return result.ToString();
        }

        public void AddingCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeletingCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalcBill()
        {
            decimal totalMinutes = 0;

            foreach (var call in this.CallHistory)
            {
                totalMinutes += call.DurationInSeconds / 60;
            }

            return totalMinutes * pricePerMinute;
        }

        static void Main(string[] args)
        {
            GSM Iphone = GSM.IPhone4S;

            Console.WriteLine(Iphone.ToString());
        }
    }
}
