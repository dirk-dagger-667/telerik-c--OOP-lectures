using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSMBatteryDislplay
{
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private decimal durationSeconds;
        private string dailedPhoneNumber;

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public decimal DurationInSeconds
        {
            get
            {
                return this.durationSeconds;
            }
            set
            {
                this.durationSeconds = value;
            }
        }

        public string DaliedPhoneNumber
        {
            get
            {
                return this.dailedPhoneNumber;
            }
            set
            {
                this.dailedPhoneNumber = value;
            }
        }
    }
}
