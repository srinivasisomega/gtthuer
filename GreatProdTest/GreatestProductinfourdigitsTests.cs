using GreatestProduct;
using NUnit.Framework;
using System;
namespace GreatProdTest
{
    public class GreatestProductinfourdigitsTests
    {

        [TestFixture]
        public class GreatProdTests
        {
            public GreatProd _greatProd;

            [SetUp]
            public void Setup()
            {
                _greatProd = new GreatProd();
            }

            [Test]
            public void MaxProduct_Returns_Correct_Result()
            {
                // Arrange
                string number = "123456789"; // Example input

                // Act
                long result = _greatProd.MaxProduct(number);

                // Assert
                Assert.AreEqual(3024, result); // Replace with expected result based on your implementation
            }

            [Test]
            public void MaxProduct_Throws_Exception_On_NonNumeric_Input()
            {
                // Arrange
                string number = "1234abc56789"; // Input with letters

                // Act & Assert
                Assert.Throws<FormatException>(() => _greatProd.MaxProduct(number));
            }

            // Add more tests as needed for different scenarios
        }

    }
}
