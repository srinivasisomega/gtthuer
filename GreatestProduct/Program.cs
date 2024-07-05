// See https://aka.ms/new-console-template for more information
namespace GreatestProduct
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            GreatProd realNumber = new GreatProd();
            long maxProduct = realNumber.MaxProduct(number);
            Console.WriteLine("Max product of four adjacent digits: " + maxProduct);
        }
    }
}


