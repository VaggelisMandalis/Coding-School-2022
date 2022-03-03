using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professors
    {
        Guid ID= Guid.NewGuid();
        public string name;
        public string Rank; 
        public string getName () { return name; }
        public void setName(string name) { name = name; }
        public Professors()
        {

        }
    }
}
