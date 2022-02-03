using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Models
{
    public class Book
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string AuthorID { get; set; }
        public DateTime PublishedAt { get; set; }
        public Author Author  { get; set; }

    }
}
