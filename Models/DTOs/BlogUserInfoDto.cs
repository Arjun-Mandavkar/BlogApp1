namespace BlogApp1.Models.DTOs
{
    public class BlogUserInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string[]? Roles { get; set; }
    }
}
