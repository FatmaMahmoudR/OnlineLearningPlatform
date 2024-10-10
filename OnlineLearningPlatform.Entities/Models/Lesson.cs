using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Entities.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; } // FK -> Course
        public string Title { get; set; }

        public string? ContentFilePath { get; set; }

        // nav prop
        public Course? Course { get; set; }
        
    }

}
