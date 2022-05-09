using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTS;


namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding()
        {
            //arrange
            double firstNum = 1;
            double secondNum = 2;
            double expected = 3;
            Calculator calculator = new Calculator();

            //act
            double actual = calculator.Addition(firstNum, secondNum);

            //assert
            Assert.AreEqual(expected, actual, 0.001, "Addition not accurate!");

        }

        [TestMethod]
        public void Subtracting()
        {
            //arrange
            double firstNum = 3;
            double secondNum = 2;
            double expected = 1;
            Calculator calculator = new Calculator();

            //act
            double actual = calculator.Subtraction(firstNum, secondNum);

            //assert
            Assert.AreEqual(expected, actual, 0.001, "Subtraction not accurate!");
        }

        [TestMethod]
        public void Multipying()
        {
            //arrange
            double firstNum = 3;
            double secondNum = 3;
            double expected = 9;
            Calculator calculator = new Calculator();

            //act
            double actual = calculator.Multiplication(firstNum, secondNum);

            //assert
            Assert.AreEqual(expected, actual, 0.001, "Multiplication not accurate!");
        }

        [TestMethod]
        public void Dividing()
        {
            //arrange
            double firstNum = 12;
            double secondNum = 2;
            double expected = 6;
            Calculator calculator = new Calculator();

            //act
            double actual = calculator.Division(firstNum, secondNum);

            //assert
            Assert.AreEqual(expected, actual, 0.001, "Division not accurate!");
        }
    }
}