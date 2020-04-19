using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using asp.netprojectwithUnitTestCase;


namespace asp.netprojectwithUnitTestCase.Tests
{
    [TestClass]
    public class CalcualtionUnitTest
    {
        [TestMethod]
        public void AddTestCase()
        {

            // Assert.AreEqual(1)
            asp.netprojectwithUnitTestCase.MathOperator mathOps = new asp.netprojectwithUnitTestCase.MathOperator();
           int actualvalue=  mathOps.Add(2, 3);
            int expectedvalue = 5;
            Assert.AreEqual(expectedvalue, actualvalue, 0, "Addition Method was failed");
        }

        [TestMethod]

        public void SubtractTestCase()
        {

            // Assert.AreEqual(1)
            asp.netprojectwithUnitTestCase.MathOperator mathOps = new asp.netprojectwithUnitTestCase.MathOperator();
            int actualvalue = mathOps.Sub(3, 2);
            int expectedvalue = 1;
            Assert.AreEqual(expectedvalue, actualvalue, 0, "Subtraction Method was failed");
        }
    }
}
