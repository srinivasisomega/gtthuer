namespace GreatestProduct
{
    class Program
    {
        /// <summary>
        /// Main entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            // Prompt user to enter the number
            Console.WriteLine("Enter the number:");
            string number = Console.ReadLine();

            // Create instance of GreatProd class
            GreatProd realNumber = new GreatProd();

            // Calculate the maximum product of four adjacent digits
            long maxProduct = realNumber.MaxProduct(number);

            // Display the result to the user
            Console.WriteLine("Max product of four adjacent digits: " + maxProduct);
        }
    }
}
