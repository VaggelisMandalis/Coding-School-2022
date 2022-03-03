using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Institute
    {


        
        public string getName() { return Name; }
        public void setName(string name) { Name = name; }
        public Institute()
        {
            Guid ID = Guid.NewGuid();
        }
    }
}
