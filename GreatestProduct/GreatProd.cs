using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace GreatestProduct
    //
{
    public class GreatProd
    {
        public long MaxProduct(string number)
        {
            int length = number.Length;
            long maxProduct = 0;
            //the first loop(outer loop) increments 0 to length_of_number-4, because inner loop will go out of out of bounds.
            for (int i = 0; i <= length - 4; i++)
            {
                //
                long product = 1;
                //the inner loop increments from i value to i+3 index.
                for (int j = 0; j < 4; j++)
                {
                    int digit = Convert.ToInt32(number[i + j].ToString());
                    //the digit in current value of i is multiplied with 3 digits followed by current i value.
                    product *= digit;
                }
                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }
            return maxProduct;
        }
    }

    
}
