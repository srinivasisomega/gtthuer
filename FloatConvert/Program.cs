﻿using FloatConvert;
class Program
{
    static void Main()
    {
        FloatConvertAdd firstFloat = new FloatConvertAdd();
        FloatConvertAdd secondFloat = new FloatConvertAdd();
        Console.Write("Enter the first float value whose length does not exceed 6 digits: ");
        float float1 = float.Parse(Console.ReadLine());
        Console.Write("Enter the second float value whose length does not exceed 6 digits: ");
        float float2 = float.Parse(Console.ReadLine());
        // converting integer part of float to binary values
        string binaryIntPart1 = firstFloat.ConvertToBinary((int)float1);
        string binaryIntPart2 = secondFloat.ConvertToBinary((int)float2);
        // Converting decimal values to binary values
        string binaryDecPart1 = firstFloat.ConvertDecimalToBinary(float1 -(int)float1);
        string binaryDecPart2 = secondFloat.ConvertDecimalToBinary(float2 - (int)float2);
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
        Console.WriteLine($"The result of the addition is: {intSum + binaryDecSum}");
    }
}