using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
    public Guid ID { get; } = Guid.NewGuid();
    public int age { get; set; }
    public string Name;
    public string getName() { return Name; }
    public void setName(string name) { Name = name; }
    public Person()
        {
            Guid ID = Guid.NewGuid();
        }

    }
    
}
