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

        [ForeignKey("Module")]
        public int ModuleId { get; set; } // FK -> Module
        public string Title { get; set; }
        public string ContentFilePath { get; set; } 
        public bool IsCompleted { get; set; } 

        // nav prop
        public Module Module { get; set; }
    }

}
