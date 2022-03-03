using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
       

        public string Name;
        public int YearsInService { get; set; }
        public string getName() { return Name; }
        public void setName(string name) { Name = name; }
        public Institute()
        {
            Guid ID = Guid.NewGuid();
        }
    }
}
