﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Entities.ViewModels.UserProfile
{
    public class UserProfileViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsStudent { get; set; }
        public bool IsInstructor { get; set; }
    }
}
