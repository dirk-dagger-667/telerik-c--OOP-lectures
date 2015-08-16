using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanStudentWorker
{
    public class Worker : Human
    {
        private const decimal initialWeekSalary = 350;
        private const int initialWorkHoursPerDay = 9;
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName)
            :base(firstName, lastName)
        {
            this.WeekSalary = initialWeekSalary;
            this.WorkHoursPerDay = initialWorkHoursPerDay;
        }
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public decimal PaymentPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }
    }
}
