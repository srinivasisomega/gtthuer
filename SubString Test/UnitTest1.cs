using SubstringCount;
namespace SubString_Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void BasicTest()
        {
            //arrange//
            string mainString = "deettresaatteefghtt";
            string subString = "tt";
            int expected = 3;
            //arrange//
            //Act//
            SubstringCheck firstSubstring = new SubstringCheck(mainString, subString);
            int actual = firstSubstring.SubstringOccurs();
            //Act//
            //assert//
            Assert.AreEqual(actual, expected);
            //assert//
        }
        [TestMethod]
        //public void SubstringGreaterTest()
        //{
        //    // Arrange
        //    string mainString = "223";
        //    string subString = "223445";

        //    // Act & Assert
        //    SubstringCheck secondSubstring = new SubstringCheck(mainString, subString);
        //    secondSubstring.SubstringOccurs();
        //    // If the exception is thrown, the test will pass. 
        //    // If no exception is thrown, the test will fail with the message below.
        //    Assert.Fail("Expected ArgumentException was not thrown.");
        //}
       
        public void SubstringGreaterTest()
        {
            // Arrange
            string mainString = "223";
            string subString = "223445";

            try
            {
                // Act
                SubstringCheck secondSubstring = new SubstringCheck(mainString, subString);
                secondSubstring.SubstringOccurs();

                // If no exception is thrown, fail the test
                Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Assert
                Assert.AreEqual("substring length should not be greater than main string length", ex.Message);
            }
        }

        [TestMethod]
        public void MethodInputDigitCheckTest()
        {
            //arrange//
            string mainString = "ar31rvuvbbybbidbb2314";
            string subString = "bb";
            int expected = 0;
            //arrange//
            //Act//
            SubstringCheck secondSubstring = new SubstringCheck(mainString, subString);
            int actual = secondSubstring.SubstringOccurs();
            //Act//
            //assert//
            Assert.AreEqual(expected, actual);
            //assert//
        }

    }
}