using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanStudentWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be equal to or less than 0!");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 && value > 24)
                {
                    throw new ArgumentOutOfRangeException("The workhours per day cannot be less than 0 or more than 24!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal ReturnMoneyPerHour()
        {
            return this.weekSalary / (5 * this.workHoursPerDay);
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay): base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
    }
}
