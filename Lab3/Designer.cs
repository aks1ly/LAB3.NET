using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Designer : Employee
    {
        private string specialization;
        private List<string> projects = new List<string>();
        public string Specialization
        {
            get { return specialization; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Спеціалізація не може бути порожньою.");
                specialization = value;
            }
        }
        public Designer(string position, int experience, double hourlyRate, string specialization)
            : base(position, experience, hourlyRate)
        {
            Specialization = specialization;
        }
        public double CalculateProjectCost(int hours)
        {
            return HourlyRate * hours * 1.5;
        }
        public override double CalculateMonthlySalary(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
        public override List<string> GetProjects()
        {
            return projects;
        }
    }
}