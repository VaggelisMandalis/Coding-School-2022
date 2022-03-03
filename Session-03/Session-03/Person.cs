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
    public string Name { get; set; }
    public string GetName() { return Name; }
    public void SetName(string name) { Name = name; }
    public Person() { 
        
        } 
    }
    
}
