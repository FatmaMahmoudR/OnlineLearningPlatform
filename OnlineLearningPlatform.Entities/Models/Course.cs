using Microsoft.AspNetCore.Http;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public int EnrollmentCount { get; set; } = 0;
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }


        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        // Navigation properties

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public List<Lesson>? Lessons { get; set; }





    }
}
