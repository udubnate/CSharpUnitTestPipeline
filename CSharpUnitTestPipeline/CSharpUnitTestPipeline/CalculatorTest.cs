

namespace CSharpUnitTestPipeline
{
    [TestClass]
    public class CalculatorTest
    {
        public Calculator calculator;

        [TestInitialize] public void Initialize()
        {
            calculator = new Calculator();
            
        }
        [TestMethod]
        public void test_addition()
        {
            //arrange
            int num1 = 250;
            int num2 = 100;
            var result = calculator.Add(num1, num2);
            Assert.AreEqual(result, num1 + num2);
        }

        [TestMethod]
        public void test_subtract()
        {
            //arrange
            int num1 = 250;
            int num2 = 100;
            var result = calculator.Subtract(num1, num2);
            Assert.AreEqual(result, num1 - num2);
        }

        [TestMethod]
        public void test_multiply()
        {
            //arrange
            int num1 = 250;
            int num2 = 100;
            var result = calculator.Multiply(num1, num2);
            Assert.AreEqual(result, num1 * num2);
        }

        [TestMethod]
        public void test_divide()
        {
            //arrange
            int num1 = 200;
            int num2 = 100;
            var result = calculator.Divide(num1, num2);
            Assert.AreEqual(result, num1 / num2);
        }
    }
}