using SubstringCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SubString_Test
{
    [TestClass]
    public class SubstringCheckTests
    {
        [TestMethod]
        public void ValidInputs_ReturnsCorrectCount()
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
        public void EmptySubstring()
        {
            // Arrange
            string mainString = "abababab";
            string subString = "";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void SubstringLongerThanMainString()
        {
            // Arrange
            string mainString = "ab";
            string subString = "abcdef";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void MainStringContainsDigits()
        {
            // Arrange
            string mainString = "ab12abab";
            string subString = "ab";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void WhenSubstringContainsDigits()
        {
            // Arrange
            string mainString = "abababab";
            string subString = "ab3";
            SubstringCheck substringCheck = new SubstringCheck(mainString, subString);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => substringCheck.SubstringOccurs());
        }

        [TestMethod]
        public void MainStringAndSubstringContainDigits()
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

