﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public Enrollment Enrollment { get; set; }
    }

}
