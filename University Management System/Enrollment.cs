﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int? GradeId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; }
    }

}
