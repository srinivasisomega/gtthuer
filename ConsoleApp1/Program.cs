using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Adding two Integer Numbers
            ADDNumbers(10, 20);

            //Adding Five Integer Numbers
            ADDNumbers(10, 20, new int[] { 30, 40, 50 });

            Console.ReadLine();
        }

        public static void ADDNumbers(int FN, int SN, int[] restOfTheNumbers = null)
        {
            int result = FN + SN;
            
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }
    }

