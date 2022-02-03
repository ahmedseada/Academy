using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Models
{
    public  class Course
    {
        [Required]
        public string ID { get; set; }

        public int NoOfStudents { get; set; }
        public string Title { get; set; }
        public string TeacherID { get; set; }

        public Author Teacher { get; set; }
    }
}
