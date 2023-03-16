namespace BlogApp1.Models.RequestModels
{
    public class CreateBlogCommentReM
    {
        public string BlogId { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }

    public class UpdateBlogCommentReM : CreateBlogCommentReM
    {
        public string Id { get; set; } = string.Empty;
    }
}
