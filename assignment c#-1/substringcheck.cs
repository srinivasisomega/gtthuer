using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using System;

namespace SubstringCount
{
    /// <summary>
    /// Class to check occurrences of a substring within a main string, with validation checks.
    /// </summary>
    public class SubstringCheck
    {
        public string mainString;
        public string subString;

        /// <summary>
        /// Constructor to initialize the main string and substring.
        /// </summary>
        /// <param name="methodMainString">The main string to search within.</param>
        /// <param name="methodSubString">The substring to search for.</param>
        public SubstringCheck(string methodMainString, string methodSubString)
        {
            mainString = methodMainString;
            subString = methodSubString;
        }

        /// <summary>
        /// Checks if a string contains any digits.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <returns>True if the string contains digits, otherwise false.</returns>
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

        /// <summary>
        /// Counts occurrences of the substring within the main string.
        /// </summary>
        /// <returns>The number of occurrences of the substring.</returns>
        /// <exception cref="ArgumentException">Thrown when main string or substring contains digits.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when substring is empty, main string is empty, or substring length exceeds main string length.</exception>
        public int SubstringOccurs()
        {
            // Check for digits in main string and substring
            if (ContainsDigits(mainString))
            {
                throw new ArgumentException("Main string cannot contain digits.");
            }

            if (ContainsDigits(subString))
            {
                throw new ArgumentException("Substring cannot contain digits.");
            }

            // Validate lengths and conditions
            int count = 0;
            string position="";
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

            // Count occurrences of substring in main string and their positions
            for (int i = 0; i <= s1Length - s2Length; i++)
            {
                if (mainString.Substring(i, s2Length) == subString)
                {
                    count++;
                    position = "positions are " + $"{i}";

                }
            }

            // Output the number of occurrences and their positions
            Console.WriteLine(position);
            Console.WriteLine("Number of occurrences = " + count);
            return count;
        }
    }
}



