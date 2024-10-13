using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Entities.Models
{
    public class LessonCompletion
    {
        public int Id { get; set; }

        [ForeignKey("Enrollment")]
        public int EnrollmentId { get; set; } // FK -> Enrollment Id
        public Enrollment Enrollment { get; set; }

        [ForeignKey("Lesson")]
        public int LessonId { get; set; } // FK -> Lesson Id
        public Lesson Lesson { get; set; }

        public bool IsCompleted { get; set; } = false;
    }

}
