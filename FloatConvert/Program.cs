// See https://aka.ms/new-console-template for more information
//using System;

//namespace FloatConvert
//{
//    public class SumOfFloats
//    {
//        public static void Main(string[] args)
//        {
//            //the aim of this code block is to seperate the decimal and interger parts of the float
//            //I tried to get the decimal part by using number-b it was not the exact decimal value
//            //hence i used %
//            float number1 = float.Parse(Console.ReadLine());
//            Console.WriteLine(number1);
//            float number2 = float.Parse(Console.ReadLine());
//            int b = Convert.ToInt32(Math.Floor(number1));
//            Console.WriteLine(b);
//            //float deci=number1-b doesnot give exact decimal value
//            float deci = number1 % b;
//            int c = Convert.ToInt32(Math.Floor(number2));
//            float deci2 = number2 % c;
//            SumOfFloats a= new SumOfFloats();
//            float intenumber1 = a.BinAdd(b);
//            float intenumber2 = a.BinAdd(c);




//        }

//        public float BinAdd(float number)
//        {
//            int i;
//            float bin = 0;
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
//        public float DeciAdd(float number)
//        {

//        }
//    }
//}