﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? Fees { get; set; }
        public int? Duration { get; set; }

    }
}
