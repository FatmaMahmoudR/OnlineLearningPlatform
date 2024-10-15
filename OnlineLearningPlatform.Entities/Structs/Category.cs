using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Helpers
{
    public enum Category
    {
        [Display(Name = "Web Development")]
        Web,
        [Display(Name = "Artificial Intelligence")]
        AI,
        [Display(Name = "Cloud Computing")]
        Cloud,
        [Display(Name = "Cyber Security")]
        CyberSecurity,
        [Display(Name = "Computer Network")]
        Network
    }
}