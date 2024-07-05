using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SubstringCount
{
    public class SubstringCheck
    {
        public string mainString;
        public string subString;

        public SubstringCheck(string methodMainString, string methodSubString)
        {
            mainString = methodMainString;
            subString = methodSubString;
        }

        public bool ContainsDigits(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public int SubstringOccurs()
        {
            if (ContainsDigits(mainString))
            {
                throw new ArgumentException("Main string cannot contain digits.");
            }

            if (ContainsDigits(subString))
            {
                throw new ArgumentException("Substring cannot contain digits.");
            }

            int count = 0;
            int s1Length = mainString.Length;
            int s2Length = subString.Length;

            if (s2Length == 0)
            {
                throw new ArgumentOutOfRangeException("Substring should not be empty.");
            }

            if (s1Length == 0)
            {
                throw new ArgumentOutOfRangeException("Main string should not be empty.");
            }

            if (s2Length > s1Length)
            {
                throw new ArgumentOutOfRangeException("Substring length cannot be greater than main string length.");
            }

            for (int i = 0; i <= s1Length - s2Length; i++)
            {
                if (mainString.Substring(i, s2Length) == subString)
                {
                    count++;
                }
            }

            Console.WriteLine("Number of occurrences = " + count);
            return count;
        }
    }

    
}



//namespace SubstringCount
//{
//    public class SubstringCheck
//    {
//        public string mainString;
//        public string subString;

//        //class constructor for initializing main string.
//        public SubstringCheck(string methodMainString, string methodSubString)
//        {
//            mainString = methodMainString;
//            subString = methodSubString;
//        }
//        public bool StringCheck()
//        {
//            bool flag = true;
//            string[] letter = mainString.Split("");
//            for (int i =0;i<(mainString.Length)-1;i++)
//            {
//                if (Convert.ToInt32(letter[i]) >= '0' && Convert.ToInt32(letter[i]) <= '9')
//                {
//                    flag= false;
//                    break;
//                }
//                else
//                {
//                    continue;
//                }
//            }
//            return flag;
//        }
//        public int SubstringOccurs()
//        {
//            int count = 0;
//            //length of main string.
//            int s1Length = mainString.Length;
//            //length of sub string.
//            int s2Length = subString.Length;
//            //the loop runs from 0 to length of string - length of substring.
//            //
//            for (int i = 0; i <= s1Length - s2Length; i++)
//            {
//                // if the substring of main string from i index to i+(length of substring)is equal to substring if condition passes.
//                if (mainString.Substring(i,s2Length) == subString)
//                    {
//                    count++;
//                    Console.Write(i + " ");
//                }

//            }

//            Console.WriteLine("\nNo of occurrences = " + count);
//            return count;
//        }
//    }
//}
