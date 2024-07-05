using FloatConvert;
namespace FloatConvertTest
{
    public class FloatAddTests
    {
        FloatConvertAdd firstFloat;
        FloatConvertAdd secondFloat;
        [SetUp]

        public void Setup()
        {
            firstFloat = new FloatConvertAdd();
            secondFloat = new FloatConvertAdd();
        }

        [Test]
        public void FloatsWithDifferentLength()
        {
            ///arrange///
            float float1 = 12.321456f;
            float float2 = 324.56732f;
            float expected = 336.888776f;
            ///arrange///
            ///act///
            string binaryIntPart1 = firstFloat.ConvertToBinary((int)float1);
            string binaryIntPart2 = secondFloat.ConvertToBinary((int)float2);
            // Converting decimal values to binary values
            string binaryDecPart1 = firstFloat.ConvertDecimalToBinary(float1 - (int)float1, 50);
            string binaryDecPart2 = secondFloat.ConvertDecimalToBinary(float2 - (int)float2, 50);
            // Adding binary forms of integer part
            string binaryIntSum = secondFloat.AddBinaryIntegers(binaryIntPart1, binaryIntPart2);
            // Adding binary forms of decimal values
            (float binaryDecSum, string carryOver) = secondFloat.AddBinaryDecimals(binaryDecPart1, binaryDecPart2);
            // Since adding decimal values can give integer values we need to add that to integer part of the number.
            if (carryOver == "1")
            {
                binaryIntSum = secondFloat.AddBinaryIntegers(binaryIntSum, "1");
            }
            //Converting binary forms to int and decimal
            int intSum = secondFloat.ConvertBinaryToInt(binaryIntSum);
            float floatSum = intSum + binaryDecSum;
            ///act///
            ///assert///

            Assert.AreEqual(expected, floatSum);
            ///assert///
        }
        [Test]
        public void FloatsWithCarryFromDecimal()
        {
            ///arrange///
            float float1 = 12.521456f;
            float float2 = 324.56732f;
            float expected = 337.088776f;
            ///arrange///
            ///act///
            string binaryIntPart1 = firstFloat.ConvertToBinary((int)float1);
            string binaryIntPart2 = secondFloat.ConvertToBinary((int)float2);
            // Converting decimal values to binary values
            string binaryDecPart1 = firstFloat.ConvertDecimalToBinary(float1 - (int)float1, 50);
            string binaryDecPart2 = secondFloat.ConvertDecimalToBinary(float2 - (int)float2, 50);
            // Adding binary forms of integer part
            string binaryIntSum = secondFloat.AddBinaryIntegers(binaryIntPart1, binaryIntPart2);
            // Adding binary forms of decimal values
            (float binaryDecSum, string carryOver) = secondFloat.AddBinaryDecimals(binaryDecPart1, binaryDecPart2);
            // Since adding decimal values can give integer values we need to add that to integer part of the number.
            if (carryOver == "1")
            {
                binaryIntSum = secondFloat.AddBinaryIntegers(binaryIntSum, "1");
            }
            //Converting binary forms to int and decimal
            int intSum = secondFloat.ConvertBinaryToInt(binaryIntSum);
            float floatSum = intSum + binaryDecSum;
            ///act///
            ///assert///

            Assert.AreEqual(expected, floatSum);
            ///assert///
        }
        [Test]
        public void DecimalWithCarry()
        {
            ///arrange///
            float float1 = 12.341456f;
            float float2 = 324.56732f;
            float expected = 336.908776f;
            ///arrange///
            ///act///
            string binaryIntPart1 = firstFloat.ConvertToBinary((int)float1);
            string binaryIntPart2 = secondFloat.ConvertToBinary((int)float2);
            // Converting decimal values to binary values
            string binaryDecPart1 = firstFloat.ConvertDecimalToBinary(float1 - (int)float1, 50);
            string binaryDecPart2 = secondFloat.ConvertDecimalToBinary(float2 - (int)float2, 50);
            // Adding binary forms of integer part
            string binaryIntSum = secondFloat.AddBinaryIntegers(binaryIntPart1, binaryIntPart2);
            // Adding binary forms of decimal values
            (float binaryDecSum, string carryOver) = secondFloat.AddBinaryDecimals(binaryDecPart1, binaryDecPart2);
            // Since adding decimal values can give integer values we need to add that to integer part of the number.
            if (carryOver == "1")
            {
                binaryIntSum = secondFloat.AddBinaryIntegers(binaryIntSum, "1");
            }
            //Converting binary forms to int and decimal
            int intSum = secondFloat.ConvertBinaryToInt(binaryIntSum);
            float floatSum = intSum + binaryDecSum;
            ///act///
            ///assert///

            Assert.AreEqual(expected, floatSum);
            ///assert///
        }
        

    }
}