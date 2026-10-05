using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System;

namespace Lab3.Tests
{
    [TestClass]
    public class DesignerTests
    {
        [TestMethod]
        public void CalculateProjectCost_ReturnsCorrectCost()
        {
            Designer designer = new Designer("Дизайнер", 3, 25, "UI/UX");
            double result = designer.CalculateProjectCost(40);
            Assert.AreEqual(1500, result);
        }
        [TestMethod]
        public void CalculateMonthlySalary_ReturnsCorrectSalary()
        {
            Designer designer = new Designer("Дизайнер", 3, 25, "UI/UX");
            double result = designer.CalculateMonthlySalary(160);
            Assert.AreEqual(4000, result);
        }
        [TestMethod]
        public void EmptySpecialization_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Designer("Дизайнер", 3, 25, ""));
        }
        [TestMethod]
        public void EmptyPosition_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Designer("", 3, 25, "UI/UX"));
        }
    }
}