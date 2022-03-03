﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public  class Univercity : Institute
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] Schedules { get; set; }

        public University()
        {
            Students = new Student[30];
            Courses = new Course[20];
            Schedules = new Schedule[60];
        }
    }
}
