using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeUnitTest;

namespace PracticeUnitTest.Test
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void AddTest()
        {
            Calculator target = new Calculator();
            Assert.AreEqual(target.Add(1,2), 3);
        }
    }
}
