using Btec_Website.Models.Btec_Website.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Btec_Website.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Collection navigation property
    }
}