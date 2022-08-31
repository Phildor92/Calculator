using Calculator.Backend;

namespace Calculator.Tests.ArithmeticFixtures
{
    public class ArithmeticTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TestAdd5And6_Returns11()
        {
            Assert.That(Arithmetic.Add(5, 6), Is.EqualTo(11));
        }

        [Test]
        public void Add_TestAddDoubleMaxAndDoubleMax_ReturnsPositiveInfinity()
        {
            Assert.That(Arithmetic.Add(double.MaxValue, double.MaxValue), Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void Subtract_TestSubtract44From59_Returns15()
        {
            Assert.That(Arithmetic.Subtract(59, 44), Is.EqualTo(15));
        }

        [Test]
        public void Multiply_TestMultiply5By12_Returns60()
        {
            Assert.That(Arithmetic.Multiply(5, 12), Is.EqualTo(60));
        }

        [Test]
        public void Divide_TestDivide42By7_Returns6()
        {
            Assert.That(Arithmetic.Divide(42, 7), Is.EqualTo(6));
        }

        [Test]
        public void Divide_TestDivideByZero_ThrowsArgumentException()
        {
            try
            {
                Arithmetic.Divide(54, 0);
                Assert.Fail("Exception not thrown");
            }
            catch (ArgumentException)
            {
            }
        }
    }
}
