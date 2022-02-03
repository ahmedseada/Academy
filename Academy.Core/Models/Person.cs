using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Core.Models
{
    public class Person 
    {
        [Required]
        public string Id { get; set; }
        
        public string Name { get; set; }


    }
}
