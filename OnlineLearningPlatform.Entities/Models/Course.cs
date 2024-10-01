﻿using OnlineLearningPlatform.Helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public int EnrollmentCount { get; set; }

        // Navigation properties

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        //public ICollection<User> Users { get; set; }= new List<User>(); 

    }
}