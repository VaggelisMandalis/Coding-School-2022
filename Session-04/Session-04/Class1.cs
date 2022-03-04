using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Class1
    {
        public Class1()
        {


        }
        public string ReverseString(string name)
        {
            int length = name.Length - 1;
            string reverseName = string.Empty;
            while (length >= 0)
            {

                reverseName = reverseName + name[length];
                length--;
            }


            return reverseName;

        }




    }
}
