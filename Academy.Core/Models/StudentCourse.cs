using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Models
{
    public enum CourseStatus
    {
        Completed,
        Canceled,
        Open
    }
    public class StudentCourse
    {
        public string ID { get; set; }

        public string StudentID { get; set; }

        public string CourseID { get; set; }

        public double Paid { get; set; }
        public CourseStatus Status { get; set; } = CourseStatus.Open;
 
    }
}
