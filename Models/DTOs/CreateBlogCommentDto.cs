namespace BlogApp1.Models.DTOs
{
    public class CreateBlogCommentDto
    {
        public string BlogId { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }
}
