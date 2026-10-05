using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class EmployeeAnalysis
    {
        public static double CalculateTotalSalaryFund(List<Employee> employees)
        {
            double total = 0;
            foreach (Employee employee in employees)
            {
                total += employee.CalculateMonthlySalary(employee.HoursWorked);
            }
            return total;
        }
    }
}