// See https://aka.ms/new-console-template for more information
using SubstringCount;

namespace SubstringCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user for main string and substring
                Console.WriteLine("Enter the main string:");
                string mainString = Console.ReadLine();

                Console.WriteLine("Enter the substring:");
                string subString = Console.ReadLine();

                // Create instance of SubstringCheck class
                SubstringCheck stringCheck1 = new SubstringCheck(mainString, subString);
                // Call SubstringOccurs method to find occurrences
                stringCheck1.SubstringOccurs();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Catch ArgumentOutOfRangeException and display message
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Catch ArgumentException and display message
                Console.WriteLine(ex.Message);
            }
        }
    }
}
