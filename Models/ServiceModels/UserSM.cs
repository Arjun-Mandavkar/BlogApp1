namespace BlogApp1.Models.ServiceModels
{
    public class UserSM
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
