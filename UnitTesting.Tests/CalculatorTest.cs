using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldReturn9WhenAdd4And5()
        {
            //Arrange...
            Calculator calc = new Calculator();

            //Act.....
            int result = calc.Add(5, 4);

            //Assert...
            Assert.AreEqual(9, result);
        }



        [TestMethod]
        public void ShouldReturn20WhenMultiply4And5()
        {
            //Arrange...
            Calculator calc = new Calculator();

            //Act.....
            int result = calc.Multiply(5, 4);

            //Assert...
            Assert.AreEqual(20, result);
        }
    }
}
