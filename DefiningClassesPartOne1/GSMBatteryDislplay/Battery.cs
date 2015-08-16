using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSMBatteryDislplay
{
    public class Battery
    {
        private BatteryType? batteryType;
        private int? hoursTalk;
        private int? hoursIdle;

        public Battery(string model): this(model, null, null, null) {}
        public Battery(string model ,int? hoursIdle, int? hoursTalk, BatteryType? batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = HoursTalk;
        }

        public BatteryType? BatteryType {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
        public int? HoursIdle {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the number of hours while idle of the battery cannot be a negative number");
                }

                this.hoursIdle = value;
            }
        }
        public int? HoursTalk {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the number of hours while talking of the battery cannot be a negative number");
                }

                this.hoursTalk = value;
            }
        }
        public string Model { get; set; }
    }
}
