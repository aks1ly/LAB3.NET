using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System;

namespace Lab3.Tests
{
    [TestClass]
    public class ProgrammerTests
    {
        [TestMethod]
        public void CalculateBonus_Junior_ReturnsCorrectBonus()
        {
            Programmer programmer = new Programmer("Програміст", 2, 20, "Junior");
            double result = programmer.CalculateBonus();
            Assert.AreEqual(200, result);
        }
        [TestMethod]
        public void CalculateBonus_Senior_ReturnsCorrectBonus()
        {
            Programmer programmer = new Programmer("Програміст", 5, 20, "Senior");
            double result = programmer.CalculateBonus();
            Assert.AreEqual(400, result);
        }
        [TestMethod]
        public void CalculateMonthlySalary_ReturnsSalaryWithBonus()
        {
            Programmer programmer = new Programmer("Програміст", 2, 20, "Junior");
            double result = programmer.CalculateMonthlySalary(160);
            Assert.AreEqual(3400, result);
        }
        [TestMethod]
        public void InvalidLevel_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Programmer("Програміст", 2, 20, "Middle"));
        }
        [TestMethod]
        public void EmptyPosition_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Programmer("", 2, 20, "Junior"));
        }
    }
}