using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Grade
    {
        public Guid ID { get; } 
        public Guid StudentID { get; set; }
        public Guid CourseID { get; } = Guid.NewGuid();
    }
}
