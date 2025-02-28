using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeNumber
    {
        public bool CheckPrimeNumber(int num)
        {
            for(int i = 2; i <= num - 1; i++) { 
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
