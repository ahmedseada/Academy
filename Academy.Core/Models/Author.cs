using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Models
{
    public class Author : Person
    {

        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
