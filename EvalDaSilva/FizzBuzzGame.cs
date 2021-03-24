using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalDaSilva
{
    
    public class FizzBuzzGame 
    {
        public static String BobRepond(int nb)
        {
            AllowedValue(nb);

            if (nb % 3 == 0 && nb % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (nb % 3 == 0)
            {
                return "Fizz";
            }
            if (nb % 5 == 0)
            {
                return "Buzz";
            }

            return nb.ToString();
        } 

        private static void AllowedValue(int nb) {
            if (nb <= 0)
            {
                throw new Exception(); 
            }
        }

    }
    
}
