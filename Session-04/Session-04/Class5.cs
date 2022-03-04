using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class5
    {
        public Class5()
        {
        



        }
        public void Sorting(int[] array5)
        {
            for(int m = 0; m < array5.Length; m++)
{
                for (int n = 0; n < array5.Length - 1; n++)
                {
                    if (array5[n] > array5[n + 1])
                    {
                        int temp = array5[n];
                        array5[n] = array5[n + 1];
                        array5[n + 1] = temp;
                    }
                }
            }
        }
        public void PrintSort(int[] array5)
        {
            for (int m = 0; m < array5.Length; m++)
            {
                Console.Write(array5[m] + " ");
            }
        }
    }
}
