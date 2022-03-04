using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Class2
    {
        public Class2()
        {
            
        }

        public int GetProduct(int number2)
        {
            int prod = 1;
            for (int i = 1; i <= number2; i++)
            {
                prod = prod * i;
            }
            return prod;
        }

        public int GetSum(int number2)
        {
            int sum = 0;
            for (int i = 1; i <= number2; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
