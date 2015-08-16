using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call
{
    public class Call
    {
        private DateTime dateOfCall;
        private TimeSpan timeOfCall;
        private string dailedPhoneNumber;
        private int durationOfCall;

        public Call(DateTime dateOfCall, DateTime timeOfCall, string dailedPhoneNumber, int duration)
        {
            this.dateOfCall = DateTime.Now.Date;
            this.timeOfCall = DateTime.Now.TimeOfDay;
            this.dailedPhoneNumber = dailedPhoneNumber;
            this.durationOfCall = duration;
        }

        public DateTime DateOfCall
        {
            get { return this.dateOfCall; }
        }
        public TimeSpan TimeOfCall
        {
            get { return this.timeOfCall; }
        }
        public string DailedPhoneNumber
        {
            get { return this.dailedPhoneNumber; }
        }
        public int DurationOfCall
        {
            get { return this.durationOfCall; }
        }

    }
}
