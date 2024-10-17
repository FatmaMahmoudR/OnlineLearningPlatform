using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Entities.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; } // FK -> Course
        public string Title { get; set; }

        [CustomValidation(typeof(Lesson), nameof(ValidateYouTubeUrl), ErrorMessage = "The file path must be a valid YouTube link.")]
        public string FilePath { get; set; } 

        public Course? Course { get; set; }

        // Custom validation method for the YouTube URL
        public static ValidationResult? ValidateYouTubeUrl(string filePath, ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                return new ValidationResult("The file path is required.");
            }

            if (filePath.Contains("youtube.com") || filePath.Contains("youtu.be"))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The file path must be a valid YouTube link.");
        }
    }
}
