// See https://aka.ms/new-console-template for more information
using SubstringCount;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the main string:");
            string mainString = Console.ReadLine();

            Console.WriteLine("Enter the substring:");
            string subString = Console.ReadLine();

            SubstringCheck stringCheck1 = new SubstringCheck(mainString, subString);
            stringCheck1.SubstringOccurs();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}