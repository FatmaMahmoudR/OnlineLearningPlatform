using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform.App.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }  // Reference to the IdentityUser table


        // Navigation properties
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();


    }
}
