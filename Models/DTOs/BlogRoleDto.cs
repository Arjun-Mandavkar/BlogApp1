using BlogApp1.Models.Enums;

namespace BlogApp1.Models.DTOs
{
    public class BlogRoleDto
    {
        public int BlogId { get; set; }
        public int UserId { get; set; }
        public BlogUserRole[]? Roles { get; set; }
    }
}
