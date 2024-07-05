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
            public void MaxProductReturnsCorrectResult()
            {
                /// Arrange///
                string number = "123456789";
                /// Arrange///

                /// Act ///
                long result = _greatProd.MaxProduct(number);
                ///Act///

                /// Assert ///
                Assert.AreEqual(3024, result);
                ///Assert///
            }

            [Test]
            public void MaxProductThrowsExceptionOnNonNumericInput()
            {
                /// Arrange///
                string number = "1234abc56789"; 
                ///Arrange///

                /// Act & Assert///
                Assert.Throws<FormatException>(() => _greatProd.MaxProduct(number));
                /// Act & Assert///

            }

            [Test]
            public void MaxProductWhenZero()
            {
                ///Arrange///
                string number = "309870123";
                ///Arrange//
                ///Act///
                long result = _greatProd.MaxProduct(number);
                ///Act///
                ///Assert///
                Assert.AreEqual(0, result);
                ///Assert///
                

            }
        }

    }
}
