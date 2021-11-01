using CalculatorLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {

//the below 10 test methods are for Addition unit test checks

        [TestMethod]
        public void AdditionUnitTestCheck1()
        {
            double num1 = 0;
            double num2 = 0;
            double desired = 0;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck2()
        {
            double num1 = 7;
            double num2 = 3;
            double desired = 10;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck3()
        {
            double num1 = 15;
            double num2 = 14;
            double desired = 29;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck4()
        {
            double num1 = 23;
            double num2 = 11;
            double desired = 34;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck5()
        {
            double num1 = 33;
            double num2 = 9;
            double desired = 42;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck6()
        {
            double num1 = 17;
            double num2 = 11;
            double desired = 28;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck7()
        {
            double num1 = 53;
            double num2 = 7;
            double desired = 60;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck8()
        {
            double num1 = 61;
            double num2 = 3;
            double desired = 64;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck9()
        {
            double num1 = 77;
            double num2 = 5;
            double desired = 82;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void AdditionUnitTestCheck10()
        {
            double num1 = 88;
            double num2 = 11;
            double desired = 99;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }
    }
}
