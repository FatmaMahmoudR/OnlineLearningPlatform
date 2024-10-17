using Microsoft.AspNetCore.Http;
using OnlineLearningPlatform.Entities.Models;
using OnlineLearningPlatform.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MinLength(5, ErrorMessage = "course name must be at least 5 characters long.")]
        public string Name { get; set; }

        [MinLength(20, ErrorMessage = "The description must be at least 20 characters long.")]
        public string Description { get; set; }

        public Category? Category { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public int EnrollmentCount { get; set; } = 0;
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public bool Modified { get; set; } = false;

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public List<Lesson>? Lessons { get; set; }
    }
}
