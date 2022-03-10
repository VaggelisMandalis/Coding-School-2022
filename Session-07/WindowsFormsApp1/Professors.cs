using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Professors : Person
    {
        public string Rank { get; set; }

        public Course[] Courses { get; set; }
       
        public void Teach (Course course , DateTime Date)
        {

        }
        public void SetGrade(Guid studentId, Guid courseId, int grade)
        {

        }

        public new string GetName()
        {
            return "Dr. " + Name;
        }
    }
}
