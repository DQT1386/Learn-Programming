using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class NumberUtils
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
        public int ReverseNum(int num)
        {
            //2546985 =>"2546985"= ['2','5','4','6','9','8','5']
            string numString = num.ToString();
            string resultString = "";
            for(int i = numString.Length - 1;i>=0; i--)
            {
                resultString = resultString + numString[i];
            }
            int result = int.Parse(resultString);
            return result;
        }

        public void Swap(int a, int b)
        {

            
        }
    }
}
