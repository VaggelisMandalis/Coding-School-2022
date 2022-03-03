using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Grade
    {
        public Guid studentsID { get; } = Guid.NewGuid();
        public Guid CourseID { get; } = Guid.NewGuid();
    }
}
