using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime RegistrationDate { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }  // Instead of "Phone" in UserProfileViewModel
    }
}
