using System.Collections.Generic;

namespace OnlineLearningPlatform.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        //public ICollection<Course> Courses { get; set; } = new List<Course>();  

    }
}
