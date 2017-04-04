using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.Tests
{
    [TestClass]
    public class AdvancedMathsClassTest
    {
        [TestMethod]
        public void TestIsEvenMethod()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = true;

            //Act...
            bool actualResult = advancedMathsClass.IsEven(2);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsNotEvenMethod()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = false;

            //Act...
            bool actualResult = advancedMathsClass.IsEven(3);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsOddMethod_WithOddNumber()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = true;

            //Act...
            bool actualResult = advancedMathsClass.IsOdd(7);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsOddMethod_WithNonOddNumber()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = false;

            //Act...
            bool actualResult = advancedMathsClass.IsOdd(2);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsPrimeMethod_WithNegativeValue()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = false;

            //Act...
            bool actualResult = advancedMathsClass.IsPrime(-10);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        //2,3,7,13,71,89,149,199
        [TestMethod]
        public void TestIsPrimeMethod_WithPrimeNumber()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = true;

            //Act...
            bool actualResult = advancedMathsClass.IsPrime(199);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsPrimeMethod_WithNonPrimeNumber()
        {
            //Arrange...
            AdvancedMathsClass advancedMathsClass = new AdvancedMathsClass();
            bool expectedResult = false;

            //Act...
            bool actualResult = advancedMathsClass.IsPrime(4);

            //Assert...
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
