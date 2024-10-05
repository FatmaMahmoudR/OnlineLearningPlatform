using OnlineLearningPlatform.App.Models;
using OnlineLearningPlatform.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }  // FK -> User
        public Student Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }  // FK -> Course
        public Course Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public CompletionStatus CompletionStatus { get; set; }
        public int Progress { get; set; }  // 0-100 percentage 
    }
}
