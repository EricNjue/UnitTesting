using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Tests
{
    [TestClass]
    public class MathsClassTest
    {
        [TestMethod]
        public void TestAddMethod()
        {
            //Arrange....
            MathsClass mathsClass = new MathsClass();
            int expectedResult = 10;

            //Act.....
            int actualResult = mathsClass.Add(6, 4);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            //Arrange...
            MathsClass mathsClass = new MathsClass();
            int expectedResult = 20;

            //Act.....
            int actualResult = mathsClass.Multiply(5, 4);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            //Arrange...
            MathsClass mathsClass = new MathsClass();
            int expectedResult = 1;

            //Act.....
            int actualResult = mathsClass.Subtract(5, 4);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivisionMethod()
        {
            //Arrange...
            MathsClass mathsClass = new MathsClass();
            int expectedResult = 2;

            //Act.....
            int actualResult = mathsClass.Division(10, 5);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
