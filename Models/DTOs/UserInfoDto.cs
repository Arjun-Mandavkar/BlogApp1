namespace BlogApp1.Models.DTOs
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string[]? Roles { get; set; }
    }
}
