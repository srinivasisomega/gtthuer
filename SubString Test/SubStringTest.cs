using SubstringCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SubString_Test
{
    [TestClass]
    public class SubstringCheckTests
    {
        [TestMethod]
        public void SubstringOccurs_WhenValidInputs_ReturnsCorrectCount()
        {
            // Arrange
            string mainString = "abababab";
            string subString = "ab";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act
            int result = substringCheck.SubstringOccurs();

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SubstringOccurs_WhenEmptySubstring_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            string mainString = "abababab";
            string subString = "";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void SubstringOccurs_WhenSubstringLongerThanMainString_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            string mainString = "ab";
            string subString = "abcdef";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void SubstringOccurs_WhenMainStringContainsDigits_ThrowsArgumentException()
        {
            // Arrange
            string mainString = "ab12abab";
            string subString = "ab";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void SubstringOccurs_WhenSubstringContainsDigits_ThrowsArgumentException()
        {
            // Arrange
            string mainString = "abababab";
            string subString = "ab3";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void SubstringOccurs_WhenMainStringAndSubstringContainDigits_ThrowsArgumentException()
        {
            // Arrange
            string mainString = "ab1abab";
            string subString = "ab3";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => substringCheck.SubstringOccurs());
        }
    }
}

//namespace SubString_Test
//{
//    [TestClass]
//    public class SubstringTest
//    {

//        [TestMethod]
//        public void BasicTest()
//        {
//            //arrange//
//            string mainString = "deettresaatteefghtt";
//            string subString = "tt";
//            int expected = 3;
//            //arrange//
//            //Act//
//            SubstringCheck firstSubstring = new SubstringCheck(mainString, subString);
//            int actual = firstSubstring.SubstringOccurs();
//            //Act//
//            //assert//
//            Assert.AreEqual(actual, expected);
//            //assert//
//        }
//        [TestMethod]
//        //public void SubstringGreaterTest()
//        //{
//        //    // Arrange
//        //    string mainString = "223";
//        //    string subString = "223445";

//        //    // Act & Assert
//        //    SubstringCheck secondSubstring = new SubstringCheck(mainString, subString);
//        //    secondSubstring.SubstringOccurs();
//        //    // If the exception is thrown, the test will pass. 
//        //    // If no exception is thrown, the test will fail with the message below.
//        //    Assert.Fail("Expected ArgumentException was not thrown.");
//        //}

//        public void SubstringGreaterTest()
//        {
//            // Arrange
//            string mainString = "asd";
//            string subString = "aaaaa";

//            try
//            {
//                // Act
//                SubstringCheck secondSubstring = new SubstringCheck(mainString, subString);
//                secondSubstring.SubstringOccurs();

//                // If no exception is thrown, fail the test
//                Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
//            }
//            catch (ArgumentOutOfRangeException ex)
//            {
//                // Assert
//                Assert.AreEqual("substring length should not be greater than main string length", ex.Message);
//            }
//        }

//        [TestMethod]
//        public void MethodInputDigitCheckTest()
//        {
//            //arrange//
//            string mainString = "ar31rvuvbbybbidbb2314";
//            string subString = "bb";
//            int expected = 0;
//            //arrange//
//            //Act//
//            SubstringCheck secondSubstring = new SubstringCheck(mainString, subString);
//            int actual = secondSubstring.SubstringOccurs();
//            //Act//
//            //assert//
//            Assert.AreEqual(expected, actual);
//            //assert//
//        }

//    }
//}