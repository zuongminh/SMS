namespace Btec_Website.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace Btec_Website.Models
    {
        public class Subject
        {
            [Key]
            public int SubjectId { get; set; }
            public string Name { get; set; }
            public int CourseId { get; set; } // Foreign key

            public Course Course { get; set; } // Navigation property
        }
    }
}
