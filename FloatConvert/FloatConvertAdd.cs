namespace FloatConvert
{
    /// <summary>
    /// This class provides methods, which work together to perform binary addition between two floats.
    /// 2)convert decimal part of a float to a binary string format.
    /// 3)Performs Binary addition to two integer parts in binary string format from two floats.
    /// 4)Performs Binary addition to two decimal parts in binary string format from two floats.
    /// 5)Converts binary strings of integer part to an int data type.
    /// 6)Converts binary strings of decimal parts to a float datatype.
    /// </summary>
    public class FloatConvertAdd
    {
        /// <summary>
        /// Convert integer part of a float to a binary string format.
        /// </summary>
        /// <param name="number">integer part of the float.</param>
        /// <returns>Binary string of integer part of float.</returns>
        
        public string ConvertToBinary(int number)
        {
            if (number == 0)
                return "0";

            string result = "";
            while (number > 0)
            {
                result = (number % 2) + result;
                number /= 2;
            }
            return result;
        }

        /// <summary>
        /// Converts a decimal number to its binary form.
        /// </summary>
        /// <param name="number">The decimal part of float.</param>
        /// <returns>The binary string of the decimal number.</returns>
        public string ConvertDecimalToBinary(float number)
        {
            string result = "";
            while (number > 0)
            {
                number *= 2;
                if (number >= 1)
                {
                    result += "1";
                    number -= 1;
                }
                else
                {
                    result += "0";
                }

            }
            return result;
        }

        /// <summary>
        /// Adds two binary integer parts from two different floats(float1,float2).
        /// </summary>
        /// <param name="bin1">The integer part of float1 in binary form.</param>
        /// <param name="bin2">The integer part of float2 in binary form.</param>
        /// <returns>The sum of the two binary integers.</returns>
        public string AddBinaryIntegers(string bin1, string bin2)
        {
            int length = bin1.Length > bin2.Length ? bin1.Length : bin2.Length;
            bin1 = bin1.PadLeft(length, '0');
            bin2 = bin2.PadLeft(length, '0');

            string result = "";
            int carry = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                int bit1 = bin1[i] - '0';
                int bit2 = bin2[i] - '0';

                int sum = bit1 + bit2 + carry;
                result = (sum % 2) + result;
                carry = sum / 2;
            }

            if (carry > 0)
            {
                result = carry + result;
            }

            return result;
        }

        /// <summary>
        /// Adds two binary decimal parts from two different floats(float1,float2).
        /// </summary>
        /// <param name="bin1">The decimal part of float1 in binary form.</param>
        /// <param name="bin2">The decimal part of float2 in binary form.</param>
        /// <returns>A tuple containing the sum of the two binary decimals as a float and the overflow bit as a string.</returns>
        public (float, string) AddBinaryDecimals(string bin1, string bin2)
        {

            int length = bin1.Length > bin2.Length ? bin1.Length : bin2.Length;
            bin1 = bin1.PadRight(length, '0');
            bin2 = bin2.PadRight(length, '0');

            string result = "";
            int decCarry = 0;

            for (int i = length - 1; i >= 0; i--)
            {
                int bit1 = bin1[i] - '0';
                int bit2 = bin2[i] - '0';

                int sum = bit1 + bit2 + decCarry;
                result = (sum % 2) + result;
                decCarry = sum / 2;
            }

            return (ConvertBinaryToDecimal(result), decCarry > 0 ? "1" : "0");
        }

        /// <summary>
        /// Converts a binary integer represented as a string to its decimal equivalent.
        /// </summary>
        /// <param name="binary">The binary integer as a string.</param>
        /// <returns>The decimal equivalent of the binary integer.</returns>
        public int ConvertBinaryToInt(string binary)
        {
            int result = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - 1 - i] == '1')
                {
                    result += (1 << i);
                }
            }
            return result;
        }

        /// <summary>
        /// Converts a binary decimal represented as a string to its float equivalent.
        /// </summary>
        /// <param name="binary">The binary decimal as a string.</param>
        /// <returns>The float equivalent of the binary decimal.</returns>
        public float ConvertBinaryToDecimal(string binary)
        {
            float result = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    result += 1.0f / (1 << (i + 1));
                }
            }
            return result;
        }
    }
}




