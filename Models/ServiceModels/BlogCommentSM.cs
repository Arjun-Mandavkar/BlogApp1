namespace BlogApp1.Models.ServiceModels
{
    public class CreateBlogCommentSM
    {
        public string BlogId { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }

    public class UpdateBlogCommentSM : CreateBlogCommentSM
    {
        public string Id { get; set; } = string.Empty;
    }
    public class BlogCommentSM : UpdateBlogCommentSM
    {
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
