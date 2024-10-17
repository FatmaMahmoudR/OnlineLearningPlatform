
namespace OnlineLearningPlatform.Entities.ViewModels.Admin
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public List<SelectedRoles> UserRoles { get; set; }
    }
}
