using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class4
    {
        public Class4()
        {

        }
        public void MultiArrays(int[] array1,int[] array2,int[] arrayProd)
        {
            Console.WriteLine("\n\nThe number of the new array for the 4th exercise are : ");
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    arrayProd[i + k] = array1[i] * array2[k];
                    Console.Write(" " + arrayProd[i + k]);
                }
            }
        }

    }
}
