using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student
    {
        Guid ID = Guid.NewGuid();
        public int RegistrationNumber { get; set; }

        public string getName() { return name; }
        public void setName(string name) { name = name; }
        public Student()
        {
            Guid ID = Guid.NewGuid();

        }
    }
}
