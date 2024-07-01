using System;
namespace NamedParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Test(1, 2); 
            Test(b: 1, c: 2);

            
            Test(b: 1, c: 2, a: 10);
            Console.ReadLine();
        }

        public static void Test(int a=10,int b, int c = 10)
        {
            Console.WriteLine($"a = {a}, b = {b}, c= {c}");
        }
    }
}