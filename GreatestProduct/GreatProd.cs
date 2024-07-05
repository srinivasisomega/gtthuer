
namespace GreatestProduct
{
    /// <summary>
    /// Class to find the maximum product of four adjacent digits in a given number string.
    /// </summary>
    public class GreatProd
    {
        /// <summary>
        /// Finds the maximum product of four adjacent digits in the given number string.
        /// </summary>
        /// <param name="number">The string representation of the number.</param>
        /// <returns>The maximum product of four adjacent digits.</returns>
        public long MaxProduct(string number)
        {
            int length = number.Length;
            long maxProduct = 0;

            // Iterate through the number string to find the maximum product of four adjacent digits
            for (int i = 0; i <= length - 4; i++)
            {
                long product = 1;

                // Calculate product of four adjacent digits starting at index i
                for (int j = 0; j < 4; j++)
                {
                    int digit = Convert.ToInt32(number[i + j].ToString());
                    product *= digit;
                }

                // Update maxProduct if current product is greater
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }
    }
}

