using System;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string fName, string lName, decimal weekSalary, int workHoursPerDay)
            : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            decimal result = 0;
            result = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return result;
        }
    }
}
