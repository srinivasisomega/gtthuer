namespace FloatConvert
{
    /// <summary>
    /// 
    /// </summary>
    class FloatConvertAdd
    {
        

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
        //
        public string ConvertDecimalToBinary(float number, int precision)
        {
            string result = "";
            while (number > 0 && precision > 0)
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
                precision--;
            }
            return result;
        }

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
    //class Program
    //{
    //    decimal input;
    //    BigInteger bibiNum;
    //    string strbiNum = "";
    //    int intpart;
    //    decimal decpart;



    //    public static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        obj.separatingIntandDec();
    //        string c=obj.intToBinary();
    //        string a = obj.decToBinary();
    //        Program obj2 = new Program();
    //        obj2.separatingIntandDec();
    //        string d=obj2.intToBinary();
    //        string b = obj2.decToBinary();
    //        string y=Program.BinaryAddIntegers(a, b);
    //        //Console.WriteLine(y);
    //        //string z=Program.BinaryAddFractions(a, b);
    //        //string popld = $"{y}.{z}";
    //        //Console.WriteLine(popld);


    //    }

    //    public Program()
    //    {

    //        Console.WriteLine("Enter a float value");
    //        input = Convert.ToDecimal(Console.ReadLine());
    //        //Console.WriteLine(input);

    //    }

    //    public void separatingIntandDec()
    //    {


    //        intpart = Convert.ToInt32(Math.Floor(input));
    //        decpart = 0.0m;
    //        decpart = (input % intpart);


    //        Console.WriteLine(intpart);
    //        Console.WriteLine(decpart);

    //    }

    //    public string intToBinary()
    //    {
    //        int tempInt = intpart;

    //        while (tempInt != 0)
    //        {
    //            strbiNum = $"{tempInt % 2}" + strbiNum;
    //            tempInt = tempInt / 2;
    //        }
    //        Console.WriteLine(strbiNum);
    //        return strbiNum;


    //    }

    //    public string decToBinary()
    //    {
    //        int i = 0;
    //        decimal tempFloat = decpart;
    //        int tempInt = 0;
    //        string tempString = "";

    //        while (i < 8)
    //        {
    //            tempFloat = tempFloat * 2;
    //            if (tempFloat > 1)
    //            {
    //                tempString += "1";
    //                tempFloat = tempFloat - 1;
    //            }
    //            else
    //            {
    //                tempString += "0";
    //            }
    //            i++;
    //        }

    //        Console.WriteLine(tempString);

    //        strbiNum = $"{strbiNum}.{tempString}";
    //        return strbiNum;
    //        //decimal binarynumber = Convert.ToDecimal(strbiNum);
    //        //Console.WriteLine(binarynumber);
    //        //Console.WriteLine(strbiNum);

    //    }




    //    private static string BinaryAddIntegers(string binary1, string binary2)
    //    {
    //        // Split binary strings into integer and fractional parts
    //        string[] parts1 = binary1.Split('.');
    //        string[] parts2 = binary2.Split('.');

    //        // Pad integer parts with leading zeros to ensure they have the same length
    //        string intPart1 = parts1[0];
    //        string intPart2 = parts2[0];
    //        string intPart12 = parts1[1];
    //        string intPart22 = parts2[1];
    //        int maxLength1 = Math.Max(intPart1.Length, intPart2.Length);
    //        string maxLength2 = Math.Max(intPart12.Length, intPart22.Length);
    //        intPart1 = intPart1.PadLeft(maxLength1, '0');
    //        intPart2 = intPart2.PadLeft(maxLength1, '0');
    //        intPart12= intPart1.PadRight(maxLength2, '0');
    //        intPart22 = intPart2.PadRight(maxLength2, '0');

    //        // Initialize result array and carry
    //        char[] result = new char[maxLength];
    //        int carry = 0;

    //        // Perform binary addition column by column, from right to left
    //        for (int i = maxLength - 1; i >= 0; i--)
    //        {
    //            int bit1 = intPart1[i] - '0';
    //            int bit2 = intPart2[i] - '0';

    //            // Calculate sum of current bits and carry
    //            int sum = bit1 + bit2 + carry;

    //            // Determine the resulting bit and carry
    //            result[i] = (char)(sum % 2 + '0');
    //            carry = sum / 2;
    //        }

    //        // If there's a carry left at the end, prepend it to the result
    //        if (carry > 0)
    //        {
    //            return '1' + new string(result);
    //        }
    //        else
    //        {
    //            return new string(result);
    //        }
    //    }
    //}





    //private static string BinaryAddIntegers(string binary1, string binary2)
    //{
    //    // Ensure both binary strings have the same length by padding with leading zeros
    //    int fpa = binary1.Length;
    //    int pda = binary2.Length;

    //    if (fpa > pda)
    //    {
    //        int dif = fpa - pda;
    //        binary2 = binary2.PadLeft(dif, '0');
    //    }
    //    else if (fpa < pda)
    //    {
    //        int dif2 = pda - fpa;
    //        binary1 = binary1.PadLeft(dif2, '0');

    //    }
    //    Console.WriteLine($"INTBINPART{binary1}");

    //    int newlen = binary1.Length;
    //    char[] result1 = new char[newlen];
    //    int carry = 0;

    //    // Perform binary addition column by column, from left to right
    //    for (int i = newlen-1; i >= 0; i--)
    //    {
    //        int bit1 = binary1[i] - '0';
    //        Console.WriteLine($" binary1bit{bit1}");
    //        int bit2 = binary2[i] - '0';
    //        Console.WriteLine($" binary2bit{bit2}");
    //        // Calculate sum of current bits and carry
    //        int sum = bit1 + bit2 + carry;

    //        // Determine the resulting bit and carry
    //        result1[i] = (char)(sum % 2 + '0');
    //        carry = sum / 2;
    //    }

    //    // If there's a carry left at the end, prepend it to the result
    //    if (carry > 0)
    //    {
    //        Console.WriteLine($"result1{result1}");
    //        return '1' + new string(result1);
    //    }
    //    else
    //    {

    //        return new string(result1);
    //    }
    //}

    //private static string BinaryAddFractions(string binary1, string binary2)
    //{
    //    // Ensure both binary strings have the same length by padding with trailing zeros
    //    //int maxLength = Math.Max(binary1.Length, binary2.Length);
    //    //Console.WriteLine($"maxlength:{maxLength}");
    //    //binary1 = binary1.PadRight(maxLength, '0');
    //    //Console.WriteLine(binary1);
    //    //binary2 = binary2.PadRight(maxLength, '0');
    //    //Console.WriteLine(binary2);
    //    int fpa= binary1.Length;
    //    int pda= binary2.Length;

    //    if (fpa > pda)
    //    {
    //        int dif = fpa - pda;
    //        binary2 = binary2.PadRight(dif, '0');
    //    }
    //    else if(fpa < pda)
    //    {
    //        int dif2 = pda - fpa;
    //        binary1 = binary1.PadRight(dif2, '0');

    //    }

    //    int newlen = binary1.Length;
    //    char[] result = new char[newlen];
    //    int carry = 0;

    //    // Perform binary addition column by column, from left to right
    //    for (int i = 0; i < newlen; i++)
    //    {
    //        int bit1 = binary1[i] - '0';
    //        int bit2 = binary2[i] - '0';

    //        // Calculate sum of current bits and carry
    //        int sum = bit1 + bit2 + carry;

    //        // Determine the resulting bit and carry
    //        result[i] = (char)(sum % 2 + '0');
    //        carry = sum / 2;
    //    }
    //   Console.WriteLine(result);
    //    return new string(result);

    //}

}

//namespace FloatConvert
//{

//public class FloatToBinConverter
//{
//    public int FloatToBinNum(float value) {
//        float temp = 0;
//        while(value > 0)
//        {
//            temp = value % 2;
//            value = value / 2;


//        }

//    }
//}
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Enter the First Decimal Number: ");
//            int number1 = int.Parse(Console.ReadLine());

//            Console.Write("Enter the Second Decimal Number: ");
//            int number2 = int.Parse(Console.ReadLine());

//            // Convert decimal numbers to binary strings
//            string binaryString1 = DecimalToBinary(number1);
//            string binaryString2 = DecimalToBinary(number2);

//            // Perform binary addition (convert binary strings back to integers for addition)
//            int binarySum = BinaryToDecimal(binaryString1) + BinaryToDecimal(binaryString2);

//            // Convert the binary sum to a float value using IEEE 754 representation
//            float floatResult = BinaryToFloat(binarySum);

//            // Print the resulting float value
//            Console.WriteLine($"Float Result: {floatResult}");

//            Console.ReadKey();
//        }

//        // Method to convert decimal number to binary string
//        public static string DecimalToBinary(int number)
//        {
//            // Handle special case of zero
//            if (number == 0)
//            {
//                return "0";
//            }

//            // Calculate binary representation
//            string binary = "";
//            while (number > 0)
//            {
//                binary = (number % 2) + binary; // Prepend remainder to binary string
//                number = number / 2;
//            }

//            return binary;
//        }

//        // Method to convert binary string to decimal integer
//        public static int BinaryToDecimal(string binary)
//        {
//            // Convert binary string to integer
//            int decimalValue = Convert.ToInt32(binary, 2);

//            return decimalValue;
//        }

//        // Method to convert integer (IEEE 754 bit representation) to float
//        public static float BinaryToFloat(int value)
//        {
//            // Interpret the integer bits as float using unsafe code
//            return BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
//        }
//    }
//}

//namespace FloatConvert
//{
//    using System;

//    public class Program
//    {


//        // Method to convert decimal number to binary string
//        public static int BinaryToDecimal(string binary)
//        {
//            // Convert binary string to integer
//            int decimalValue = Convert.ToInt32(binary, 2);

//            return decimalValue;
//        }
//        public static string DecimalToBinary(int number)
//        {
//            // Handle special case of zero
//            if (number == 0)
//            {
//                return "0";
//            }

//            // Calculate binary representation
//            string binary = "";
//            while (number > 0)
//            {
//                binary = (number % 2) + binary; // Prepend remainder to binary string
//                number = number / 2;
//            }

//            return binary;
//        }
//    }

//public class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the Decimal Number : ");
//        int number = int.Parse(Console.ReadLine());

//        Console.ReadKey();
//    }
//    public int Con(int number) { 
//        int i;
//        int Binnum = 0;
//        int[] numberArray = new int[10];
//        for (i = 0; number > 0; i++)
//        {
//            numberArray[i] = number % 2;
//            number = number / 2;
//        }
//        Console.WriteLine("Binary Represenation of the given Number : ");
//        for (i = i - 1; i >= 0; i--)
//        {
//            Binnum += Convert.ToInt32(numberArray[i]) * Convert.ToInt32(Math.Pow(10, i));
//        }
//        return Binnum;

//    }
//}
//    internal class ConvertFloatNumbers
//    {
//        public float n1;
//        public static void Main(string[] args)
//        {
//            Console.Write("Enter the Decimal Number: ");
//            float number1 = float.Parse(Console.ReadLine());
//            float number2 = float.Parse(Console.ReadLine());
//            ConvertFloatNumbers g = new ConvertFloatNumbers();

//            // Calculate binary representation as a string
//            int binaryString1 = g.BinAdd(number1);
//            int binaryString2 = g.BinAdd(number2);
//            int Result = binaryString1 + binaryString2;
//            Console.WriteLine(Result);

//            Console.ReadKey();
//        }
//        public int BinAdd(float number)
//        {
//            int i;
//            int bin = 0;
//            int[] numberArray = new int[50];
//            for (i = 0; number > 0; i++)
//            {
//                numberArray[i] = Convert.ToInt32(number % 2);
//                number = number / 2;
//            }
//            Console.Write("Binary Represenation of the given Number : ");
//            for (i = i - 1; i >= 0; i--)
//            {
//                bin += Convert.ToInt32(numberArray[i]) * Convert.ToInt16(Math.Pow(10, i));
//            }
//            return bin;
//        }
//    }
//}
//}


