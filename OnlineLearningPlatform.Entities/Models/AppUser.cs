using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class AppUser : IdentityUser
    {
         public DateTime RegistrationDate { get; set; }
    }
}
