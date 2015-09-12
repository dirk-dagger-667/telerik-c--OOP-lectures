using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
//Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
//Add a method in the GSM class for displaying all information about it. Try to override ToString().
//Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.
//Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.
//Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
//Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
//Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
//Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.


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
