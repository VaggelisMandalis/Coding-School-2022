using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Professors : Person
    {
       public new  Guid ID { get; } = Guid.NewGuid();
        
        public string Rank; 
        public string getName () { return name; }
        public void setName(string name) { name = name; }
        public Professors()
        {

        }
    }
}
