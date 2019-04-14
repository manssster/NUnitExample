using NUnit.Framework;
using NUnitCalcTest.CalcLib;

namespace Tests
{
    public class Tests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            
            int num1 = 5;
            int num2 = 10;
            int result = 15;

            int actual = calc.Addition(num1, num2);
            Assert.AreEqual(result, actual);
        }


        [Test]
        public void TestDivision()
        {
            double numerator = 5;
            double denominator = 10;
            double result = 0.5;

            double actual = calc.Division(numerator, denominator);
            Assert.AreEqual(result, actual);
        }


        [Test]
        public void TestSubtraction()
        {
            int num1 = 50;
            int num2 = 10;
            int result = 40;

            int actual = calc.Subtraction(num1, num2);
            Assert.AreEqual(result, actual);
        }
    }
}