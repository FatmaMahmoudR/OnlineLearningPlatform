using Microsoft.AspNetCore.Identity;
using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Entities.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }  
        public ICollection<Course> TaughtCourses { get; set; }


    }
}
