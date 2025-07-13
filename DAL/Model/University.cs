using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address  { get; set; }
        public string? Email  { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

    }
}
