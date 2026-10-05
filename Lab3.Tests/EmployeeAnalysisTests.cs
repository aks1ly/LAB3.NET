using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System.Collections.Generic;

namespace Lab3.Tests
{
    [TestClass]
    public class EmployeeAnalysisTests
    {
        [TestMethod]
        public void CalculateTotalSalaryFund_ReturnsCorrectTotal()
        {
            List<Employee> employees = new List<Employee>
            {
                new Programmer("Програміст", 2, 20, "Junior"),
                new Designer("Дизайнер", 3, 25, "UI/UX")
            };
            double result = EmployeeAnalysis.CalculateTotalSalaryFund(employees, 160);
            Assert.AreEqual(7400, result);
        }
        [TestMethod]
        public void CalculateTotalSalaryFund_EmptyList_ReturnsZero()
        {
            List<Employee> employees = new List<Employee>();
            double result = EmployeeAnalysis.CalculateTotalSalaryFund(employees, 160);
            Assert.AreEqual(0, result);
        }
    }
}